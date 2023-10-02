namespace KTV
{
    partial class Form_ps
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.chk_clean = new System.Windows.Forms.CheckBox();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.chk_pay = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 107);
            this.panel1.TabIndex = 13;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Linen;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(11, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 50);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "其他服務(請在以下簡述 限300字)：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(68, 421);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 174);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "制式服務：";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Linen;
            this.btn_send.Enabled = false;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_send.Location = new System.Drawing.Point(620, 328);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(188, 112);
            this.btn_send.TabIndex = 18;
            this.btn_send.Text = "送出";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // chk_clean
            // 
            this.chk_clean.AutoSize = true;
            this.chk_clean.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_clean.Location = new System.Drawing.Point(68, 188);
            this.chk_clean.Name = "chk_clean";
            this.chk_clean.Size = new System.Drawing.Size(99, 42);
            this.chk_clean.TabIndex = 19;
            this.chk_clean.Text = "清潔";
            this.chk_clean.UseVisualStyleBackColor = true;
            this.chk_clean.CheckedChanged += new System.EventHandler(this.chk_clean_CheckedChanged);
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_add.Location = new System.Drawing.Point(68, 247);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(99, 42);
            this.chk_add.TabIndex = 20;
            this.chk_add.Text = "加時";
            this.chk_add.UseVisualStyleBackColor = true;
            this.chk_add.CheckedChanged += new System.EventHandler(this.chk_add_CheckedChanged);
            // 
            // chk_pay
            // 
            this.chk_pay.AutoSize = true;
            this.chk_pay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_pay.Location = new System.Drawing.Point(68, 304);
            this.chk_pay.Name = "chk_pay";
            this.chk_pay.Size = new System.Drawing.Size(99, 42);
            this.chk_pay.TabIndex = 21;
            this.chk_pay.Text = "結帳";
            this.chk_pay.UseVisualStyleBackColor = true;
            this.chk_pay.CheckedChanged += new System.EventHandler(this.chk_pay_CheckedChanged);
            // 
            // Form_ps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 628);
            this.Controls.Add(this.chk_pay);
            this.Controls.Add(this.chk_add);
            this.Controls.Add(this.chk_clean);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ps";
            this.Text = "Form_ps";
            this.Load += new System.EventHandler(this.Form_ps_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.CheckBox chk_clean;
        private System.Windows.Forms.CheckBox chk_add;
        private System.Windows.Forms.CheckBox chk_pay;
    }
}