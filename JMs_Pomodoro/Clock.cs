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

        public Clock()
        {
            InitializeComponent();
            Init_CDTimer();
        }

        private void Init_CDTimer()
        {
            CDTimer = new CountDownTimer(59, 59);
            CDTimer.TimeChanged += () => Digit_clock.Text = CDTimer.TimeLeftMsStr;

        }


        /// <summary>
        /// 按一下開始計時, 再按一下取消計時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Work_Click(object sender, EventArgs e)
        {
            Click_timer(25);
        }


        /// <summary>
        /// 按一下開始休息, 再按一下暫停休息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Start_Rest_Click(object sender, EventArgs e)
        {
            Click_timer(5);
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


        private void button_ResetClock_Click(object sender, EventArgs e)
        {
            CDTimer.Stop();
            Init_CDTimer();
        }
    }
}
