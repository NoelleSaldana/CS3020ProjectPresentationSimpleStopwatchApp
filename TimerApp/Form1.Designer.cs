namespace TimerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            Start_Button = new Button();
            Stop_Button = new Button();
            Reset_Button = new Button();
            labelTime = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Start_Button
            // 
            Start_Button.Location = new Point(5, 9);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(75, 23);
            Start_Button.TabIndex = 0;
            Start_Button.Text = "Start";
            Start_Button.UseVisualStyleBackColor = true;
            Start_Button.Click += Start_Button_Click;
            // 
            // Stop_Button
            // 
            Stop_Button.Location = new Point(5, 49);
            Stop_Button.Name = "Stop_Button";
            Stop_Button.Size = new Size(75, 23);
            Stop_Button.TabIndex = 1;
            Stop_Button.Text = "Stop";
            Stop_Button.UseVisualStyleBackColor = true;
            Stop_Button.Click += Stop_Button_Click;
            // 
            // Reset_Button
            // 
            Reset_Button.Location = new Point(5, 92);
            Reset_Button.Name = "Reset_Button";
            Reset_Button.Size = new Size(75, 23);
            Reset_Button.TabIndex = 2;
            Reset_Button.Text = "Reset";
            Reset_Button.UseVisualStyleBackColor = true;
            Reset_Button.Click += Reset_Button_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 60F);
            labelTime.Location = new Point(86, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(337, 106);
            labelTime.TabIndex = 3;
            labelTime.Text = "00:00:00";
            labelTime.Click += labelTime_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 129);
            Controls.Add(labelTime);
            Controls.Add(Reset_Button);
            Controls.Add(Stop_Button);
            Controls.Add(Start_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button Start_Button;
        private Button Stop_Button;
        private Button Reset_Button;
        private Label labelTime;
    }
}
