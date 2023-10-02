namespace KTV
{
    partial class Form_new
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
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_hr = new System.Windows.Forms.TextBox();
            this.lb_hr = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(932, 202);
            this.panel1.TabIndex = 17;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Linen;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_back.Location = new System.Drawing.Point(9, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 50);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_name.Location = new System.Drawing.Point(256, 220);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(85, 38);
            this.lb_name.TabIndex = 18;
            this.lb_name.Text = "姓名:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(369, 217);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(303, 47);
            this.tb_name.TabIndex = 19;
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_phone.Location = new System.Drawing.Point(369, 346);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(303, 47);
            this.tb_phone.TabIndex = 21;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_phone.Location = new System.Drawing.Point(196, 349);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(145, 38);
            this.lb_phone.TabIndex = 20;
            this.lb_phone.Text = "電話號碼:";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_id.Location = new System.Drawing.Point(369, 282);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(303, 47);
            this.tb_id.TabIndex = 23;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_id.Location = new System.Drawing.Point(196, 282);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(145, 38);
            this.lb_id.TabIndex = 22;
            this.lb_id.Text = "身分證號:";
            // 
            // tb_room
            // 
            this.tb_room.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_room.Location = new System.Drawing.Point(369, 409);
            this.tb_room.Name = "tb_room";
            this.tb_room.ReadOnly = true;
            this.tb_room.Size = new System.Drawing.Size(303, 47);
            this.tb_room.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(226, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 38);
            this.label2.TabIndex = 24;
            this.label2.Text = "包間號:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Linen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Location = new System.Drawing.Point(410, 531);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 65);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_hr
            // 
            this.tb_hr.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_hr.Location = new System.Drawing.Point(369, 472);
            this.tb_hr.Name = "tb_hr";
            this.tb_hr.Size = new System.Drawing.Size(303, 47);
            this.tb_hr.TabIndex = 28;
            this.tb_hr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_hr_KeyPress);
            // 
            // lb_hr
            // 
            this.lb_hr.AutoSize = true;
            this.lb_hr.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_hr.Location = new System.Drawing.Point(196, 475);
            this.lb_hr.Name = "lb_hr";
            this.lb_hr.Size = new System.Drawing.Size(145, 38);
            this.lb_hr.TabIndex = 27;
            this.lb_hr.Text = "租用時數:";
            // 
            // Form_new
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 628);
            this.Controls.Add(this.tb_hr);
            this.Controls.Add(this.lb_hr);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_new";
            this.Text = "Form_new";
            this.Load += new System.EventHandler(this.Form_new_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_hr;
        private System.Windows.Forms.Label lb_hr;
    }
}