namespace GuessingGame
{
    partial class GuessingGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.lowEndTextBox = new System.Windows.Forms.TextBox();
            this.highEndTextBox = new System.Windows.Forms.TextBox();
            this.lowEndLabel = new System.Windows.Forms.Label();
            this.highEndLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(73, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // lowEndTextBox
            // 
            this.lowEndTextBox.Location = new System.Drawing.Point(85, 56);
            this.lowEndTextBox.Name = "lowEndTextBox";
            this.lowEndTextBox.Size = new System.Drawing.Size(95, 20);
            this.lowEndTextBox.TabIndex = 1;
            this.lowEndTextBox.Text = "1";
            // 
            // highEndTextBox
            // 
            this.highEndTextBox.Location = new System.Drawing.Point(85, 87);
            this.highEndTextBox.Name = "highEndTextBox";
            this.highEndTextBox.Size = new System.Drawing.Size(95, 20);
            this.highEndTextBox.TabIndex = 2;
            this.highEndTextBox.Text = "100";
            // 
            // lowEndLabel
            // 
            this.lowEndLabel.AutoSize = true;
            this.lowEndLabel.Location = new System.Drawing.Point(30, 59);
            this.lowEndLabel.Name = "lowEndLabel";
            this.lowEndLabel.Size = new System.Drawing.Size(52, 13);
            this.lowEndLabel.TabIndex = 3;
            this.lowEndLabel.Text = "Low End:";
            // 
            // highEndLabel
            // 
            this.highEndLabel.AutoSize = true;
            this.highEndLabel.Location = new System.Drawing.Point(28, 90);
            this.highEndLabel.Name = "highEndLabel";
            this.highEndLabel.Size = new System.Drawing.Size(54, 13);
            this.highEndLabel.TabIndex = 4;
            this.highEndLabel.Text = "High End:";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(30, 19);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(159, 13);
            this.instructionsLabel.TabIndex = 5;
            this.instructionsLabel.Text = "Enter Range of Values to Guess";
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 174);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.highEndLabel);
            this.Controls.Add(this.lowEndLabel);
            this.Controls.Add(this.highEndTextBox);
            this.Controls.Add(this.lowEndTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "GuessingGame";
            this.Text = "GuessingGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox lowEndTextBox;
        private System.Windows.Forms.TextBox highEndTextBox;
        private System.Windows.Forms.Label lowEndLabel;
        private System.Windows.Forms.Label highEndLabel;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

