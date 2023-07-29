namespace asm_DangKi
{
    partial class frm_MatKhau
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
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.chk_HienThiMK = new System.Windows.Forms.CheckBox();
            this.lab_QuenMK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(274, 72);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(295, 38);
            this.txt_matKhau.TabIndex = 0;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu";
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xacNhan.Location = new System.Drawing.Point(334, 198);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(156, 39);
            this.btn_xacNhan.TabIndex = 2;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = true;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // chk_HienThiMK
            // 
            this.chk_HienThiMK.AutoSize = true;
            this.chk_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMK.Location = new System.Drawing.Point(84, 207);
            this.chk_HienThiMK.Name = "chk_HienThiMK";
            this.chk_HienThiMK.Size = new System.Drawing.Size(204, 30);
            this.chk_HienThiMK.TabIndex = 14;
            this.chk_HienThiMK.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMK.UseVisualStyleBackColor = true;
            this.chk_HienThiMK.CheckedChanged += new System.EventHandler(this.chk_HienThiMK_CheckedChanged);
            // 
            // lab_QuenMK
            // 
            this.lab_QuenMK.AutoSize = true;
            this.lab_QuenMK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_QuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_QuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_QuenMK.ForeColor = System.Drawing.Color.Salmon;
            this.lab_QuenMK.Location = new System.Drawing.Point(269, 129);
            this.lab_QuenMK.Name = "lab_QuenMK";
            this.lab_QuenMK.Size = new System.Drawing.Size(173, 26);
            this.lab_QuenMK.TabIndex = 15;
            this.lab_QuenMK.Text = "Quên mật khẩu?";
            this.lab_QuenMK.Click += new System.EventHandler(this.lab_QuenMK_Click);
            // 
            // frm_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(699, 273);
            this.Controls.Add(this.lab_QuenMK);
            this.Controls.Add(this.chk_HienThiMK);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.CheckBox chk_HienThiMK;
        private System.Windows.Forms.Label lab_QuenMK;
    }
}