namespace UIFromHell
{
    partial class ItemSelect
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
            this.radioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.labelGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonGroupBox.SuspendLayout();
            this.labelGroupBox.SuspendLayout();
            this.textBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonGroupBox
            // 
            this.radioButtonGroupBox.Controls.Add(this.radioButton1);
            this.radioButtonGroupBox.Location = new System.Drawing.Point(12, 12);
            this.radioButtonGroupBox.Name = "radioButtonGroupBox";
            this.radioButtonGroupBox.Size = new System.Drawing.Size(125, 125);
            this.radioButtonGroupBox.TabIndex = 0;
            this.radioButtonGroupBox.TabStop = false;
            this.radioButtonGroupBox.Text = "RADIO BUTTON";
            // 
            // labelGroupBox
            // 
            this.labelGroupBox.Controls.Add(this.label1);
            this.labelGroupBox.Location = new System.Drawing.Point(185, 12);
            this.labelGroupBox.Name = "labelGroupBox";
            this.labelGroupBox.Size = new System.Drawing.Size(125, 125);
            this.labelGroupBox.TabIndex = 1;
            this.labelGroupBox.TabStop = false;
            this.labelGroupBox.Text = "LABEL";
            // 
            // textBoxGroupBox
            // 
            this.textBoxGroupBox.Controls.Add(this.textBox1);
            this.textBoxGroupBox.Location = new System.Drawing.Point(356, 12);
            this.textBoxGroupBox.Name = "textBoxGroupBox";
            this.textBoxGroupBox.Size = new System.Drawing.Size(125, 125);
            this.textBoxGroupBox.TabIndex = 2;
            this.textBoxGroupBox.TabStop = false;
            this.textBoxGroupBox.Text = "TEXT BOX";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 5;
            // 
            // ItemSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 153);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxGroupBox);
            this.Controls.Add(this.labelGroupBox);
            this.Controls.Add(this.radioButtonGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemSelect";
            this.Text = "Select Form Element To Add";
            this.radioButtonGroupBox.ResumeLayout(false);
            this.radioButtonGroupBox.PerformLayout();
            this.labelGroupBox.ResumeLayout(false);
            this.labelGroupBox.PerformLayout();
            this.textBoxGroupBox.ResumeLayout(false);
            this.textBoxGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox radioButtonGroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox labelGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox textBoxGroupBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}