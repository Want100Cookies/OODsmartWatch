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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblVote = new System.Windows.Forms.Label();
            this.lblFavourite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(800, 800);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // lblVote
            // 
            this.lblVote.AutoSize = true;
            this.lblVote.Location = new System.Drawing.Point(834, 57);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(0, 20);
            this.lblVote.TabIndex = 1;
            // 
            // lblFavourite
            // 
            this.lblFavourite.AutoSize = true;
            this.lblFavourite.Location = new System.Drawing.Point(834, 114);
            this.lblFavourite.Name = "lblFavourite";
            this.lblFavourite.Size = new System.Drawing.Size(0, 20);
            this.lblFavourite.TabIndex = 1;
            // 
            // Imgur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 834);
            this.Controls.Add(this.lblFavourite);
            this.Controls.Add(this.lblVote);
            this.Controls.Add(this.pictureBoxImage);
            this.Location = new System.Drawing.Point(300, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Imgur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "L";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label lblVote;
        private System.Windows.Forms.Label lblFavourite;
    }
}