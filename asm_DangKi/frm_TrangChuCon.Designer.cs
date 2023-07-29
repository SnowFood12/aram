namespace asm_DangKi
{
    partial class frm_TrangChuCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TrangChuCon));
            this.pic_Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Banner
            // 
            this.pic_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Banner.Image = ((System.Drawing.Image)(resources.GetObject("pic_Banner.Image")));
            this.pic_Banner.Location = new System.Drawing.Point(0, 0);
            this.pic_Banner.Name = "pic_Banner";
            this.pic_Banner.Size = new System.Drawing.Size(1396, 760);
            this.pic_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Banner.TabIndex = 0;
            this.pic_Banner.TabStop = false;
            // 
            // frm_TrangChuCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1396, 760);
            this.Controls.Add(this.pic_Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TrangChuCon";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Banner;
    }
}