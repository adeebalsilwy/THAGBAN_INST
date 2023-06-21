namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG
{
    partial class home_page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labl_inst_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(324, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_time
            // 
            this.txt_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.Font = new System.Drawing.Font("Tahoma", 30F);
            this.txt_time.ForeColor = System.Drawing.Color.Black;
            this.txt_time.Location = new System.Drawing.Point(50, 371);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(555, 98);
            this.txt_time.TabIndex = 5;
            this.txt_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labl_inst_name
            // 
            this.labl_inst_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labl_inst_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_inst_name.ForeColor = System.Drawing.Color.DimGray;
            this.labl_inst_name.Location = new System.Drawing.Point(110, 252);
            this.labl_inst_name.Name = "labl_inst_name";
            this.labl_inst_name.Size = new System.Drawing.Size(752, 79);
            this.labl_inst_name.TabIndex = 8;
            this.labl_inst_name.Text = "EPS Pro";
            this.labl_inst_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labl_inst_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_time);
            this.Name = "home_page";
            this.Size = new System.Drawing.Size(974, 484);
            this.Load += new System.EventHandler(this.home_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labl_inst_name;
    }
}
