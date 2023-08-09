namespace asm_DangKi
{
    partial class frm_HoVaTen
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SuaHoVaTen = new System.Windows.Forms.Button();
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_HienThiMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.Image = global::asm_DangKi.Properties.Resources.icons8_double_left_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 46);
            this.label3.TabIndex = 13;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_SuaHoVaTen
            // 
            this.btn_SuaHoVaTen.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaHoVaTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SuaHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHoVaTen.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaHoVaTen.Location = new System.Drawing.Point(358, 351);
            this.btn_SuaHoVaTen.Name = "btn_SuaHoVaTen";
            this.btn_SuaHoVaTen.Size = new System.Drawing.Size(183, 40);
            this.btn_SuaHoVaTen.TabIndex = 12;
            this.btn_SuaHoVaTen.Text = "Lưu thay đổi";
            this.btn_SuaHoVaTen.UseVisualStyleBackColor = false;
            this.btn_SuaHoVaTen.Click += new System.EventHandler(this.btn_SuaHoVaTen_Click);
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.BackColor = System.Drawing.Color.White;
            this.txt_HoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoVaTen.Location = new System.Drawing.Point(310, 135);
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.Size = new System.Drawing.Size(293, 36);
            this.txt_HoVaTen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Họ và tên";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.Color.White;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(310, 218);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(293, 36);
            this.txt_MatKhau.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mật khẩu";
            // 
            // chk_HienThiMK
            // 
            this.chk_HienThiMK.AutoSize = true;
            this.chk_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMK.Location = new System.Drawing.Point(55, 361);
            this.chk_HienThiMK.Name = "chk_HienThiMK";
            this.chk_HienThiMK.Size = new System.Drawing.Size(204, 30);
            this.chk_HienThiMK.TabIndex = 27;
            this.chk_HienThiMK.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMK.UseVisualStyleBackColor = true;
            this.chk_HienThiMK.CheckedChanged += new System.EventHandler(this.chk_HienThiMK_CheckedChanged);
            // 
            // frm_HoVaTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.chk_HienThiMK);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SuaHoVaTen);
            this.Controls.Add(this.txt_HoVaTen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HoVaTen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HoVaTen";
            this.Load += new System.EventHandler(this.frm_HoVaTen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SuaHoVaTen;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_HienThiMK;
    }
}