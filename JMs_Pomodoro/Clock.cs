using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMs_Pomodoro
{
    public partial class Clock : Form
    {

        private CountDownTimer CDTimer = new CountDownTimer(59, 59);
        ToolTip tip_tomato = new ToolTip();

        public Clock()
        {
            InitializeComponent();
            Init_CDTimer();
        }

        private void Init_CDTimer()
        {
            CDTimer = new CountDownTimer(59, 59);
            Digit_clock.Text = $"00:00";
            CDTimer.TimeChanged += () => Digit_clock.Text = CDTimer.TimeLeftMsStr;
            CDTimer.CountDownFinished += new Action(Work_count_down_finished);

        }


        /// <summary>
        /// 按一下開始計時, 再按一下取消計時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Work_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = true;
            Click_timer(25);
            Digit_clock.BackColor = Color.Red;
        }


        /// <summary>
        /// 按一下開始休息, 再按一下暫停休息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Rest_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = true;
            Click_timer(5);
            Digit_clock.BackColor = Color.Green;
        }


        /// <summary>
        /// 按下計時器按鈕
        /// input: 設定倒數幾分鐘 
        /// </summary>
        /// <param name="set_time_min"></param>
        private void Click_timer(int set_time_min, int set_time_sec = 0)
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

        /// <summary>
        /// 工作倒數完後的動作
        /// </summary>
        private void Work_count_down_finished()
        {
            label_num_of_tomato.Text += $"O_";
            Init_CDTimer();
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
    }
}
