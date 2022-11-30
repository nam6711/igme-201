namespace UIFromHell
{
    partial class FormDesigner
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
            this.formDesignerGroupBox = new System.Windows.Forms.GroupBox();
            this.toolButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formDesignerGroupBox
            // 
            this.formDesignerGroupBox.Location = new System.Drawing.Point(0, 30);
            this.formDesignerGroupBox.Name = "formDesignerGroupBox";
            this.formDesignerGroupBox.Size = new System.Drawing.Size(800, 392);
            this.formDesignerGroupBox.TabIndex = 0;
            this.formDesignerGroupBox.TabStop = false;
            this.formDesignerGroupBox.Text = "Form Designer";
            // 
            // toolButton
            // 
            this.toolButton.Location = new System.Drawing.Point(0, 1);
            this.toolButton.Name = "toolButton";
            this.toolButton.Size = new System.Drawing.Size(800, 23);
            this.toolButton.TabIndex = 0;
            this.toolButton.Text = "TOOLS";
            this.toolButton.UseVisualStyleBackColor = true;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(644, 428);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(75, 23);
            this.clearFormButton.TabIndex = 1;
            this.clearFormButton.Text = "Exit";
            this.clearFormButton.UseVisualStyleBackColor = true;
            // 
            // exitFormButton
            // 
            this.exitFormButton.Location = new System.Drawing.Point(725, 428);
            this.exitFormButton.Name = "exitFormButton";
            this.exitFormButton.Size = new System.Drawing.Size(75, 23);
            this.exitFormButton.TabIndex = 2;
            this.exitFormButton.Text = "Exit Form";
            this.exitFormButton.UseVisualStyleBackColor = true;
            // 
            // FormDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 457);
            this.Controls.Add(this.toolButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.exitFormButton);
            this.Controls.Add(this.formDesignerGroupBox);
            this.Name = "FormDesigner";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formDesignerGroupBox;
        private System.Windows.Forms.Button toolButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button exitFormButton;
    }
}

