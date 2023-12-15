using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        public Clock()
        {
            InitializeComponent();
            Init_CDTimer();
            Tomato_bucket = (List<Tomato>)SaveTomato.Deserialize_JSON_from_a_file<List<Tomato>>(Tomato_bucket);

            for (int i = 0; i < Tomato_bucket.Count; i++)
                label_num_of_tomato.Text += $"🍅 ";

            Update_TomatoList_to_DataGridView();

            // 預設成小視窗模式 
            this.Size = new Size(219, 400);
        }


        private void Init_CDTimer()
        {
            CDTimer = new CountDownTimer(00, 00);
            CDTimer.TimeChanged += () => Digit_clock.Text = CDTimer.TimeLeftMsStr;

            Digit_clock.Text = $"00:00";
        }


        /// <summary>
        /// 重製UI狀態
        /// </summary>
        private void reset_UI_item()
        {
            button_Start_Rest.Enabled = true;
            button_Start_Work.Enabled = true;
            TextBox_Job_description.Text = "";

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


        private void Save_DataGridView_to_JSON_Tomato()
        {
            SaveTomato.Serialize_JSON_to_a_file(dgv_tomato_table.DataSource);
        }


        /// <summary>
        /// 被打算的時間記錄
        /// </summary>
        private class Interruption
        {
            public DateTime interrupt_time;
            public string Work_description = "";
        }

        /// <summary>
        /// 按一下開始計時, 再按一下取消計時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Work_Click(object sender, EventArgs e)
        {
            int Set_time_minute = 25;
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
            int Set_time_minute = 5;

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
            }
            else if (CDTimer.TimeLeft == new DateTime(1, 1, 1, 0, 0, 0))
            {
                CDTimer.SetTime(set_time_min, set_time_sec);
                CDTimer.Start();
            }
            else
            {
                CDTimer.Start();
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
            Current_Tomato.Tomato_EndTime = DateTime.Now;
            TimeSpan TomatoDuration = Current_Tomato.Tomato_StartTime - Current_Tomato.Tomato_EndTime;
            Current_Tomato.Tomato_Duration = (int)TomatoDuration.TotalMinutes;

            Tomato_bucket.Add(Current_Tomato);
            SaveTomato.Serialize_JSON_to_a_file(Tomato_bucket);
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
    }
}
