﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);


            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);
            this.Text = "MyEditor";
        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                
                if (saveFileDialog.FileName.ToLower().Contains("*.txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }
        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;
            if (this.boldToolStripButton == e.ClickedItem)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (this.italicsToolStripButton == e.ClickedItem)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (this.underlineToolStripButton == e.ClickedItem)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (this.colorToolStripButton == e.ClickedItem)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                // Underline = 4, Bold = 1, Italic = 2
                // 111
                // 100
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }
    }
}
