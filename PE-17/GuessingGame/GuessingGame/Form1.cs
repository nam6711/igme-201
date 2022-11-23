using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        public GuessingGame()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int hightNumber = 0;

            // if numbers aren't in valid range then prompt user for correct numbers
            if(!Int32.TryParse(this.lowEndTextBox.Text, out lowNumber) && !Int32.TryParse(this.highEndTextBox.Text, out hightNumber))
            {
                // ask user to re-input nums
                bConv = false;
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // set converted status to true
                bConv = true;

                // create a new form using low and high nums

                // display game form
            }
        }
    }
}
