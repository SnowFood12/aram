namespace asm_DangKi
{
    partial class frm_TenDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDangNhapMoi = new System.Windows.Forms.TextBox();
            this.btn_SuaTenDangNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập mới";
            // 
            // txt_TenDangNhapMoi
            // 
            this.txt_TenDangNhapMoi.BackColor = System.Drawing.Color.White;
            this.txt_TenDangNhapMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhapMoi.Location = new System.Drawing.Point(265, 101);
            this.txt_TenDangNhapMoi.Name = "txt_TenDangNhapMoi";
            this.txt_TenDangNhapMoi.Size = new System.Drawing.Size(293, 36);
            this.txt_TenDangNhapMoi.TabIndex = 3;
            // 
            // btn_SuaTenDangNhap
            // 
            this.btn_SuaTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaTenDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SuaTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaTenDangNhap.Location = new System.Drawing.Point(275, 243);
            this.btn_SuaTenDangNhap.Name = "btn_SuaTenDangNhap";
            this.btn_SuaTenDangNhap.Size = new System.Drawing.Size(183, 40);
            this.btn_SuaTenDangNhap.TabIndex = 4;
            this.btn_SuaTenDangNhap.Text = "Lưu";
            this.btn_SuaTenDangNhap.UseVisualStyleBackColor = false;
            this.btn_SuaTenDangNhap.Click += new System.EventHandler(this.btn_SuaTenDangNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.Image = global::asm_DangKi.Properties.Resources.icons8_double_left_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 46);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.Color.White;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(265, 168);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(293, 36);
            this.txt_MatKhau.TabIndex = 12;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mật khẩu";
            // 
            // frm_TenDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(689, 342);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SuaTenDangNhap);
            this.Controls.Add(this.txt_TenDangNhapMoi);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TenDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenDangNhapMoi;
        private System.Windows.Forms.Button btn_SuaTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label5;
    }
}