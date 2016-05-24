namespace Point_Of_Sales
{
    partial class FormDiscount
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
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.BackColor = System.Drawing.Color.Black;
            this.txtMemberCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemberCode.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberCode.ForeColor = System.Drawing.Color.Lime;
            this.txtMemberCode.Location = new System.Drawing.Point(0, 0);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.ShortcutsEnabled = false;
            this.txtMemberCode.Size = new System.Drawing.Size(658, 104);
            this.txtMemberCode.TabIndex = 1;
            this.txtMemberCode.Text = "0";
            this.txtMemberCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemberCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberCode_KeyDown);
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 102);
            this.Controls.Add(this.txtMemberCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDiscount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiscount";
            this.Load += new System.EventHandler(this.FormDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemberCode;
    }
}