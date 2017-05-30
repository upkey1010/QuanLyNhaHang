namespace BaitapRestaurent.GUI
{
    partial class DangnhapForm
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
            this.txt_login_Tendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.button_login_dangnhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Error_login_mess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_login_Tendangnhap
            // 
            this.txt_login_Tendangnhap.Location = new System.Drawing.Point(143, 37);
            this.txt_login_Tendangnhap.Name = "txt_login_Tendangnhap";
            this.txt_login_Tendangnhap.Size = new System.Drawing.Size(150, 20);
            this.txt_login_Tendangnhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu ";
            // 
            // txt_login_password
            // 
            this.txt_login_password.Location = new System.Drawing.Point(143, 63);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(150, 20);
            this.txt_login_password.TabIndex = 2;
            this.txt_login_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressEnterLoginCheck);
            // 
            // button_login_dangnhap
            // 
            this.button_login_dangnhap.Location = new System.Drawing.Point(124, 117);
            this.button_login_dangnhap.Name = "button_login_dangnhap";
            this.button_login_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.button_login_dangnhap.TabIndex = 4;
            this.button_login_dangnhap.Text = "Đăng nhập";
            this.button_login_dangnhap.UseVisualStyleBackColor = true;
            this.button_login_dangnhap.Click += new System.EventHandler(this.button_login_dangnhap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Đăng ký";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Error_login_mess
            // 
            this.Error_login_mess.AutoSize = true;
            this.Error_login_mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_login_mess.ForeColor = System.Drawing.Color.Red;
            this.Error_login_mess.Location = new System.Drawing.Point(110, 86);
            this.Error_login_mess.Name = "Error_login_mess";
            this.Error_login_mess.Size = new System.Drawing.Size(219, 13);
            this.Error_login_mess.TabIndex = 47;
            this.Error_login_mess.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
            // 
            // DangnhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 152);
            this.Controls.Add(this.Error_login_mess);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_login_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login_Tendangnhap);
            this.Name = "DangnhapForm";
            this.Text = "DangnhapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login_Tendangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Button button_login_dangnhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Error_login_mess;
    }
}