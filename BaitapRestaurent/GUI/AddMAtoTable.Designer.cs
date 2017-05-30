namespace BaitapRestaurent.GUI
{
    partial class AddMAtoTable
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
            this.dgv_monan = new System.Windows.Forms.DataGridView();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addMAtoBA_thanhtoan = new System.Windows.Forms.Button();
            this.totalprice_label = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label_tenban = new System.Windows.Forms.Label();
            this.label_madonhang = new System.Windows.Forms.Label();
            this.label_MA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_monan
            // 
            this.dgv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monan.Location = new System.Drawing.Point(12, 28);
            this.dgv_monan.Name = "dgv_monan";
            this.dgv_monan.Size = new System.Drawing.Size(381, 295);
            this.dgv_monan.TabIndex = 0;
            this.dgv_monan.SelectionChanged += new System.EventHandler(this.dgv_monan_SelectionChanged);
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(446, 28);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(400, 295);
            this.dgv_hoadon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_addMAtoBA_thanhtoan
            // 
            this.button_addMAtoBA_thanhtoan.Location = new System.Drawing.Point(492, 369);
            this.button_addMAtoBA_thanhtoan.Name = "button_addMAtoBA_thanhtoan";
            this.button_addMAtoBA_thanhtoan.Size = new System.Drawing.Size(147, 46);
            this.button_addMAtoBA_thanhtoan.TabIndex = 3;
            this.button_addMAtoBA_thanhtoan.Text = "Thanh Toán";
            this.button_addMAtoBA_thanhtoan.UseVisualStyleBackColor = true;
            this.button_addMAtoBA_thanhtoan.Click += new System.EventHandler(this.button_addMAtoBA_thanhtoan_Click);
            // 
            // totalprice_label
            // 
            this.totalprice_label.AutoSize = true;
            this.totalprice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice_label.Location = new System.Drawing.Point(642, 337);
            this.totalprice_label.Name = "totalprice_label";
            this.totalprice_label.Size = new System.Drawing.Size(59, 17);
            this.totalprice_label.TabIndex = 4;
            this.totalprice_label.Text = "Số tiền";
            this.totalprice_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(403, 150);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(33, 34);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtract.Location = new System.Drawing.Point(403, 190);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(33, 34);
            this.button_subtract.TabIndex = 6;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(403, 124);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(33, 20);
            this.txt_soluong.TabIndex = 7;
            // 
            // label_tenban
            // 
            this.label_tenban.AutoSize = true;
            this.label_tenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenban.Location = new System.Drawing.Point(12, 339);
            this.label_tenban.Name = "label_tenban";
            this.label_tenban.Size = new System.Drawing.Size(92, 25);
            this.label_tenban.TabIndex = 8;
            this.label_tenban.Text = "Ten ban";
            // 
            // label_madonhang
            // 
            this.label_madonhang.AutoSize = true;
            this.label_madonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_madonhang.Location = new System.Drawing.Point(12, 369);
            this.label_madonhang.Name = "label_madonhang";
            this.label_madonhang.Size = new System.Drawing.Size(141, 25);
            this.label_madonhang.TabIndex = 9;
            this.label_madonhang.Text = "Ma Don hang";
            // 
            // label_MA
            // 
            this.label_MA.AutoSize = true;
            this.label_MA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MA.Location = new System.Drawing.Point(12, 405);
            this.label_MA.Name = "label_MA";
            this.label_MA.Size = new System.Drawing.Size(174, 25);
            this.label_MA.TabIndex = 10;
            this.label_MA.Text = "Xin chon mon an";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMAtoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_MA);
            this.Controls.Add(this.label_madonhang);
            this.Controls.Add(this.label_tenban);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.totalprice_label);
            this.Controls.Add(this.button_addMAtoBA_thanhtoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.dgv_monan);
            this.Name = "AddMAtoTable";
            this.Text = "AddMAtoTable";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_monan;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addMAtoBA_thanhtoan;
        private System.Windows.Forms.Label totalprice_label;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label_tenban;
        private System.Windows.Forms.Label label_madonhang;
        private System.Windows.Forms.Label label_MA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}