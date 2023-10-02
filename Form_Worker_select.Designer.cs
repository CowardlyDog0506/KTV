namespace KTV
{
    partial class Form_Worker_select
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_check_sevice = new System.Windows.Forms.Button();
            this.btn_check_room = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_check_sevice
            // 
            this.btn_check_sevice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check_sevice.Location = new System.Drawing.Point(60, 269);
            this.btn_check_sevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_check_sevice.Name = "btn_check_sevice";
            this.btn_check_sevice.Size = new System.Drawing.Size(158, 106);
            this.btn_check_sevice.TabIndex = 10;
            this.btn_check_sevice.Text = "服務序列";
            this.btn_check_sevice.UseVisualStyleBackColor = true;
            this.btn_check_sevice.Click += new System.EventHandler(this.btn_check_sevice_Click);
            // 
            // btn_check_room
            // 
            this.btn_check_room.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check_room.Location = new System.Drawing.Point(274, 269);
            this.btn_check_room.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_check_room.Name = "btn_check_room";
            this.btn_check_room.Size = new System.Drawing.Size(160, 106);
            this.btn_check_room.TabIndex = 11;
            this.btn_check_room.Text = "房間";
            this.btn_check_room.UseVisualStyleBackColor = true;
            this.btn_check_room.Click += new System.EventHandler(this.btn_check_room_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_statistic.Location = new System.Drawing.Point(495, 269);
            this.btn_statistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(162, 106);
            this.btn_statistic.TabIndex = 13;
            this.btn_statistic.Text = "統計";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 162);
            this.panel1.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Linen;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(7, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 40);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_Worker_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(699, 502);
            this.Controls.Add(this.btn_statistic);
            this.Controls.Add(this.btn_check_room);
            this.Controls.Add(this.btn_check_sevice);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Worker_select";
            this.Text = "Worker_select";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_check_sevice;
        private System.Windows.Forms.Button btn_check_room;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
    }
}