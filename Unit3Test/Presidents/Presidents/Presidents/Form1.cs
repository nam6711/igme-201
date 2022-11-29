using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    
    public partial class Presidents : Form
    {
        // sorted list that holds the correct value for each text box to check against!
        //      string - the president's matching text box name
        //      int - the president's number
        // these are set up the way they are so that I only have to write one delegate event
        //      handler that every text box can use to check itself lol
        private SortedList<string, int> PresidentNumbers = new SortedList<string, int>();
        // sorted list that holds an array of items relating to each president
        //      string - the key, radio button's name, that is used to sift through the list
        //                    and piece out the right info
        //      sting[] - holds two items, the president's photo, and the url to their wiki page
        // this is all done to be generic so i only have to write one event handler for all radio buttons
        private SortedList<string, string[]> PresidentInfo = new SortedList<string, string[]>();
        // sorted list that holds all party info for each president
        //      string - the key is the name of the party/display mode
        //      RadioButton[] - arrays that hold the members of each individual party, and that president's radio button
        private SortedList<string, RadioButton[]> Parties = new SortedList<string, RadioButton[]>();

        public Presidents()
        {
            InitializeComponent();

            // deactivate the exit button
            this.exitButton.Enabled = false;
            // assign the on click event to the exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // set resizing for the PictureBox Control on mouse hover
            this.pictureBox1.MouseHover += new EventHandler(PictureBox__MouseHover);
            // set resizing for the PictureBox Control on mouse leave
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            // set timer tick event
            this.timer1.Tick += new EventHandler(Timer__Tick);
            // set progress bar max value to 2 minutes worth of time
            this.toolStripProgressBar1.Value = 240;


            /***************** PARTY SYSTEM RADIO BUTTON EVENTS *****************/
            this.allRadioButton.Click += new EventHandler(PartyRadioButton__Click);
            this.democratRadioButton.Click += new EventHandler(PartyRadioButton__Click);
            this.republicanRadioButton.Click += new EventHandler(PartyRadioButton__Click);
            this.democraticRepublicanRadioButton.Click += new EventHandler(PartyRadioButton__Click);
            this.federalistRadioButton.Click += new EventHandler(PartyRadioButton__Click);


            /***************** PRESIDENT DELEGATES AND INITIALIZARION *****************/
            // calls a method to initialize the party arrays and SortedList of president numbers
            //      and PresidentInfo list
            this.AssignPresidents();

            // assign event handlers to the radio buttons to change the image and webbrowser url on click
            this.benjaminHarrisonRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.franklinDRooseveltRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.williamJClintonRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.jamesBuchananRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.franklinPierceRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.georgeWBushRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.barackObamaRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.johnFKennedyRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.williamMcKinleyRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.ronaldRaeganRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.dwightDEisenhowerRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.martinVanBurenRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.georgeWashingtonRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.johnAdamsRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.theodoreRooseveltRadioButton.Click += new EventHandler(PresidentRadioButton__Click);
            this.thomasJeffersonRadioButton.Click += new EventHandler(PresidentRadioButton__Click);

            // assign the event handlers for each text box control's keyPress events
            //      as well as their change events
            this.benjaminHarrisonTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.benjaminHarrisonTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.franklinDRooseveltTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.franklinDRooseveltTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.williamJClintonTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.williamJClintonTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.jamesBuchananTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.jamesBuchananTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.franklinPierceTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.franklinPierceTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.georgeWBushTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.georgeWBushTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.barackObamaTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.barackObamaTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.johnFKennedyTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.johnFKennedyTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.williamMcKinleyTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.williamMcKinleyTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.ronaldRaeganTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.ronaldRaeganTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.dwightDEisenhowerTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.dwightDEisenhowerTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.martinVanBurenTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.martinVanBurenTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.georgeWashingtonTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.georgeWashingtonTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.johnAdamsTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.johnAdamsTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.theodoreRooseveltTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.theodoreRooseveltTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
            this.thomasJeffersonTextBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            this.thomasJeffersonTextBox.LostFocus += new EventHandler(PresidentTextBox__LostFocus);
        }

        // Method: Timer__Tick
        // Author: Nat/Noah manoucheri
        // Purpose: Every tick, the timer deducts the progress bar a small amount
        //          If the progress bar goes below 0, reset all text boxes.
        // Paramaters: object sender - the Timer that is ticking
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for Party RadioButtons only. Fires on click
        private void Timer__Tick(object sender, EventArgs e)
        {
            // decriment the ProgressBar's value
            --this.toolStripProgressBar1.Value;

            // once the progress bar hits 0
            if (this.toolStripProgressBar1.Value <= 0)
            {
                // stop the timer
                this.timer1.Stop();
                // reset the progress bar to its max value
                this.toolStripProgressBar1.Value = 240;
                // reset all textboxes to say 0
                this.benjaminHarrisonTextBox.Text = "0";
                this.franklinDRooseveltTextBox.Text = "0";
                this.williamJClintonTextBox.Text = "0";
                this.jamesBuchananTextBox.Text = "0";
                this.franklinPierceTextBox.Text = "0";
                this.georgeWBushTextBox.Text = "0";
                this.barackObamaTextBox.Text = "0";
                this.johnFKennedyTextBox.Text = "0";
                this.williamMcKinleyTextBox.Text = "0";
                this.ronaldRaeganTextBox.Text = "0";
                this.dwightDEisenhowerTextBox.Text = "0";
                this.martinVanBurenTextBox.Text = "0";
                this.georgeWashingtonTextBox.Text = "0";
                this.johnAdamsTextBox.Text = "0";
                this.theodoreRooseveltTextBox.Text = "0";
                this.thomasJeffersonTextBox.Text = "0";
            }
        }

        // Method: PartyRadioButton__Click
        // Author: Nat/Noah manoucheri
        // Purpose: Sets the associated RadioButtons to visible, and all others to hidden
        // Paramaters: object sender - the RadioButton that was interacted with
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for Party RadioButtons only. Fires on click
        private void PartyRadioButton__Click(object sender, EventArgs e)
        {
            // set RadioButton to local variable for easier use
            RadioButton rb = (RadioButton)sender;

            // IF PARTY RADIO BUTTON == ALL
            //      Set all RadioButtons to visible
            if (rb.Text == "All")
            {
                // go through everything in the Parties list and set to visible
                foreach (KeyValuePair<string, RadioButton[]> kvp in Parties)
                {
                    for (int i = 0; i <kvp.Value.Length; i++)
                    {
                        kvp.Value[i].Visible = true;
                    }
                }
            }
            else
            // OTHERWISE
            //      run through each seperate party array
            //          IF THE CURRENT ARRAY IS THE SAME AS THE RADIOBUTTON PARTY
            //              Then set items to visible
            //          ELSE
            //              Set the current array's items to hidden
            {
                // using a key value pair run through the Parties sorted list, but set hidden
                //      instead of visible for all items who's Key doesn't match the current Display Mode
                foreach (KeyValuePair<string, RadioButton[]> kvp in Parties)
                {
                    if (kvp.Key == rb.Text)
                    {
                        for (int i = 0; i < kvp.Value.Length; i++)
                        {
                            kvp.Value[i].Visible = true;
                        }
                    } 
                    else
                    {
                        for (int i = 0; i < kvp.Value.Length; i++)
                        {
                            kvp.Value[i].Visible = false;
                        }
                    }
                }
            }
        }

        // Method: PictureBox__MouseHover
        // Author: Nat/Noah manoucheri
        // Purpose: Doubles the image's size
        // Paramaters: object sender - the PictureBox that was interacted with
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for PictureBox. Only fires on MouseHover
        private void PictureBox__MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            // doubles the image's dimensions
            pb.MaximumSize = new Size(2 * 143, 2 * 215);
            pb.Size = new Size(2 * 143, 2 * 215);
        }

        // Method: PictureBox__MouseLeave
        // Author: Nat/Noah manoucheri
        // Purpose: Sets the image back to its original dimensions
        // Paramaters: object sender - the PictureBox that was interacted with
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for PictureBox. Only fires on mouseLeave
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            // sets the size back to normal
            pb.MaximumSize = new Size(143, 215);
            pb.Size = new Size(143, 215);
        }

        // Method: ExitButton__Click
        // Author: Nat/Noah manoucheri
        // Purpose: Closes the application
        // Paramaters: object sender - the button that was clicked
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for Exit Button. Should only be able to be called when the game has been won
        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method: PresidentTextBox__LostFocus
        // Author: Nat/Noah manoucheri
        // Purpose: Checks to see if the user input the right number for the president
        //              If they didn't, set an errorProvider
        //          Also check if all presidents were input correctly
        //              If they were, set the win condition and stop the timer
        // Paramaters: object sender - the text box that was changed
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for text box key presses that runs after the text is finished being changed
        private void PresidentTextBox__LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // if the input from the textbox doesn't match the stored president number
            //      throw an error provider
            // otherwise turn off the errorprovider
            //      and check if all other textboxes were correct and if so
            //      play fireworks and stop the timer
            if (tb.Text != PresidentNumbers[tb.Name].ToString())
            {
                // set error
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            } else
            {
                // remove error
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;

                // check if all text box's have correct answers
                if (CheckAnswers())
                {
                    // if they do, stop the timer
                    this.timer1.Stop();
                    
                    // set WebBrowserGroupBox Title to fireworks show url
                    this.webBrowserGroupBox.Text = "https://www.youtube.com/watch?v=18212B4yfLg";

                    // create a Uri for the WebBrowser to navigate to
                    Uri uri = new Uri("https://www.youtube.com/watch?v=18212B4yfLg");
                    // set WebBrowserUri to fireworks show
                    this.webBrowser1.ScriptErrorsSuppressed = true;
                    this.webBrowser1.Url = uri;

                    // activate exit button
                    this.exitButton.Enabled = true;
                }
            }
        }

        // Method: PresidentTextBox__KeyPress
        // Author: Nat/Noah manoucheri
        // Purpose: Checks to see if the input digit was a number
        //              if it wasn't, don't update the text box control
        //          Will also start the timer!!
        // Paramaters: object sender - the text box that was changed
        //             KeyPressEventArgs e - extra information about the event and the key specifically pressed
        // Returns: None
        // Restrictions: Delegate event handler for text box key presses that runs after every key stroke
        private void PresidentTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }

            // if timer isn't running
            if (!this.timer1.Enabled)
            {
                // start timer
                this.timer1.Start();
            }
        }

        // Method: PresidentRadioButton__Click
        // Author: Nat/Noah manoucheri
        // Purpose: Changes the image of a president displayed as well as the web browser url
        //          on radio button click
        // Paramaters: object sender - the radio button that was clicked
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Delegate event handler for radio button on click SPECIFIC to the president radio buttons
        private void PresidentRadioButton__Click(object sender, EventArgs e)
        {
            // assign sender to a readable radio button
            RadioButton president = (RadioButton)sender;

            // set the picture box to the image of this president
            //      using the first item stored inside the PresidentInfo List
            this.pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/" + PresidentInfo[president.Name][0];

            // set the WebBrowserGroupBox title and WebBrowser URL to the
            //      current president's specific one using the second item in the PresidentInfo list
            this.webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/" + PresidentInfo[president.Name][1];
            // set the webBrowserGroupBox into a Uri that can be used by the WebBrowser
            Uri uri = new Uri(this.webBrowserGroupBox.Text);
            this.webBrowser1.Url = uri;
        }

        // Method: AssignPresidents
        // Author: Nat/Noah manoucheri
        // Purpose: Assigns values to each individual party array and PresidentNumber SortedList
        //          and PresidentInfo list to declutter the Presidents constructor
        // Paramaters: None
        // Returns: None
        // Restrictions: Private. Do not call this outside of the constructor
        private void AssignPresidents()
        {
            // arrays to initialize the Parties SortedList with
            RadioButton[] democrats;
            RadioButton[] republicans;
            RadioButton[] democraticRepublicans;
            RadioButton[] federalists;

            // assigns the value of each of our arrays of presidents based on their party
            democrats = new RadioButton[] { this.franklinDRooseveltRadioButton, this.williamJClintonRadioButton, this.jamesBuchananRadioButton, this.franklinPierceRadioButton, this.barackObamaRadioButton, this.johnFKennedyRadioButton, this.martinVanBurenRadioButton };
            republicans = new RadioButton[] { this.benjaminHarrisonRadioButton, this.georgeWBushRadioButton, this.williamMcKinleyRadioButton, this.ronaldRaeganRadioButton, this.dwightDEisenhowerRadioButton, this.theodoreRooseveltRadioButton };
            democraticRepublicans = new RadioButton[] { this.thomasJeffersonRadioButton };
            federalists = new RadioButton[] { this.georgeWashingtonRadioButton, this.johnAdamsRadioButton };

            // Fill the parties SortedList
            this.Parties.Add("Democrat", democrats);
            this.Parties.Add("Republican", republicans);
            this.Parties.Add("Democratic-Republican", democraticRepublicans);
            this.Parties.Add("Federalist", federalists);


            // assigns the values to the PresidentNumbers sorted list!
            //      This will hold the president's term number
            this.PresidentNumbers.Add(this.benjaminHarrisonTextBox.Name, 23);
            this.PresidentNumbers.Add(this.franklinDRooseveltTextBox.Name, 32);
            this.PresidentNumbers.Add(this.williamJClintonTextBox.Name, 42);
            this.PresidentNumbers.Add(this.jamesBuchananTextBox.Name, 15);
            this.PresidentNumbers.Add(this.franklinPierceTextBox.Name, 14);
            this.PresidentNumbers.Add(this.georgeWBushTextBox.Name, 43);
            this.PresidentNumbers.Add(this.barackObamaTextBox.Name, 44);
            this.PresidentNumbers.Add(this.johnFKennedyTextBox.Name, 35);
            this.PresidentNumbers.Add(this.williamMcKinleyTextBox.Name, 25);
            this.PresidentNumbers.Add(this.ronaldRaeganTextBox.Name, 40);
            this.PresidentNumbers.Add(this.dwightDEisenhowerTextBox.Name, 34);
            this.PresidentNumbers.Add(this.martinVanBurenTextBox.Name, 8);
            this.PresidentNumbers.Add(this.georgeWashingtonTextBox.Name, 1);
            this.PresidentNumbers.Add(this.johnAdamsTextBox.Name, 2);
            this.PresidentNumbers.Add(this.theodoreRooseveltTextBox.Name, 26);
            this.PresidentNumbers.Add(this.thomasJeffersonTextBox.Name, 3);

            // assigns the values to the PresidentInfo sorted list!
            //      This will hold the president's photo and wiki url appendage respectively
            this.PresidentInfo.Add(this.benjaminHarrisonRadioButton.Name, new string[] { "BenjaminHarrison.jpeg", "Benjamin_Harrison" });
            this.PresidentInfo.Add(this.franklinDRooseveltRadioButton.Name, new string[] { "FranklinDRoosevelt.jpeg", "Franklin_D_Roosevelt" });
            this.PresidentInfo.Add(this.williamJClintonRadioButton.Name, new string[] { "WilliamJClinton.jpeg", "William_J_Clinton" });
            this.PresidentInfo.Add(this.jamesBuchananRadioButton.Name, new string[] { "JamesBuchanan.jpeg", "James_Buchanan" });
            this.PresidentInfo.Add(this.franklinPierceRadioButton.Name, new string[] { "FranklinPierce.jpeg", "Franklin_Pierce" });
            this.PresidentInfo.Add(this.georgeWBushRadioButton.Name, new string[] { "GeorgeWBush.jpeg", "George_W_Bush" });
            this.PresidentInfo.Add(this.barackObamaRadioButton.Name, new string[] { "BarackObama.png", "Barack_Obama" });
            this.PresidentInfo.Add(this.johnFKennedyRadioButton.Name, new string[] { "JohnFKennedy.jpeg", "John_F_Kennedy" });
            this.PresidentInfo.Add(this.williamMcKinleyRadioButton.Name, new string[] { "WilliamMcKinley.jpeg", "William_McKinley" });
            this.PresidentInfo.Add(this.ronaldRaeganRadioButton.Name, new string[] { "RonaldReagan.jpeg", "Ronald_Reagan" });
            this.PresidentInfo.Add(this.dwightDEisenhowerRadioButton.Name, new string[] { "DwightDEisenhower.jpeg", "Dwight_D_Eisenhower" });
            this.PresidentInfo.Add(this.martinVanBurenRadioButton.Name, new string[] { "MartinVanBuren.jpeg", "Martin_VanBuren" });
            this.PresidentInfo.Add(this.georgeWashingtonRadioButton.Name, new string[] { "GeorgeWashington.jpeg", "George_Washington" });
            this.PresidentInfo.Add(this.johnAdamsRadioButton.Name, new string[] { "JohnAdams.jpeg", "John_Adams" });
            this.PresidentInfo.Add(this.theodoreRooseveltRadioButton.Name, new string[] { "TheodoreRoosevelt.jpeg", "Theodore_Roosevelt" });
            this.PresidentInfo.Add(this.thomasJeffersonRadioButton.Name, new string[] { "ThomasJefferson.jpeg", "Thomas_Jefferson" });
        }

        // Method: CheckAnswers
        // Author: Nat/Noah manoucheri
        // Purpose: Check all text boxes and ensure whether or not they are correct
        //              If all are correct, return true. Otherwise return false
        // Paramaters: None
        // Returns: bool based on whether all text boxes were correct
        // Restrictions: Should only be called by the TextBox__TextChanged event
        private bool CheckAnswers()
        {
            // checks each text box's value against its corresponding PresidentNumber correct value
            if (
                this.benjaminHarrisonTextBox.Text == PresidentNumbers[this.benjaminHarrisonTextBox.Name].ToString() &&
                this.franklinDRooseveltTextBox.Text == PresidentNumbers[this.franklinDRooseveltTextBox.Name].ToString() &&
                this.williamJClintonTextBox.Text == PresidentNumbers[this.williamJClintonTextBox.Name].ToString() &&
                this.jamesBuchananTextBox.Text == PresidentNumbers[this.jamesBuchananTextBox.Name].ToString() &&
                this.franklinPierceTextBox.Text == PresidentNumbers[this.franklinPierceTextBox.Name].ToString() &&
                this.georgeWBushTextBox.Text == PresidentNumbers[this.georgeWBushTextBox.Name].ToString() &&
                this.barackObamaTextBox.Text == PresidentNumbers[this.barackObamaTextBox.Name].ToString() &&
                this.johnFKennedyTextBox.Text == PresidentNumbers[this.johnFKennedyTextBox.Name].ToString() &&
                this.williamMcKinleyTextBox.Text == PresidentNumbers[this.williamMcKinleyTextBox.Name].ToString() &&
                this.ronaldRaeganTextBox.Text == PresidentNumbers[this.ronaldRaeganTextBox.Name].ToString() &&
                this.dwightDEisenhowerTextBox.Text == PresidentNumbers[this.dwightDEisenhowerTextBox.Name].ToString() &&
                this.martinVanBurenTextBox.Text == PresidentNumbers[this.martinVanBurenTextBox.Name].ToString() &&
                this.georgeWashingtonTextBox.Text == PresidentNumbers[this.georgeWashingtonTextBox.Name].ToString() &&
                this.johnAdamsTextBox.Text == PresidentNumbers[this.johnAdamsTextBox.Name].ToString() &&
                this.theodoreRooseveltTextBox.Text == PresidentNumbers[this.theodoreRooseveltTextBox.Name].ToString() &&
                this.thomasJeffersonTextBox.Text == PresidentNumbers[this.thomasJeffersonTextBox.Name].ToString()
            )
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
