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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
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
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.button_Commit_MSG = new System.Windows.Forms.Button();
            this.dgv_tomato_table = new System.Windows.Forms.DataGridView();
            this.button_Zoom = new System.Windows.Forms.Button();
            this.richTextBox_QuickNote = new System.Windows.Forms.RichTextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tomato_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Digit_clock
            // 
            this.Digit_clock.AutoSize = true;
            this.Digit_clock.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Digit_clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Digit_clock.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit_clock.Location = new System.Drawing.Point(3, 0);
            this.Digit_clock.Name = "Digit_clock";
            this.Digit_clock.Size = new System.Drawing.Size(255, 100);
            this.Digit_clock.TabIndex = 0;
            this.Digit_clock.Text = "00:00";
            this.Digit_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start_Work
            // 
            this.button_Start_Work.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_Work.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Work.Location = new System.Drawing.Point(3, 2);
            this.button_Start_Work.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Start_Work.Name = "button_Start_Work";
            this.button_Start_Work.Size = new System.Drawing.Size(116, 50);
            this.button_Start_Work.TabIndex = 1;
            this.button_Start_Work.Text = "Work";
            this.button_Start_Work.UseVisualStyleBackColor = true;
            this.button_Start_Work.Click += new System.EventHandler(this.button_Start_Work_Click);
            // 
            // button_Start_Rest
            // 
            this.button_Start_Rest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_Rest.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button_Start_Rest.Location = new System.Drawing.Point(125, 2);
            this.button_Start_Rest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Start_Rest.Name = "button_Start_Rest";
            this.button_Start_Rest.Size = new System.Drawing.Size(117, 50);
            this.button_Start_Rest.TabIndex = 2;
            this.button_Start_Rest.Text = "Rest";
            this.button_Start_Rest.UseVisualStyleBackColor = true;
            this.button_Start_Rest.Click += new System.EventHandler(this.button_Start_Rest_Click);
            // 
            // button_ResetClock
            // 
            this.button_ResetClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ResetClock.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetClock.Location = new System.Drawing.Point(3, 62);
            this.button_ResetClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ResetClock.Name = "button_ResetClock";
            this.button_ResetClock.Size = new System.Drawing.Size(247, 56);
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
            this.label_num_of_tomato.Location = new System.Drawing.Point(8, 405);
            this.label_num_of_tomato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_num_of_tomato.Name = "label_num_of_tomato";
            this.label_num_of_tomato.Size = new System.Drawing.Size(0, 29);
            this.label_num_of_tomato.TabIndex = 4;
            this.label_num_of_tomato.DoubleClick += new System.EventHandler(this.label_num_of_tomato_DoubleClick);
            this.label_num_of_tomato.MouseHover += new System.EventHandler(this.label_num_of_tomato_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Digit_clock, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 44);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 226);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 103);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 120);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_pin
            // 
            this.btn_pin.BackColor = System.Drawing.Color.Pink;
            this.btn_pin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pin.Location = new System.Drawing.Point(4, 7);
            this.btn_pin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(56, 29);
            this.btn_pin.TabIndex = 7;
            this.btn_pin.Text = "Pin";
            this.btn_pin.UseVisualStyleBackColor = false;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // TextBox_Job_description
            // 
            this.TextBox_Job_description.Location = new System.Drawing.Point(4, 278);
            this.TextBox_Job_description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_Job_description.Name = "TextBox_Job_description";
            this.TextBox_Job_description.Size = new System.Drawing.Size(260, 85);
            this.TextBox_Job_description.TabIndex = 8;
            this.TextBox_Job_description.Text = "";
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenFolder.Location = new System.Drawing.Point(273, 8);
            this.button_OpenFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(231, 29);
            this.button_OpenFolder.TabIndex = 12;
            this.button_OpenFolder.Text = "Open Folder in File Explorer";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // button_Commit_MSG
            // 
            this.button_Commit_MSG.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Commit_MSG.Location = new System.Drawing.Point(4, 372);
            this.button_Commit_MSG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Commit_MSG.Name = "button_Commit_MSG";
            this.button_Commit_MSG.Size = new System.Drawing.Size(259, 29);
            this.button_Commit_MSG.TabIndex = 0;
            this.button_Commit_MSG.Text = "Commit Msg to current Tomato";
            this.button_Commit_MSG.UseVisualStyleBackColor = true;
            this.button_Commit_MSG.Click += new System.EventHandler(this.button_Commit_MSG_Click);
            // 
            // dgv_tomato_table
            // 
            this.dgv_tomato_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tomato_table.Location = new System.Drawing.Point(273, 44);
            this.dgv_tomato_table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_tomato_table.Name = "dgv_tomato_table";
            this.dgv_tomato_table.RowHeadersWidth = 51;
            this.dgv_tomato_table.RowTemplate.Height = 24;
            this.dgv_tomato_table.Size = new System.Drawing.Size(676, 226);
            this.dgv_tomato_table.TabIndex = 13;
            // 
            // button_Zoom
            // 
            this.button_Zoom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Zoom.Location = new System.Drawing.Point(201, 7);
            this.button_Zoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Zoom.Name = "button_Zoom";
            this.button_Zoom.Size = new System.Drawing.Size(64, 29);
            this.button_Zoom.TabIndex = 14;
            this.button_Zoom.Text = "Expand";
            this.button_Zoom.UseVisualStyleBackColor = true;
            this.button_Zoom.Click += new System.EventHandler(this.button_Zoom_Click);
            // 
            // richTextBox_QuickNote
            // 
            this.richTextBox_QuickNote.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox_QuickNote.Location = new System.Drawing.Point(273, 278);
            this.richTextBox_QuickNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox_QuickNote.Name = "richTextBox_QuickNote";
            this.richTextBox_QuickNote.Size = new System.Drawing.Size(676, 122);
            this.richTextBox_QuickNote.TabIndex = 15;
            this.richTextBox_QuickNote.Text = "";
            this.richTextBox_QuickNote.TextChanged += new System.EventHandler(this.richTextBox_QuickNote_TextChanged);
            this.richTextBox_QuickNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_QuickNote_KeyDown);
            this.richTextBox_QuickNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_QuickNote_KeyPress);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAVE.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(780, 405);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(169, 29);
            this.btnSAVE.TabIndex = 16;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(76, 14);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 18);
            this.label_Status.TabIndex = 17;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 443);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.richTextBox_QuickNote);
            this.Controls.Add(this.button_Zoom);
            this.Controls.Add(this.dgv_tomato_table);
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_Commit_MSG);
            this.Controls.Add(this.TextBox_Job_description);
            this.Controls.Add(this.btn_pin);
            this.Controls.Add(this.label_num_of_tomato);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Clock";
            this.Text = "Pomodoro";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tomato_table)).EndInit();
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
        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.Button button_Commit_MSG;
        private System.Windows.Forms.DataGridView dgv_tomato_table;
        private System.Windows.Forms.Button button_Zoom;
        private System.Windows.Forms.RichTextBox richTextBox_QuickNote;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label label_Status;
    }
}

