namespace Digital_clock_project1
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
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton1 = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.styleButton = new System.Windows.Forms.Button();
            this.StyleButton3 = new System.Windows.Forms.Button();
            this.StyleButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Red;
            this.ClockLabel.Location = new System.Drawing.Point(12, 9);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(1140, 592);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "Loading.....";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClockLabel.Click += new System.EventHandler(this.ClockLabel_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // redButton1
            // 
            this.redButton1.BackColor = System.Drawing.Color.Red;
            this.redButton1.Location = new System.Drawing.Point(12, 615);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(31, 28);
            this.redButton1.TabIndex = 1;
            this.redButton1.UseMnemonic = false;
            this.redButton1.UseVisualStyleBackColor = false;
            this.redButton1.Click += new System.EventHandler(this.redButton1_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(159, 615);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(31, 28);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseMnemonic = false;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(122, 615);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(31, 28);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseMnemonic = false;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(85, 615);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(31, 28);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.UseMnemonic = false;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.Orange;
            this.OrangeButton.Location = new System.Drawing.Point(48, 615);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(31, 28);
            this.OrangeButton.TabIndex = 5;
            this.OrangeButton.UseMnemonic = false;
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // styleButton
            // 
            this.styleButton.BackColor = System.Drawing.Color.White;
            this.styleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styleButton.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton.ForeColor = System.Drawing.Color.Black;
            this.styleButton.Location = new System.Drawing.Point(221, 598);
            this.styleButton.Name = "styleButton";
            this.styleButton.Size = new System.Drawing.Size(84, 45);
            this.styleButton.TabIndex = 6;
            this.styleButton.Text = "style1";
            this.styleButton.UseVisualStyleBackColor = false;
            this.styleButton.Click += new System.EventHandler(this.styleButton_Click);
            // 
            // StyleButton3
            // 
            this.StyleButton3.BackColor = System.Drawing.Color.White;
            this.StyleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleButton3.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleButton3.ForeColor = System.Drawing.Color.Black;
            this.StyleButton3.Location = new System.Drawing.Point(429, 598);
            this.StyleButton3.Name = "StyleButton3";
            this.StyleButton3.Size = new System.Drawing.Size(81, 46);
            this.StyleButton3.TabIndex = 7;
            this.StyleButton3.Text = "style3";
            this.StyleButton3.UseVisualStyleBackColor = false;
            this.StyleButton3.Click += new System.EventHandler(this.StyleButton3_Click);
            // 
            // StyleButton2
            // 
            this.StyleButton2.BackColor = System.Drawing.Color.White;
            this.StyleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleButton2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton2.ForeColor = System.Drawing.Color.Black;
            this.StyleButton2.Location = new System.Drawing.Point(325, 598);
            this.StyleButton2.Name = "StyleButton2";
            this.StyleButton2.Size = new System.Drawing.Size(77, 45);
            this.StyleButton2.TabIndex = 8;
            this.StyleButton2.Text = "style1";
            this.StyleButton2.UseVisualStyleBackColor = false;
            this.StyleButton2.Click += new System.EventHandler(this.StyleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(578, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to the GK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1059, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-15, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 655);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StyleButton2);
            this.Controls.Add(this.StyleButton3);
            this.Controls.Add(this.styleButton);
            this.Controls.Add(this.OrangeButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton1);
            this.Controls.Add(this.ClockLabel);
            this.Name = "Form1";
            this.Text = "Digital clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button redButton1;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button styleButton;
        private System.Windows.Forms.Button StyleButton3;
        private System.Windows.Forms.Button StyleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

