namespace asm_DangKi
{
    partial class frm_SuaMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThayDoiMatKhau = new System.Windows.Forms.Button();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.err_kiemTra = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_HienThiMK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.err_kiemTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thay đổi mật khẩu";
            // 
            // label3
            // 
            this.label3.Image = global::asm_DangKi.Properties.Resources.icons8_double_left_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 46);
            this.label3.TabIndex = 16;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_ThayDoiMatKhau
            // 
            this.btn_ThayDoiMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ThayDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThayDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThayDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btn_ThayDoiMatKhau.Location = new System.Drawing.Point(373, 298);
            this.btn_ThayDoiMatKhau.Name = "btn_ThayDoiMatKhau";
            this.btn_ThayDoiMatKhau.Size = new System.Drawing.Size(183, 40);
            this.btn_ThayDoiMatKhau.TabIndex = 15;
            this.btn_ThayDoiMatKhau.Text = "Xác nhận";
            this.btn_ThayDoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_ThayDoiMatKhau.Click += new System.EventHandler(this.btn_ThayDoiMatKhau_Click);
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txt_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(328, 129);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(293, 36);
            this.txt_MatKhauMoi.TabIndex = 14;
            this.txt_MatKhauMoi.UseSystemPasswordChar = true;
            this.txt_MatKhauMoi.TextChanged += new System.EventHandler(this.txt_MatKhauMoi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_XacNhanMatKhau
            // 
            this.txt_XacNhanMatKhau.BackColor = System.Drawing.Color.White;
            this.txt_XacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(328, 201);
            this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(293, 36);
            this.txt_XacNhanMatKhau.TabIndex = 21;
            this.txt_XacNhanMatKhau.UseSystemPasswordChar = true;
            this.txt_XacNhanMatKhau.TextChanged += new System.EventHandler(this.txt_XacNhanMatKhau_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Xác nhận mật khẩu";
            // 
            // err_kiemTra
            // 
            this.err_kiemTra.ContainerControl = this;
            // 
            // chk_HienThiMK
            // 
            this.chk_HienThiMK.AutoSize = true;
            this.chk_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMK.Location = new System.Drawing.Point(43, 308);
            this.chk_HienThiMK.Name = "chk_HienThiMK";
            this.chk_HienThiMK.Size = new System.Drawing.Size(204, 30);
            this.chk_HienThiMK.TabIndex = 22;
            this.chk_HienThiMK.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMK.UseVisualStyleBackColor = true;
            this.chk_HienThiMK.CheckedChanged += new System.EventHandler(this.chk_HienThiMK_CheckedChanged);
            // 
            // frm_SuaMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.chk_HienThiMK);
            this.Controls.Add(this.txt_XacNhanMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ThayDoiMatKhau);
            this.Controls.Add(this.txt_MatKhauMoi);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SuaMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.err_kiemTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThayDoiMatKhau;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_XacNhanMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider err_kiemTra;
        private System.Windows.Forms.CheckBox chk_HienThiMK;
    }
}