namespace UIFromHell
{
    partial class ToolBox
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
            this.exitTextBox = new System.Windows.Forms.TextBox();
            this.itemSelectPictureBox = new System.Windows.Forms.PictureBox();
            this.movePictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitTextBox
            // 
            this.exitTextBox.Location = new System.Drawing.Point(324, 118);
            this.exitTextBox.Name = "exitTextBox";
            this.exitTextBox.Size = new System.Drawing.Size(100, 20);
            this.exitTextBox.TabIndex = 0;
            this.exitTextBox.Text = "Type Exit";
            // 
            // itemSelectPictureBox
            // 
            this.itemSelectPictureBox.ImageLocation = "https://cdn2.iconfinder.com/data/icons/iconika-productivity-kit-vol-3/512/Add_ite" +
    "m_positive-512.png";
            this.itemSelectPictureBox.Location = new System.Drawing.Point(24, 12);
            this.itemSelectPictureBox.Name = "itemSelectPictureBox";
            this.itemSelectPictureBox.Size = new System.Drawing.Size(100, 100);
            this.itemSelectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemSelectPictureBox.TabIndex = 1;
            this.itemSelectPictureBox.TabStop = false;
            // 
            // movePictureBox
            // 
            this.movePictureBox.ImageLocation = "http://cdn.onlinewebfonts.com/svg/img_514389.png";
            this.movePictureBox.Location = new System.Drawing.Point(164, 12);
            this.movePictureBox.Name = "movePictureBox";
            this.movePictureBox.Size = new System.Drawing.Size(100, 100);
            this.movePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movePictureBox.TabIndex = 2;
            this.movePictureBox.TabStop = false;
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.ImageLocation = "https://cdn-icons-png.flaticon.com/128/3221/3221803.png";
            this.deletePictureBox.Location = new System.Drawing.Point(296, 12);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(100, 100);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletePictureBox.TabIndex = 3;
            this.deletePictureBox.TabStop = false;
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 139);
            this.ControlBox = false;
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.movePictureBox);
            this.Controls.Add(this.itemSelectPictureBox);
            this.Controls.Add(this.exitTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ToolBox";
            this.Text = "Tool Box";
            ((System.ComponentModel.ISupportInitialize)(this.itemSelectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exitTextBox;
        private System.Windows.Forms.PictureBox itemSelectPictureBox;
        private System.Windows.Forms.PictureBox movePictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
    }
}