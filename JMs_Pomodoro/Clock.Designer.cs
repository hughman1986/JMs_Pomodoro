namespace JMs_Pomodoro
{
    partial class Clock
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Digit_clock = new System.Windows.Forms.Label();
            this.button_Start_Work = new System.Windows.Forms.Button();
            this.button_Start_Rest = new System.Windows.Forms.Button();
            this.button_ResetClock = new System.Windows.Forms.Button();
            this.timer_Count_Down = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Digit_clock
            // 
            this.Digit_clock.AutoSize = true;
            this.Digit_clock.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit_clock.Location = new System.Drawing.Point(46, 9);
            this.Digit_clock.Name = "Digit_clock";
            this.Digit_clock.Size = new System.Drawing.Size(228, 97);
            this.Digit_clock.TabIndex = 0;
            this.Digit_clock.Text = "00:00";
            // 
            // button_Start_Work
            // 
            this.button_Start_Work.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Work.Location = new System.Drawing.Point(12, 109);
            this.button_Start_Work.Name = "button_Start_Work";
            this.button_Start_Work.Size = new System.Drawing.Size(146, 73);
            this.button_Start_Work.TabIndex = 1;
            this.button_Start_Work.Text = "Work";
            this.button_Start_Work.UseVisualStyleBackColor = true;
            this.button_Start_Work.Click += new System.EventHandler(this.button_Start_Work_Click);
            // 
            // button_Start_Rest
            // 
            this.button_Start_Rest.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Rest.Location = new System.Drawing.Point(164, 109);
            this.button_Start_Rest.Name = "button_Start_Rest";
            this.button_Start_Rest.Size = new System.Drawing.Size(146, 73);
            this.button_Start_Rest.TabIndex = 2;
            this.button_Start_Rest.Text = "Rest";
            this.button_Start_Rest.UseVisualStyleBackColor = true;
            this.button_Start_Rest.Click += new System.EventHandler(this.button_Start_Rest_Click);
            // 
            // button_ResetClock
            // 
            this.button_ResetClock.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetClock.Location = new System.Drawing.Point(12, 188);
            this.button_ResetClock.Name = "button_ResetClock";
            this.button_ResetClock.Size = new System.Drawing.Size(298, 73);
            this.button_ResetClock.TabIndex = 3;
            this.button_ResetClock.Text = "Reset Clock";
            this.button_ResetClock.UseVisualStyleBackColor = true;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 274);
            this.Controls.Add(this.button_ResetClock);
            this.Controls.Add(this.button_Start_Rest);
            this.Controls.Add(this.button_Start_Work);
            this.Controls.Add(this.Digit_clock);
            this.Name = "Clock";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Digit_clock;
        private System.Windows.Forms.Button button_Start_Work;
        private System.Windows.Forms.Button button_Start_Rest;
        private System.Windows.Forms.Button button_ResetClock;
        private System.Windows.Forms.Timer timer_Count_Down;
    }
}

