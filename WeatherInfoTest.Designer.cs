namespace WindowsFormsApp1
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
            this.WeatherBox = new System.Windows.Forms.TextBox();
            this.EnterBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EnterBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WeatherBox
            // 
            this.WeatherBox.Location = new System.Drawing.Point(35, 21);
            this.WeatherBox.Multiline = true;
            this.WeatherBox.Name = "WeatherBox";
            this.WeatherBox.Size = new System.Drawing.Size(727, 327);
            this.WeatherBox.TabIndex = 0;
            // 
            // EnterBox
            // 
            this.EnterBox.Location = new System.Drawing.Point(167, 371);
            this.EnterBox.Name = "EnterBox";
            this.EnterBox.Size = new System.Drawing.Size(194, 20);
            this.EnterBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterBox2
            // 
            this.EnterBox2.Location = new System.Drawing.Point(380, 371);
            this.EnterBox2.Name = "EnterBox2";
            this.EnterBox2.Size = new System.Drawing.Size(194, 20);
            this.EnterBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterBox);
            this.Controls.Add(this.WeatherBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeatherBox;
        private System.Windows.Forms.TextBox EnterBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EnterBox2;
    }
}

