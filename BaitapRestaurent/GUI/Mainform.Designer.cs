namespace BaitapRestaurent.GUI
{
    partial class Mainform
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.main_add = new System.Windows.Forms.Button();
            this.main_del = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_main_QLNV = new System.Windows.Forms.Button();
            this.button_main_QLMA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(12, 12);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.Size = new System.Drawing.Size(452, 236);
            this.dgv_main.TabIndex = 0;
            // 
            // main_add
            // 
            this.main_add.Location = new System.Drawing.Point(24, 269);
            this.main_add.Name = "main_add";
            this.main_add.Size = new System.Drawing.Size(75, 23);
            this.main_add.TabIndex = 1;
            this.main_add.Text = "Thêm bàn";
            this.main_add.UseVisualStyleBackColor = true;
            this.main_add.Click += new System.EventHandler(this.main_add_Click);
            // 
            // main_del
            // 
            this.main_del.Location = new System.Drawing.Point(105, 269);
            this.main_del.Name = "main_del";
            this.main_del.Size = new System.Drawing.Size(75, 23);
            this.main_del.TabIndex = 2;
            this.main_del.Text = "Xóa bàn";
            this.main_del.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_main_QLNV
            // 
            this.button_main_QLNV.Location = new System.Drawing.Point(24, 298);
            this.button_main_QLNV.Name = "button_main_QLNV";
            this.button_main_QLNV.Size = new System.Drawing.Size(156, 23);
            this.button_main_QLNV.TabIndex = 4;
            this.button_main_QLNV.Text = "Quản lý nhân viên";
            this.button_main_QLNV.UseVisualStyleBackColor = true;
            this.button_main_QLNV.Click += new System.EventHandler(this.button_main_QLNV_Click);
            // 
            // button_main_QLMA
            // 
            this.button_main_QLMA.Location = new System.Drawing.Point(24, 327);
            this.button_main_QLMA.Name = "button_main_QLMA";
            this.button_main_QLMA.Size = new System.Drawing.Size(156, 23);
            this.button_main_QLMA.TabIndex = 5;
            this.button_main_QLMA.Text = "Quản lý Món Ăn";
            this.button_main_QLMA.UseVisualStyleBackColor = true;
            this.button_main_QLMA.Click += new System.EventHandler(this.button_main_QLMA_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 405);
            this.Controls.Add(this.button_main_QLMA);
            this.Controls.Add(this.button_main_QLNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.main_del);
            this.Controls.Add(this.main_add);
            this.Controls.Add(this.dgv_main);
            this.Name = "Mainform";
            this.Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button main_add;
        private System.Windows.Forms.Button main_del;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_main_QLNV;
        private System.Windows.Forms.Button button_main_QLMA;
    }
}