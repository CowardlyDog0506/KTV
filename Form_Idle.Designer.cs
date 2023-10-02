namespace KTV
{
    partial class IDLE
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
            this.btn_Worker = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.btn_wlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Worker
            // 
            this.btn_Worker.AutoSize = true;
            this.btn_Worker.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Worker.Location = new System.Drawing.Point(60, 182);
            this.btn_Worker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(198, 91);
            this.btn_Worker.TabIndex = 8;
            this.btn_Worker.Text = "Worker";
            this.btn_Worker.UseVisualStyleBackColor = true;
            this.btn_Worker.Click += new System.EventHandler(this.btn_Worker_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.AutoSize = true;
            this.btn_Guest.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_Guest.Location = new System.Drawing.Point(338, 182);
            this.btn_Guest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(198, 91);
            this.btn_Guest.TabIndex = 9;
            this.btn_Guest.Text = "Guest";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_password.Location = new System.Drawing.Point(239, 143);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 16);
            this.label_password.TabIndex = 14;
            this.label_password.Text = "password";
            this.label_password.Visible = false;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_account.Location = new System.Drawing.Point(239, 50);
            this.label_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(57, 16);
            this.label_account.TabIndex = 13;
            this.label_account.Text = "account";
            this.label_account.Visible = false;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(299, 182);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(240, 22);
            this.tb_pw.TabIndex = 12;
            this.tb_pw.Visible = false;
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(299, 92);
            this.tb_account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(240, 22);
            this.tb_account.TabIndex = 11;
            this.tb_account.Visible = false;
            // 
            // btn_wlogin
            // 
            this.btn_wlogin.AutoSize = true;
            this.btn_wlogin.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_wlogin.Location = new System.Drawing.Point(338, 254);
            this.btn_wlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_wlogin.Name = "btn_wlogin";
            this.btn_wlogin.Size = new System.Drawing.Size(162, 73);
            this.btn_wlogin.TabIndex = 10;
            this.btn_wlogin.Text = "Login";
            this.btn_wlogin.UseVisualStyleBackColor = true;
            this.btn_wlogin.Visible = false;
            this.btn_wlogin.Click += new System.EventHandler(this.btn_wlogin_Click);
            // 
            // IDLE
            // 
            this.AcceptButton = this.btn_wlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btn_Worker);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.btn_wlogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "IDLE";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Button btn_wlogin;
    }
}

