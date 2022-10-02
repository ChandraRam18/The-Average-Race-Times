namespace Average_Race_Times
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
            this.runner1Label = new System.Windows.Forms.Label();
            this.Runner2Label = new System.Windows.Forms.Label();
            this.runner3Label = new System.Windows.Forms.Label();
            this.descriptorAverageLabel = new System.Windows.Forms.Label();
            this.runner1Textbox = new System.Windows.Forms.TextBox();
            this.runner2Textbox = new System.Windows.Forms.TextBox();
            this.runner3Textbox = new System.Windows.Forms.TextBox();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // runner1Label
            // 
            this.runner1Label.AutoSize = true;
            this.runner1Label.Location = new System.Drawing.Point(54, 26);
            this.runner1Label.Name = "runner1Label";
            this.runner1Label.Size = new System.Drawing.Size(87, 25);
            this.runner1Label.TabIndex = 0;
            this.runner1Label.Text = "Runner 1:";
            // 
            // Runner2Label
            // 
            this.Runner2Label.AutoSize = true;
            this.Runner2Label.Location = new System.Drawing.Point(54, 84);
            this.Runner2Label.Name = "Runner2Label";
            this.Runner2Label.Size = new System.Drawing.Size(87, 25);
            this.Runner2Label.TabIndex = 1;
            this.Runner2Label.Text = "Runner 2:";
            // 
            // runner3Label
            // 
            this.runner3Label.AutoSize = true;
            this.runner3Label.Location = new System.Drawing.Point(54, 136);
            this.runner3Label.Name = "runner3Label";
            this.runner3Label.Size = new System.Drawing.Size(87, 25);
            this.runner3Label.TabIndex = 2;
            this.runner3Label.Text = "Runner 3:";
            // 
            // descriptorAverageLabel
            // 
            this.descriptorAverageLabel.AutoSize = true;
            this.descriptorAverageLabel.Location = new System.Drawing.Point(54, 208);
            this.descriptorAverageLabel.Name = "descriptorAverageLabel";
            this.descriptorAverageLabel.Size = new System.Drawing.Size(162, 25);
            this.descriptorAverageLabel.TabIndex = 3;
            this.descriptorAverageLabel.Text = "Average Race Time";
            // 
            // runner1Textbox
            // 
            this.runner1Textbox.Location = new System.Drawing.Point(165, 26);
            this.runner1Textbox.Name = "runner1Textbox";
            this.runner1Textbox.Size = new System.Drawing.Size(150, 31);
            this.runner1Textbox.TabIndex = 4;
            // 
            // runner2Textbox
            // 
            this.runner2Textbox.Location = new System.Drawing.Point(165, 81);
            this.runner2Textbox.Name = "runner2Textbox";
            this.runner2Textbox.Size = new System.Drawing.Size(150, 31);
            this.runner2Textbox.TabIndex = 5;
            // 
            // runner3Textbox
            // 
            this.runner3Textbox.Location = new System.Drawing.Point(165, 130);
            this.runner3Textbox.Name = "runner3Textbox";
            this.runner3Textbox.Size = new System.Drawing.Size(150, 31);
            this.runner3Textbox.TabIndex = 6;
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTimeLabel.Location = new System.Drawing.Point(315, 195);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(104, 38);
            this.averageTimeLabel.TabIndex = 7;
            this.averageTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 299);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(161, 34);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(230, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 34);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(403, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 34);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 254);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 360);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageTimeLabel);
            this.Controls.Add(this.runner3Textbox);
            this.Controls.Add(this.runner2Textbox);
            this.Controls.Add(this.runner1Textbox);
            this.Controls.Add(this.descriptorAverageLabel);
            this.Controls.Add(this.runner3Label);
            this.Controls.Add(this.Runner2Label);
            this.Controls.Add(this.runner1Label);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(590, 416);
            this.MinimumSize = new System.Drawing.Size(590, 416);
            this.Name = "Form1";
            this.Text = "Average Race Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label runner1Label;
        private Label Runner2Label;
        private Label runner3Label;
        private Label descriptorAverageLabel;
        private TextBox runner1Textbox;
        private TextBox runner2Textbox;
        private TextBox runner3Textbox;
        private Label averageTimeLabel;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Panel panel1;
    }
}