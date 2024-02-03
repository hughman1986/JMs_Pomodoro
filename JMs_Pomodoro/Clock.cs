using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JMs_Pomodoro.ClassUtilitis;

namespace JMs_Pomodoro
{
    public partial class Clock : Form
    {

        private CountDownTimer CDTimer = new CountDownTimer(59, 59);
        ToolTip tip_tomato = new ToolTip();

        private Tomato Current_Tomato = new Tomato();
        private List<Tomato> Tomato_bucket = new List<Tomato>();

        JSON_File_Operator SaveTomato = new JSON_File_Operator($"./TomatoLog/{DateTime.Now.ToString("yyyyMMdd")}/TOMATO.json");

        public class clsConfig
        {

            public int min_work = 25;
            public int min_rest = 5;

        }

        public string JsonFilePath = "config.json";

        clsConfig tomato_config = new clsConfig();

        /// <summary>
        /// 從JSON讀取參數, 若參數不存在產生預設參數並存檔 
        /// </summary>
        public void LoadConfig(string jsonfilepath, ref clsConfig config)
        {
            try
            {
                // 檢查檔案是否存在
                if (File.Exists(jsonfilepath))
                {
                    // 讀取JSON檔案
                    string jsonContent = File.ReadAllText(jsonfilepath);
                    // 將JSON轉換為物件
                    config = JsonConvert.DeserializeObject<clsConfig>(jsonContent);
                }
                else
                {
                    // 如果檔案不存在，使用預設值
                    Console.WriteLine("Config file not found. Using default values.");
                    // 寫入預設設定到JSON檔案
                    string defaultJson = JsonConvert.SerializeObject(config, Formatting.Indented);
                    File.WriteAllText(jsonfilepath, defaultJson);
                }
            }
            catch (Exception ex)
            {
                // 處理讀取或解析失敗的例外狀況
                Console.WriteLine($"Error loading config: {ex.Message}");
            }
        }



        public Clock()
        {
            InitializeComponent();
            Init_CDTimer();

            load_Todays_data();

            Update_TomatoList_to_DataGridView();

            // 預設成小視窗模式 
            this.Size = new Size(219, 400);

            LoadConfig(JsonFilePath, ref tomato_config);
        }

