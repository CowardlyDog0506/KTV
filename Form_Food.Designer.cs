namespace KTV
{
    partial class Form_Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Food));
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cb_food = new System.Windows.Forms.ComboBox();
            this.cb_room = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_list = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_ps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.btn_cancel2 = new System.Windows.Forms.Button();
            this.btn_cancel3 = new System.Windows.Forms.Button();
            this.btn_cancel4 = new System.Windows.Forms.Button();
            this.btn_cancel5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 89);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(230, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(444, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(662, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 175);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(881, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(175, 175);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // cb_food
            // 
            this.cb_food.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_food.FormattingEnabled = true;
            this.cb_food.Items.AddRange(new object[] {
            "炸雞 $80",
            "漢堡 $65",
            "薯條 $40",
            "紅茶 $30",
            "可樂 $30"});
            this.cb_food.Location = new System.Drawing.Point(491, 385);
            this.cb_food.Name = "cb_food";
            this.cb_food.Size = new System.Drawing.Size(223, 46);
            this.cb_food.TabIndex = 22;
            // 
            // cb_room
            // 
            this.cb_room.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_room.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_room.FormattingEnabled = true;
            this.cb_room.Items.AddRange(new object[] {
            "Room A",
            "Room B",
            "Room C",
            "Room D",
            "Room E",
            "Room F",
            "Room G",
            "Room H"});
            this.cb_room.Location = new System.Drawing.Point(491, 314);
            this.cb_room.Name = "cb_room";
            this.cb_room.Size = new System.Drawing.Size(223, 46);
            this.cb_room.TabIndex = 23;
            this.cb_room.Text = "Room A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(357, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "餐點";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(357, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "房號";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Linen;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_order.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_order.Location = new System.Drawing.Point(821, 385);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(212, 212);
            this.btn_order.TabIndex = 26;
            this.btn_order.Text = "送出";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Linen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(589, 465);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 70);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_list.Location = new System.Drawing.Point(31, 314);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(196, 252);
            this.lb_list.TabIndex = 28;
            this.lb_list.Text = "餐點：\r\n炸雞 $80 : 0\r\n漢堡 $65 : 0\r\n薯條 $40 : 0\r\n紅茶 $30 : 0\r\n可樂 $30 : 0";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_price.Location = new System.Drawing.Point(814, 314);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(125, 38);
            this.lb_price.TabIndex = 29;
            this.lb_price.Text = "價錢：0";
            // 
            // tb_num
            // 
            this.tb_num.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_num.Location = new System.Drawing.Point(429, 465);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 47);
            this.tb_num.TabIndex = 30;
            this.tb_num.Text = "1";
            this.tb_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // tb_ps
            // 
            this.tb_ps.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ps.Location = new System.Drawing.Point(409, 550);
            this.tb_ps.Name = "tb_ps";
            this.tb_ps.Size = new System.Drawing.Size(350, 47);
            this.tb_ps.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(313, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "備註";
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel1.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel1.Location = new System.Drawing.Point(251, 364);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel1.TabIndex = 33;
            this.btn_cancel1.Text = "X";
            this.btn_cancel1.UseVisualStyleBackColor = false;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancel1_Click);
            // 
            // btn_cancel2
            // 
            this.btn_cancel2.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel2.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel2.Location = new System.Drawing.Point(251, 406);
            this.btn_cancel2.Name = "btn_cancel2";
            this.btn_cancel2.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel2.TabIndex = 34;
            this.btn_cancel2.Text = "X";
            this.btn_cancel2.UseVisualStyleBackColor = false;
            this.btn_cancel2.Click += new System.EventHandler(this.btn_cancel2_Click);
            // 
            // btn_cancel3
            // 
            this.btn_cancel3.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel3.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel3.Location = new System.Drawing.Point(251, 448);
            this.btn_cancel3.Name = "btn_cancel3";
            this.btn_cancel3.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel3.TabIndex = 35;
            this.btn_cancel3.Text = "X";
            this.btn_cancel3.UseVisualStyleBackColor = false;
            this.btn_cancel3.Click += new System.EventHandler(this.btn_cancel3_Click);
            // 
            // btn_cancel4
            // 
            this.btn_cancel4.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel4.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel4.Location = new System.Drawing.Point(251, 490);
            this.btn_cancel4.Name = "btn_cancel4";
            this.btn_cancel4.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel4.TabIndex = 36;
            this.btn_cancel4.Text = "X";
            this.btn_cancel4.UseVisualStyleBackColor = false;
            this.btn_cancel4.Click += new System.EventHandler(this.btn_cancel4_Click);
            // 
            // btn_cancel5
            // 
            this.btn_cancel5.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel5.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel5.Location = new System.Drawing.Point(251, 532);
            this.btn_cancel5.Name = "btn_cancel5";
            this.btn_cancel5.Size = new System.Drawing.Size(48, 36);
            this.btn_cancel5.TabIndex = 37;
            this.btn_cancel5.Text = "X";
            this.btn_cancel5.UseVisualStyleBackColor = false;
            this.btn_cancel5.Click += new System.EventHandler(this.btn_cancel5_Click);
            // 
            // Form_Food
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 628);
            this.Controls.Add(this.btn_cancel5);
            this.Controls.Add(this.btn_cancel4);
            this.Controls.Add(this.btn_cancel3);
            this.Controls.Add(this.btn_cancel2);
            this.Controls.Add(this.btn_cancel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ps);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_room);
            this.Controls.Add(this.cb_food);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cb_food;
        private System.Windows.Forms.ComboBox cb_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_ps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel1;
        private System.Windows.Forms.Button btn_cancel2;
        private System.Windows.Forms.Button btn_cancel3;
        private System.Windows.Forms.Button btn_cancel4;
        private System.Windows.Forms.Button btn_cancel5;
    }
}