namespace WatchOS
{
    partial class Imgur
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
            this.imgurScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgurScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // imgurScreen
            // 
            this.imgurScreen.Location = new System.Drawing.Point(-4, -2);
            this.imgurScreen.Name = "imgurScreen";
            this.imgurScreen.Size = new System.Drawing.Size(378, 307);
            this.imgurScreen.TabIndex = 0;
            this.imgurScreen.TabStop = false;
            // 
            // Imgur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.imgurScreen);
            this.Location = new System.Drawing.Point(300, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Imgur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "L";
            this.Load += new System.EventHandler(this.Imgur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgurScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgurScreen;
    }
}