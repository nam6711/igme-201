using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace UIFromHell
{

    // Class: FormDesigner
    // Extends: Form
    // Author: Nat/Noah Manoucheri
    // Purpose: Holds a group box that can be used to hold and display 
    //          windows forms controls dependent on what the user chooses from the
    //          toolbox forms.
    //          A exit form button is visible, which can be used to close the actual form
    //          A exit button exists, which clears the user's custom formGroupBox
    // Restrictions: UI From Hell
    public partial class FormDesigner : Form
    {
        // holds all mouse data, and is continually updated by the
        //   Mouse Thread
        Thread mouseReader;
        public int mouseX;
        public int mouseY;
        // holds the current editing mode
        // each mode is as follows:
        //  "RADIO" - whenever the user clicks somewhere on the groupBox, it will place a radio button
        //  "LABEL" - whenever the user clicks somewhere on the groupBox, it will place a label
        //  "TEXT" - whenever the user clicks somewhere on the groupBox, it will place a Text Box
        //  "move" - when a form item is clicked, it will start to follow the mouse position
        //              when the mouse is clicked again, the item is placed
        //  "delete" - when a form control is clicked, it will be deleted from the formGroupBox
        public string editMode = "move";
        // holds all created form items
        public List<Control> controlList = new List<Control>();
        // holds all controls being moved currently
        public List<Control> moveList = new List<Control>();

        // Constructor: FormDesigner
        // Author: Nat/Noah Manoucheri
        // Purpose: Initializes the delegates for the form controls and starts the mouseListener thread
        // Parameters: None
        // Returns: None
        // Restrictions: None
        public FormDesigner()
        {
            InitializeComponent();

            // start mouse reading thread
            ThreadStart ts = new ThreadStart(this.ListenToMouse);
            mouseReader = new Thread(ts);
            mouseReader.Start();

            /******************** DELEGATES ********************/
            // set the toolbox delegate method
            this.toolButton.Click += new EventHandler(ToolButton__Click);

            // on click event for the group box, that uses the edit mode to change what happens
            this.formDesignerGroupBox.Click += new EventHandler(FormDesignerGroupBox__Click);
            // on click event for the form clear button
            this.clearFormButton.Click += new EventHandler(ClearFormButton__Click);

            // set close application button
            this.exitFormButton.Click += new EventHandler(ExitFormButton__Click);
            // set form close event
            FormClosing += new FormClosingEventHandler(Form__FormClosing);
        }

        // Method: ToolButton__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This opens a ToolBox Form that allows the user to set the editMode state
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Opens a new form that restricts user from leaving it
        private void ToolButton__Click(object sender, EventArgs e)
        {
            // create a toolbox instance with the current form as reference for value changing
            ToolBox toolBox = new ToolBox(this);
            // display the toolbox, and prevent it from losing focus
            toolBox.ShowDialog();
        }

        // Method: FormDesignerGroupBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This will be used to either create a new form control,
        //          or move controls into new places dependent on the editMode variable's state
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: None
        private void FormDesignerGroupBox__Click(object sender, EventArgs e)
        {
            // if the mode is currently set to "RADIO" "LABEL" or "TEXT", 
            //      call a constructor for the new items to place them somewhere
            // if the mode is "move", place all items within the move list
            switch (this.editMode)
            {
                case "RADIO":
                    // create a new radio at the current x, y position
                    this.CreateRadio(this.mouseX, this.mouseY);
                    break;
                case "LABEL":
                    // create a new label at the current x, y position
                    CreateLabel(this.mouseX, this.mouseY);
                    break;
                case "TEXT":
                    // create a new text box at the current x, y position
                    CreateTextBox(this.mouseX, this.mouseY);
                    break;
                case "move":
                    // iterate through all items in the move list, and place them down
                    foreach (Control control in moveList)
                    {
                        try
                        {
                            // remove from list
                            moveList.Remove(control);
                        }
                        catch
                        {
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        // Method: ClearFormButton__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This deletes all custom form items created
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: None
        private void ClearFormButton__Click(object sender, EventArgs e)
        {
            // iterate though all items within the form, and delete them
            foreach (Control control in controlList)
            {
                // remove item from the groupBoxForm
                this.formDesignerGroupBox.Controls.Remove(control);
            }
            // delete the contents of the control and move lists
            this.controlList.Clear();
            this.moveList.Clear();
        }

        // Method: CreateRadio
        // Author: Nat/Noah Manoucheri
        // Purpose: Will set the control to being moved or deleted when clicked on
        // Parameters: int x - mouseX position for new control
        //             int y - mouseY position for new control
        // Returns: None
        // Restrictions: None
        private void CreateRadio(int x, int y)
        {
            // create a radio button at the given x and y place
            RadioButton radio = new RadioButton();
            radio.Location = new Point(x, y);
            radio.Text = "NEW RADIO BUTTON THIS TAKES UP VERY LITTLE SPACE";
            radio.Size = new Size(300, 100);
            radio.BackColor = Color.FromArgb(0, 0, 0, 0);
            // set delegate methods for onclick that is specific to these items
            //      as these can be moved or deleted
            radio.Click += new EventHandler(CustomFormControl__Click);

            // add the radio to the groupBox list
            this.controlList.Add(radio);
            this.formDesignerGroupBox.Controls.Add(radio);
        }

        // Method: CreateLabel
        // Author: Nat/Noah Manoucheri
        // Purpose: Will set the control to being moved or deleted when clicked on
        // Parameters: int x - mouseX position for new control
        //             int y - mouseY position for new control
        // Returns: None
        // Restrictions: None
        private void CreateLabel(int x, int y)
        {
            // create a radio button at the given x and y place
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Text = "NEW LABEL THIS TAKES UP VERY LITTLE SPACE";
            label.Size = new Size(300, 100);
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            // set delegate methods for onclick that is specific to these items
            //      as these can be moved or deleted
            label.Click += new EventHandler(CustomFormControl__Click);

            // add the radio to the groupBox list
            this.controlList.Add(label);
            this.formDesignerGroupBox.Controls.Add(label);
        }

        // Method: CreateTextBox
        // Author: Nat/Noah Manoucheri
        // Purpose: Will set the control to being moved or deleted when clicked on
        // Parameters: int x - mouseX position for new control
        //             int y - mouseY position for new control
        // Returns: None
        // Restrictions: None
        private void CreateTextBox(int x, int y)
        {
            // create a radio button at the given x and y place
            TextBox tb = new TextBox();
            tb.Location = new Point(x, y);
            tb.Text = "NEW TEXTBOX THIS TAKES UP VERY LITTLE SPACE";
            tb.Size = new Size(300, 100);
            // set delegate methods for onclick that is specific to these items
            //      as these can be moved or deleted
            tb.Click += new EventHandler(CustomFormControl__Click);

            // add the radio to the groupBox list
            this.controlList.Add(tb);
            this.formDesignerGroupBox.Controls.Add(tb);
        }

        // Method: CustomFormControl__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: Will set the control to being moved or deleted when clicked on
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Generic click event for control items specific to the "custom form groupBox"
        private void CustomFormControl__Click(object sender, EventArgs e)
        {
            // set control item to usable variable
            Control control = (Control)sender;

            // if the current state is "move", set the item into the move list
            if (this.editMode == "move")
            {
                try
                {
                    this.moveList.Add(control);
                }
                catch
                {
                }
            }
            // else if state is equal to "delete", remove it from the control list
            //      as well as the move list potentially
            else if (this.editMode == "delete")
            {
                try
                {
                    // remove item from the groupBoxForm
                    this.formDesignerGroupBox.Controls.Remove(control);
                    
                    this.controlList.Remove(control);
                    this.moveList.Remove(control);
                }
                catch
                {
                }
            }
        }

        // Method: ExitFormButton__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: Closes all threads and ends the program
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: None
        private void ExitFormButton__Click(object sender, EventArgs e)
        {
            // close threads
            this.mouseReader.Abort();
            // close the application
            Application.Exit();
        }

        // Method: Form__FormClosing
        // Author: Nat/Noah Manoucheri
        // Purpose: Closes all threads when the program ends
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Occurs when form closes
        private void Form__FormClosing(object sender, FormClosingEventArgs e)
        {
            // dispose the thread
            mouseReader.Abort();
        }

        // Method: ListenToMouse
        // Author: Nat/Noah Manoucheri
        // Purpose: This sets a thread to always listen and set the mouse position
        //          This also sets the position of all items currently being moved to follow the mouse
        // Parameters: object sender - the item that was interacted with
        //             FormClosingEventArgs e - background info about the event
        // Returns: None
        // Restrictions: Always looping, so needs to be closed or the thread never stops
        public void ListenToMouse()
        {
            // use the relative cursor position to detect where the mouse is
            while (true)
            {
                // set all moving items to follow the mouse
                //  this purposely occurs before updating the mouse position so there's a delay
                foreach (Control control in moveList)
                {
                    // make item follow mouse
                    control.Location = new Point(this.mouseX, this.mouseY);
                }

                // set the new mouse x and y position (offset to make designer to feel more real)
                Point mousePos = this.PointToClient(Cursor.Position);
                this.mouseX = mousePos.X - 50;
                this.mouseY = mousePos.Y - 50;

            }
        }
    }
}
