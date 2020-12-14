namespace pool_game_group2
{
    partial class MediumLevel2Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediumLevel2Mode));
            this.pictureBoxMedium = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMedium
            // 
            this.pictureBoxMedium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMedium.ErrorImage = null;
            this.pictureBoxMedium.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMedium.Image")));
            this.pictureBoxMedium.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMedium.Name = "pictureBoxMedium";
            this.pictureBoxMedium.Size = new System.Drawing.Size(1284, 641);
            this.pictureBoxMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMedium.TabIndex = 0;
            this.pictureBoxMedium.TabStop = false;
            this.pictureBoxMedium.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxMedium.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureboxPaint);
            this.pictureBoxMedium.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureboxMouseDown);
            this.pictureBoxMedium.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureboxMouseMove);
            this.pictureBoxMedium.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureboxMouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // MediumLevel2Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMedium);
            this.Name = "MediumLevel2Mode";
            this.Text = "Medium Mode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedium)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMedium;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}