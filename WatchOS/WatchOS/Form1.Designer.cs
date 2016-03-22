namespace WatchOS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1Timer = new System.Windows.Forms.Timer(this.components);
            this.button2Timer = new System.Windows.Forms.Timer(this.components);
            this.doubleClickTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(119, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 510);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 571);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "button 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1Down);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1Up);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "button 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button2Down);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button2Up);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 571);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "button 1 + 2 together";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1Timer
            // 
            this.button1Timer.Interval = 200;
            this.button1Timer.Tick += new System.EventHandler(this.button1Timer_Tick);
            // 
            // button2Timer
            // 
            this.button2Timer.Interval = 200;
            this.button2Timer.Tick += new System.EventHandler(this.button2Timer_Tick);
            // 
            // doubleClickTimer
            // 
            this.doubleClickTimer.Interval = 180;
            this.doubleClickTimer.Tick += new System.EventHandler(this.doubleClickTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 636);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer button1Timer;
        private System.Windows.Forms.Timer button2Timer;
        private System.Windows.Forms.Timer doubleClickTimer;
    }
}