        private void load_Todays_data()
        {
            // 從json存檔載入紀錄 
            Tomato_bucket = (List<Tomato>)SaveTomato.Deserialize_JSON_from_a_file<List<Tomato>>(Tomato_bucket);
            for (int i = 0; i < Tomato_bucket.Count; i++)
                if (Tomato_bucket[i].TomatoType == "work")
                    label_num_of_tomato.Text += $"🍅 ";

            // 載入暫存文字
            try
            {
                string filepath = $"./TomatoLog/tmptxt.txt";

                // 檢查檔案是否存在
                if (File.Exists(filepath))
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        // 從文字檔載入內容
                        string content = reader.ReadToEnd();
                        richTextBox_QuickNote.Text = content;
                    }
                }
                else
                {
                    Console.WriteLine("檔案不存在。");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"發生錯誤: {ex.Message}");
            }
        }


        private void Init_CDTimer()
        {
            CDTimer = new CountDownTimer(00, 00);
            CDTimer.TimeChanged += () => Digit_clock.Text = CDTimer.TimeLeftMsStr;
            CDTimer.CountDownFinished += new Action(CDTimer_OnCountDownFinished);

            Digit_clock.Text = $"00:00";
        }

        /// <summary>
        /// 計時器倒數完成後的動作: 切換成黃燈以及紀錄結束時間
        /// </summary>
        private void CDTimer_OnCountDownFinished()
        {
            button_Start_Rest.Enabled = false;
            button_Start_Work.Enabled = false;

            Digit_clock.BackColor = Color.Yellow;
            Current_Tomato.Tomato_EndTime = DateTime.Now;
            label_Status.Text = "Clock STOPPED";

            Task.Run(() => play_alarm_sound());
        }

        /// <summary>
        /// 重製UI狀態
        /// </summary>
        private void reset_UI_item()
        {
            button_Start_Rest.Enabled = true;
            button_Start_Work.Enabled = true;
            TextBox_Job_description.Text = "";
            label_Status.Text = "";
            Digit_clock.BackColor = Color.LightSteelBlue;
            Current_Tomato = new Tomato();
        }


        /// <summary>
        /// 已完成的番茄鐘
        /// </summary>
        private class Tomato
        {
            public DateTime Tomato_StartTime;
            public DateTime Tomato_EndTime;
            public string TomatoType = "work";
            public int Tomato_Duration = 25;
            public string Work_description = "";
        }

        private void Update_TomatoList_to_DataGridView()
        {

            dgv_tomato_table.DataSource = Tomato_bucket.Select(
                Tomato => new
                {
                    Tomato.Tomato_StartTime,
                    Tomato.TomatoType,
                    Tomato.Tomato_Duration,
                    Tomato.Work_description
                }).ToList(); ;
        }


        /// <summary>
        /// 按一下開始計時, 再按一下取消計時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Work_Click(object sender, EventArgs e)
        {
            int Set_time_minute = tomato_config.min_work;
            ActiveForm.TopMost = true;
            Click_on_Timer(Set_time_minute, Color.Red);

            if (CDTimer.IsRunnign)
                button_Start_Rest.Enabled = false;


            Current_Tomato = new Tomato
            {
                Tomato_StartTime = DateTime.Now,
                TomatoType = "work",
            };


        }


        /// <summary>
        /// 按一下開始休息, 再按一下暫停休息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Rest_Click(object sender, EventArgs e)
        {
            int Set_time_minute = tomato_config.min_rest;

            ActiveForm.TopMost = true;
            Click_on_Timer(Set_time_minute, Color.Green);
            if (CDTimer.IsRunnign)
                button_Start_Work.Enabled = false;

            TextBox_Job_description.Text = "Rest";

            Current_Tomato = new Tomato
            {
                Tomato_StartTime = DateTime.Now,
                TomatoType = "rest",
            };
        }


        /// <summary>
        /// 按下計時器按鈕
        /// input: 設定倒數幾分鐘 
        /// </summary>
        /// <param name="set_time_min"></param>
        private void Click_on_Timer(int set_time_min, Color color, int set_time_sec = 0)
        {
            Digit_clock.BackColor = color;

            if (CDTimer.IsRunnign)
            {
                CDTimer.Pause();
                label_Status.Text = "Clock STOPPED";

            }
            else if (CDTimer.TimeLeft == new DateTime(1, 1, 1, 0, 0, 0))
            {
                CDTimer.SetTime(set_time_min, set_time_sec);
                CDTimer.Start();
                label_Status.Text = "Clock RUNNING";
            }
            else
            {
                CDTimer.Start();
                label_Status.Text = "Clock RUNNING";
            }
        }


        private void button_ResetClock_Click(object sender, EventArgs e)
        {
            CDTimer.Stop();
            Init_CDTimer();
            reset_UI_item();
        }

        /// <summary>
        /// DoubleClick清空番茄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_num_of_tomato_DoubleClick(object sender, EventArgs e)
        {
            var btn_action = MessageBox.Show("Remove all tomato?", "", MessageBoxButtons.YesNo);

            if (btn_action == DialogResult.Yes)
            {
                CDTimer.Stop();
                Init_CDTimer();
                label_num_of_tomato.Text = $"";

                Current_Tomato = new Tomato();
                Tomato_bucket = new List<Tomato>();
            }
        }

        private void label_num_of_tomato_MouseHover(object sender, EventArgs e)
        {
            tip_tomato.SetToolTip(label_num_of_tomato, "Double Click to Clearn All Tomato");
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            // pin在最上層 
            if (ActiveForm.TopMost == true)
            {
                ActiveForm.TopMost = false;
                btn_pin.BackColor = Color.Pink;
            }
            else
            {
                ActiveForm.TopMost = true;
                btn_pin.BackColor = Color.Red;
            }
        }

        private void button_Commit_MSG_Click(object sender, EventArgs e)
        {
            if (Current_Tomato.Tomato_StartTime == new DateTime())
            {
                Init_CDTimer();
                reset_UI_item();
                return;
            }
            Current_Tomato.Work_description = TextBox_Job_description.Text;
            if (CDTimer.IsRunnign)
                Current_Tomato.Tomato_EndTime = DateTime.Now;

            TimeSpan TomatoDuration = Current_Tomato.Tomato_EndTime - Current_Tomato.Tomato_StartTime;
            Current_Tomato.Tomato_Duration = (int)TomatoDuration.TotalMinutes;

            Tomato_bucket.Add(Current_Tomato);
            SaveTomato.Serialize_JSON_to_a_file(Tomato_bucket);

            if (Current_Tomato.TomatoType == "work")
                label_num_of_tomato.Text += $"🍅 ";

            Update_TomatoList_to_DataGridView();

            Init_CDTimer();
            reset_UI_item();
        }

        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            string TomatpPath = $".\\TomatoLog\\";

            if (!Directory.Exists(TomatpPath))
                Directory.CreateDirectory(TomatpPath);

            Process.Start($".\\TomatoLog\\");
        }

        private void button_Zoom_Click(object sender, EventArgs e)
        {
            if (this.Size == new Size(800, 400))
            {
                this.Size = new Size(219, 400);
            }
            else
            {
                this.Size = new Size(800, 400);
            }
        }

        private void richTextBox_QuickNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 在儲存格按下enter或backspace或,後的動作, 但是keypress事件不會捕捉空白鍵
            if (e.KeyChar == '\r' || e.KeyChar == '\b' || e.KeyChar == ',')
            {
                bool save_sucess = SaveQuickNote();

                if (save_sucess)
                {
                    btnSAVE.Text = "saved!";
                    btnSAVE.ForeColor = Color.Green;
                }
            }
        }


        private void richTextBox_QuickNote_TextChanged(object sender, EventArgs e)
        {
            btnSAVE.Text = "edit NOT save!!";
            btnSAVE.ForeColor = Color.Red;
        }


        private void play_alarm_sound()
        {
            SystemSounds.Beep.Play();
            Thread.Sleep(300);
            SystemSounds.Beep.Play();
            Thread.Sleep(300);
            SystemSounds.Beep.Play();

            //var player = new SoundPlayer();
            //player.SoundLocation = "http://billor.chsh.chc.edu.tw/sound/ambul.wav";
            //player.LoadAsync();
            //player.PlaySync();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            bool save_sucess = SaveQuickNote();

            if (save_sucess)
            {
                btnSAVE.Text = "saved!";
                btnSAVE.ForeColor = Color.Green;
            }
        }

        private bool SaveQuickNote()
        {
            string filepath = $"./TomatoLog/tmptxt.txt";

            try
            {
                // 確認目錄存在，如果不存在就建立
                string directoryPath = Path.GetDirectoryName(filepath);
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                // 將字串寫入文字檔
                File.WriteAllText(filepath, richTextBox_QuickNote.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"發生錯誤: {ex.Message}");
                return false;
            }

            return true;
        }

    }
}
