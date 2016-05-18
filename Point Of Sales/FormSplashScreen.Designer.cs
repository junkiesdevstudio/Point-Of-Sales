namespace Point_Of_Sales
{
    partial class FormSplashScreen
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
            this.picSplashScreen = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picSplashScreen
            // 
            this.picSplashScreen.BackColor = System.Drawing.Color.White;
            this.picSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplashScreen.InitialImage = null;
            this.picSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.picSplashScreen.Name = "picSplashScreen";
            this.picSplashScreen.Size = new System.Drawing.Size(518, 370);
            this.picSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSplashScreen.TabIndex = 2;
            this.picSplashScreen.TabStop = false;
            this.picSplashScreen.DoubleClick += new System.EventHandler(this.picSplashScreen_DoubleClick);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.picSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            this.Load += new System.EventHandler(this.FormSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplashScreen;
        private System.Windows.Forms.Timer Timer;
    }
}