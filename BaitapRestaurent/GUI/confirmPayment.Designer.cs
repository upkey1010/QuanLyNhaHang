namespace BaitapRestaurent.GUI
{
    partial class confirmPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.labeL_totalPrice = new System.Windows.Forms.Label();
            this.button_confirmation_OK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền là: ";
            // 
            // labeL_totalPrice
            // 
            this.labeL_totalPrice.AutoSize = true;
            this.labeL_totalPrice.Location = new System.Drawing.Point(254, 53);
            this.labeL_totalPrice.Name = "labeL_totalPrice";
            this.labeL_totalPrice.Size = new System.Drawing.Size(43, 13);
            this.labeL_totalPrice.TabIndex = 1;
            this.labeL_totalPrice.Text = "$$$$$$";
            // 
            // button_confirmation_OK
            // 
            this.button_confirmation_OK.Location = new System.Drawing.Point(117, 86);
            this.button_confirmation_OK.Name = "button_confirmation_OK";
            this.button_confirmation_OK.Size = new System.Drawing.Size(75, 23);
            this.button_confirmation_OK.TabIndex = 2;
            this.button_confirmation_OK.Text = "Thanh Toán";
            this.button_confirmation_OK.UseVisualStyleBackColor = true;
            this.button_confirmation_OK.Click += new System.EventHandler(this.button_confirmation_OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // confirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_confirmation_OK);
            this.Controls.Add(this.labeL_totalPrice);
            this.Controls.Add(this.label1);
            this.Name = "confirmPayment";
            this.Text = "confirmPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeL_totalPrice;
        private System.Windows.Forms.Button button_confirmation_OK;
        private System.Windows.Forms.Button button2;
    }
}