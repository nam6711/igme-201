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
    // Class: GuessingGame
    //      extends Form
    // Author: Nat Manoucheri
    // Purpose: Initizalizes the settings for the game
    //              where the user can set lower and higher boundaries.
    //          Also checks to make sure user gives valid input, then
    //              starts the game
    public partial class GuessingGame : Form
    {
        // Constructor: GuessingGame
        // Author: Nat Manoucheri
        // Purpose: Initialize event handlers
        public GuessingGame()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
            // Both use the same event handler
            this.lowEndTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox__KeyPress);
            this.highEndTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox__KeyPress);
        }

        // Method: NumberTextBox__KeyPress
        // Author: Nat Manoucheri
        // Purpose: Checks to make sure user only inputs a number
        // Parameters: object sender, item activating
        //             EventArgs e the arguments surrounding the event data
        private void NumberTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        // Method: StartButton__Click
        // Author: Nat Manoucheri
        // Purpose: Checks the user's inputs are valid, then starts the game if they are
        // Parameters: object sender, item activating
        //             EventArgs e the arguments surrounding the event data
        private void StartButton__Click(object sender, EventArgs e)
        {
            int lowNumber = 0;
            int hightNumber = 0;

            // if numbers aren't in valid range then prompt user for correct numbers
            if(!Int32.TryParse(this.lowEndTextBox.Text, out lowNumber) || !Int32.TryParse(this.highEndTextBox.Text, out hightNumber) || lowNumber >= hightNumber)
            {
                // ask user to re-input nums
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // create a new form using low and high nums
                GameForm gameForm = new GameForm(lowNumber, hightNumber);

                // display game form
                gameForm.ShowDialog();
            }
        }
    }
}
