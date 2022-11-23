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
    // Class: GameForm
    //      extends Form
    // Author: Nat Manoucheri
    // Purpose: Runs the guessing game that tells a player
    //              how close their guess is with a 45 second timer
    //              and progress bar. Also counts how many guesses a player takes
    // Parameters: int low - lower boundary for guessing game
    //             int high - higher boundary for guessing game
    public partial class GameForm : Form
    {
        int correctNum; // holds the correct answer
        int numGuesses = 0; // holds how many guesses the user made

        // Constructor: GameForm
        // Author: Nat Manoucheri
        // Purpose: Initialize the correct number and event handlers
        // Parameters: int low - lower boundary for guessing game
        //             int high - higher boundary for guessing game
        public GameForm(int low, int high)
        {
            InitializeComponent();

            // generate a number between the low and high
            Random rand = new Random();
            this.correctNum = rand.Next(low, high);

            // set timer
            this.timer.Interval = 500;
            this.toolStripProgressBar.Value = 90;

            // set delegates
            this.timer.Tick += new EventHandler(Timer__Tick);
            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.guessTextBox.KeyPress += new KeyPressEventHandler(GuessTextBox__KeyPress);

            // initialize game
            this.timer.Start();
        }

        // Method: GuessButton__Click
        // Author: Nat Manoucheri
        // Purpose: On button click, let user know if their guess is correct and
        //              how close it is
        // Parameters: object sender, item activating
        //             EventArgs e the arguments surrounding the event data
        private void GuessButton__Click(object sender, EventArgs e)
        {
            int guess;

            // if numbers aren't in valid range then prompt user for correct numbers
            if (!Int32.TryParse(this.guessTextBox.Text, out guess))
            {
                // ask user to re-input nums
                this.outputLabel.Text = "INVALID GUESS";
            }
            else
            {
                // check if the guess is higher or lower than the actual number
                if (guess == this.correctNum)
                {
                    MessageBox.Show($"Way to go! You got the correct number in {this.numGuesses}!");
                    this.Close();
                }
                else if (guess > this.correctNum)
                {
                    this.outputLabel.Text = guess + " is too HIGH";
                }
                else if (guess < this.correctNum)
                {
                    this.outputLabel.Text = guess + " is too LOW";
                }
            }

            this.guessTextBox.Text = "";
            ++this.numGuesses;
        }

        // Method: GuessTextBox__KeyPress
        // Author: Nat Manoucheri
        // Purpose: Checks that the user only inputs numbers
        // Parameters: object sender, item activating
        //             EventArgs e the arguments surrounding the event data
        private void GuessTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        // Method: Timer__Tick
        // Author: Nat Manoucheri
        // Purpose: On tick, decrease progress bar
        //            if bar hits below 0, tell player they lost
        // Parameters: object sender, item activating
        //             EventArgs e the arguments surrounding the event data
        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;
            // once timer is over print they lost
            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();
                MessageBox.Show("The answer was " + correctNum + ", and you took too long :(");
                this.Close();
            }
        }
    }
}
