namespace BaitapRestaurent.GUI
{
    partial class QuanlyNhanvien
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
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.button_NV_add = new System.Windows.Forms.Button();
            this.button_NV_update = new System.Windows.Forms.Button();
            this.button_NV_del = new System.Windows.Forms.Button();
            this.txt_NV_NVID = new System.Windows.Forms.TextBox();
            this.txt_NV_TenNV = new System.Windows.Forms.TextBox();
            this.txt_NV_TenDangnhap = new System.Windows.Forms.TextBox();
            this.txt_NV_Matkhau = new System.Windows.Forms.TextBox();
            this.rb_NV_female = new System.Windows.Forms.RadioButton();
            this.rb_NV_male = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NV = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_NV_search = new System.Windows.Forms.TextBox();
            this.button_NV_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_NV_rank = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nv
            // 
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Location = new System.Drawing.Point(12, 12);
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.Size = new System.Drawing.Size(579, 244);
            this.dgv_nv.TabIndex = 0;
            this.dgv_nv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_NV_add
            // 
            this.button_NV_add.Location = new System.Drawing.Point(42, 263);
            this.button_NV_add.Name = "button_NV_add";
            this.button_NV_add.Size = new System.Drawing.Size(75, 23);
            this.button_NV_add.TabIndex = 1;
            this.button_NV_add.Text = "Thêm NV";
            this.button_NV_add.UseVisualStyleBackColor = true;
            this.button_NV_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_NV_update
            // 
            this.button_NV_update.Location = new System.Drawing.Point(42, 294);
            this.button_NV_update.Name = "button_NV_update";
            this.button_NV_update.Size = new System.Drawing.Size(75, 23);
            this.button_NV_update.TabIndex = 2;
            this.button_NV_update.Text = "Cập nhật";
            this.button_NV_update.UseVisualStyleBackColor = true;
            this.button_NV_update.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_NV_del
            // 
            this.button_NV_del.Location = new System.Drawing.Point(42, 323);
            this.button_NV_del.Name = "button_NV_del";
            this.button_NV_del.Size = new System.Drawing.Size(75, 23);
            this.button_NV_del.TabIndex = 3;
            this.button_NV_del.Text = "Xóa";
            this.button_NV_del.UseVisualStyleBackColor = true;
            // 
            // txt_NV_NVID
            // 
            this.txt_NV_NVID.Location = new System.Drawing.Point(219, 265);
            this.txt_NV_NVID.Name = "txt_NV_NVID";
            this.txt_NV_NVID.ReadOnly = true;
            this.txt_NV_NVID.Size = new System.Drawing.Size(132, 20);
            this.txt_NV_NVID.TabIndex = 4;
            // 
            // txt_NV_TenNV
            // 
            this.txt_NV_TenNV.Location = new System.Drawing.Point(219, 294);
            this.txt_NV_TenNV.Name = "txt_NV_TenNV";
            this.txt_NV_TenNV.Size = new System.Drawing.Size(132, 20);
            this.txt_NV_TenNV.TabIndex = 5;
            // 
            // txt_NV_TenDangnhap
            // 
            this.txt_NV_TenDangnhap.Location = new System.Drawing.Point(459, 290);
            this.txt_NV_TenDangnhap.Name = "txt_NV_TenDangnhap";
            this.txt_NV_TenDangnhap.Size = new System.Drawing.Size(132, 20);
            this.txt_NV_TenDangnhap.TabIndex = 6;
            // 
            // txt_NV_Matkhau
            // 
            this.txt_NV_Matkhau.Location = new System.Drawing.Point(459, 320);
            this.txt_NV_Matkhau.Name = "txt_NV_Matkhau";
            this.txt_NV_Matkhau.Size = new System.Drawing.Size(132, 20);
            this.txt_NV_Matkhau.TabIndex = 7;
            // 
            // rb_NV_female
            // 
            this.rb_NV_female.AutoSize = true;
            this.rb_NV_female.Location = new System.Drawing.Point(538, 263);
            this.rb_NV_female.Name = "rb_NV_female";
            this.rb_NV_female.Size = new System.Drawing.Size(39, 17);
            this.rb_NV_female.TabIndex = 9;
            this.rb_NV_female.TabStop = true;
            this.rb_NV_female.Text = "Nữ";
            this.rb_NV_female.UseVisualStyleBackColor = true;
            // 
            // rb_NV_male
            // 
            this.rb_NV_male.AutoSize = true;
            this.rb_NV_male.Location = new System.Drawing.Point(475, 264);
            this.rb_NV_male.Name = "rb_NV_male";
            this.rb_NV_male.Size = new System.Drawing.Size(47, 17);
            this.rb_NV_male.TabIndex = 10;
            this.rb_NV_male.TabStop = true;
            this.rb_NV_male.Text = "Nam";
            this.rb_NV_male.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên đăng nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mật khẩu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(459, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker_NV
            // 
            this.dateTimePicker_NV.Location = new System.Drawing.Point(219, 326);
            this.dateTimePicker_NV.Name = "dateTimePicker_NV";
            this.dateTimePicker_NV.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker_NV.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_NV_search
            // 
            this.txt_NV_search.Location = new System.Drawing.Point(219, 359);
            this.txt_NV_search.Name = "txt_NV_search";
            this.txt_NV_search.Size = new System.Drawing.Size(132, 20);
            this.txt_NV_search.TabIndex = 19;
            // 
            // button_NV_back
            // 
            this.button_NV_back.Location = new System.Drawing.Point(42, 356);
            this.button_NV_back.Name = "button_NV_back";
            this.button_NV_back.Size = new System.Drawing.Size(75, 23);
            this.button_NV_back.TabIndex = 20;
            this.button_NV_back.Text = "Trở về";
            this.button_NV_back.UseVisualStyleBackColor = true;
            this.button_NV_back.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cấp bậc";
            // 
            // cbb_NV_rank
            // 
            this.cbb_NV_rank.FormattingEnabled = true;
            this.cbb_NV_rank.Location = new System.Drawing.Point(459, 365);
            this.cbb_NV_rank.Name = "cbb_NV_rank";
            this.cbb_NV_rank.Size = new System.Drawing.Size(132, 21);
            this.cbb_NV_rank.TabIndex = 24;
            // 
            // QuanlyNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 391);
            this.Controls.Add(this.cbb_NV_rank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_NV_back);
            this.Controls.Add(this.txt_NV_search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker_NV);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_NV_male);
            this.Controls.Add(this.rb_NV_female);
            this.Controls.Add(this.txt_NV_Matkhau);
            this.Controls.Add(this.txt_NV_TenDangnhap);
            this.Controls.Add(this.txt_NV_TenNV);
            this.Controls.Add(this.txt_NV_NVID);
            this.Controls.Add(this.button_NV_del);
            this.Controls.Add(this.button_NV_update);
            this.Controls.Add(this.button_NV_add);
            this.Controls.Add(this.dgv_nv);
            this.Name = "QuanlyNhanvien";
            this.Text = "QuanlyNhanvien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nv;
        private System.Windows.Forms.Button button_NV_add;
        private System.Windows.Forms.Button button_NV_update;
        private System.Windows.Forms.Button button_NV_del;
        private System.Windows.Forms.TextBox txt_NV_NVID;
        private System.Windows.Forms.TextBox txt_NV_TenNV;
        private System.Windows.Forms.TextBox txt_NV_TenDangnhap;
        private System.Windows.Forms.TextBox txt_NV_Matkhau;
        private System.Windows.Forms.RadioButton rb_NV_female;
        private System.Windows.Forms.RadioButton rb_NV_male;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_NV_search;
        private System.Windows.Forms.Button button_NV_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_NV_rank;
    }
}