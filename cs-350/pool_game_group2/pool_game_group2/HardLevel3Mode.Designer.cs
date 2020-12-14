namespace pool_game_group2
{
    partial class HardLevel3Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardLevel3Mode));
            this.pictureBoxLevel3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCoordinates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLevel3
            // 
            this.pictureBoxLevel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLevel3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLevel3.Image")));
            this.pictureBoxLevel3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLevel3.Name = "pictureBoxLevel3";
            this.pictureBoxLevel3.Size = new System.Drawing.Size(1284, 641);
            this.pictureBoxLevel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLevel3.TabIndex = 0;
            this.pictureBoxLevel3.TabStop = false;
            this.pictureBoxLevel3.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBoxLevel3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBoxLevel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBoxLevel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBoxLevel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(12, 610);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(35, 13);
            this.labelCoordinates.TabIndex = 1;
            this.labelCoordinates.Text = "label1";
            this.labelCoordinates.Click += new System.EventHandler(this.labelCoordinates_Click);
            // 
            // HardLevel3Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.pictureBoxLevel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HardLevel3Mode";
            this.Text = "Pool Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLevel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCoordinates;
    }
}

