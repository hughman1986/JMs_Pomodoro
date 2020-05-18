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
                label_num_of_tomato.Text += $"O ";
        }


        private void Init_CDTimer()
        {
            CDTimer = new CountDownTimer(59, 59);
            Digit_clock.Text = $"00:00";
            CDTimer.TimeChanged += () => Digit_clock.Text = CDTimer.TimeLeftMsStr;
            CDTimer.CountDownFinished += new Action(Work_count_down_finished);

        }


        /// <summary>
        /// 工作倒數完後的動作
        /// </summary>
        private void Work_count_down_finished()
        {

            Current_Tomato.Work_description = TextBox_Job_description.Text;
            Tomato_bucket.Add(Current_Tomato);
            SaveTomato.Serialize_JSON_to_a_file<List<Tomato>>(Tomato_bucket);

            label_num_of_tomato.Text += $"O ";
            Init_CDTimer();
        }

        /// <summary>
        /// 已完成的番茄鐘
        /// </summary>
        private class Tomato
        {
            public DateTime Tomato_StartTime;
            public string TomatoType = "work";
            public int Tomato_Duration = 25;
            public string Work_description = "";
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
            Click_on_Timer(Set_time_minute);
            Digit_clock.BackColor = Color.Red;

            Current_Tomato = new Tomato
            {
                Tomato_StartTime = DateTime.Now,
                TomatoType = "work",
                Tomato_Duration = Set_time_minute
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
            Click_on_Timer(Set_time_minute);
            Digit_clock.BackColor = Color.Green;

            Current_Tomato = new Tomato
            {
                Tomato_StartTime = DateTime.Now,
                TomatoType = "rest",
                Tomato_Duration = Set_time_minute
            };
        }


        /// <summary>
        /// 按下計時器按鈕
        /// input: 設定倒數幾分鐘 
        /// </summary>
        /// <param name="set_time_min"></param>
        private void Click_on_Timer(int set_time_min, int set_time_sec = 0)
        {
            if (CDTimer.IsRunnign)
            {
                CDTimer.Pause();
            }
            else if (CDTimer.TimeLeft == new DateTime(1, 1, 1, 0, 59, 59))
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
            Digit_clock.BackColor = Color.LightSteelBlue;
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
                label_num_of_tomato.Text = $"_";

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
            Current_Tomato.Work_description = TextBox_Job_description.Text;
            if (Tomato_bucket.Count > 0)
                Tomato_bucket[Tomato_bucket.Count - 1] = Current_Tomato;

            SaveTomato.Serialize_JSON_to_a_file<List<Tomato>>(Tomato_bucket);
        }

        private void button_interupted_Click(object sender, EventArgs e)
        {

        }

        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            string TomatpPath = $".\\TomatoLog\\";

            if (!Directory.Exists(TomatpPath))
                Directory.CreateDirectory(TomatpPath);

            Process.Start($".\\TomatoLog\\");
        }
    }
}
