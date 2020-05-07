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
            this.label_num_of_tomato = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_pin = new System.Windows.Forms.Button();
            this.TextBox_Job_description = new System.Windows.Forms.RichTextBox();
            this.button_Commit_MSG = new System.Windows.Forms.Button();
            this.richTextBox_Interuption = new System.Windows.Forms.RichTextBox();
            this.button_interupted = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Digit_clock
            // 
            this.Digit_clock.AutoSize = true;
            this.Digit_clock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Digit_clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Digit_clock.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit_clock.Location = new System.Drawing.Point(2, 0);
            this.Digit_clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Digit_clock.Name = "Digit_clock";
            this.Digit_clock.Size = new System.Drawing.Size(192, 80);
            this.Digit_clock.TabIndex = 0;
            this.Digit_clock.Text = "00:00";
            this.Digit_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start_Work
            // 
            this.button_Start_Work.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_Work.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Work.Location = new System.Drawing.Point(2, 2);
            this.button_Start_Work.Margin = new System.Windows.Forms.Padding(2);
            this.button_Start_Work.Name = "button_Start_Work";
            this.button_Start_Work.Size = new System.Drawing.Size(88, 37);
            this.button_Start_Work.TabIndex = 1;
            this.button_Start_Work.Text = "Work";
            this.button_Start_Work.UseVisualStyleBackColor = true;
            this.button_Start_Work.Click += new System.EventHandler(this.button_Start_Work_Click);
            // 
            // button_Start_Rest
            // 
            this.button_Start_Rest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_Rest.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Rest.Location = new System.Drawing.Point(94, 2);
            this.button_Start_Rest.Margin = new System.Windows.Forms.Padding(2);
            this.button_Start_Rest.Name = "button_Start_Rest";
            this.button_Start_Rest.Size = new System.Drawing.Size(88, 37);
            this.button_Start_Rest.TabIndex = 2;
            this.button_Start_Rest.Text = "Rest";
            this.button_Start_Rest.UseVisualStyleBackColor = true;
            this.button_Start_Rest.Click += new System.EventHandler(this.button_Start_Rest_Click);
            // 
            // button_ResetClock
            // 
            this.button_ResetClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ResetClock.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetClock.Location = new System.Drawing.Point(2, 49);
            this.button_ResetClock.Margin = new System.Windows.Forms.Padding(2);
            this.button_ResetClock.Name = "button_ResetClock";
            this.button_ResetClock.Size = new System.Drawing.Size(186, 44);
            this.button_ResetClock.TabIndex = 3;
            this.button_ResetClock.Text = "Reset Clock";
            this.button_ResetClock.UseVisualStyleBackColor = true;
            this.button_ResetClock.Click += new System.EventHandler(this.button_ResetClock_Click);
            // 
            // label_num_of_tomato
            // 
            this.label_num_of_tomato.AutoSize = true;
            this.label_num_of_tomato.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_of_tomato.ForeColor = System.Drawing.Color.Red;
            this.label_num_of_tomato.Location = new System.Drawing.Point(80, 6);
            this.label_num_of_tomato.Name = "label_num_of_tomato";
            this.label_num_of_tomato.Size = new System.Drawing.Size(19, 23);
            this.label_num_of_tomato.TabIndex = 4;
            this.label_num_of_tomato.Text = "_";
            this.label_num_of_tomato.DoubleClick += new System.EventHandler(this.label_num_of_tomato_DoubleClick);
            this.label_num_of_tomato.MouseHover += new System.EventHandler(this.label_num_of_tomato_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Digit_clock, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 181);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_ResetClock, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 95);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Start_Work, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Start_Rest, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(184, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_pin
            // 
            this.btn_pin.Location = new System.Drawing.Point(3, 6);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(75, 23);
            this.btn_pin.TabIndex = 7;
            this.btn_pin.Text = "Pin on Top ";
            this.btn_pin.UseVisualStyleBackColor = true;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // TextBox_Job_description
            // 
            this.TextBox_Job_description.Location = new System.Drawing.Point(205, 35);
            this.TextBox_Job_description.Name = "TextBox_Job_description";
            this.TextBox_Job_description.Size = new System.Drawing.Size(222, 69);
            this.TextBox_Job_description.TabIndex = 8;
            this.TextBox_Job_description.Text = "";
            // 
            // button_Commit_MSG
            // 
            this.button_Commit_MSG.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Commit_MSG.Location = new System.Drawing.Point(205, 110);
            this.button_Commit_MSG.Name = "button_Commit_MSG";
            this.button_Commit_MSG.Size = new System.Drawing.Size(173, 23);
            this.button_Commit_MSG.TabIndex = 0;
            this.button_Commit_MSG.Text = "Commit Msg to current Tomato";
            this.button_Commit_MSG.UseVisualStyleBackColor = true;
            this.button_Commit_MSG.Click += new System.EventHandler(this.button_Commit_MSG_Click);
            // 
            // richTextBox_Interuption
            // 
            this.richTextBox_Interuption.Location = new System.Drawing.Point(205, 139);
            this.richTextBox_Interuption.Name = "richTextBox_Interuption";
            this.richTextBox_Interuption.Size = new System.Drawing.Size(222, 51);
            this.richTextBox_Interuption.TabIndex = 10;
            this.richTextBox_Interuption.Text = "";
            // 
            // button_interupted
            // 
            this.button_interupted.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.button_interupted.Location = new System.Drawing.Point(205, 193);
            this.button_interupted.Name = "button_interupted";
            this.button_interupted.Size = new System.Drawing.Size(84, 23);
            this.button_interupted.TabIndex = 11;
            this.button_interupted.Text = "Interupted";
            this.button_interupted.UseVisualStyleBackColor = true;
            this.button_interupted.Click += new System.EventHandler(this.button_interupted_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 219);
            this.Controls.Add(this.button_Commit_MSG);
            this.Controls.Add(this.richTextBox_Interuption);
            this.Controls.Add(this.TextBox_Job_description);
            this.Controls.Add(this.button_interupted);
            this.Controls.Add(this.btn_pin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_num_of_tomato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clock";
            this.Text = "Pomodoro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Digit_clock;
        private System.Windows.Forms.Button button_Start_Work;
        private System.Windows.Forms.Button button_Start_Rest;
        private System.Windows.Forms.Button button_ResetClock;
        private System.Windows.Forms.Timer timer_Count_Down;
        private System.Windows.Forms.Label label_num_of_tomato;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_pin;
        private System.Windows.Forms.RichTextBox TextBox_Job_description;
        private System.Windows.Forms.Button button_Commit_MSG;
        private System.Windows.Forms.RichTextBox richTextBox_Interuption;
        private System.Windows.Forms.Button button_interupted;
    }
}

