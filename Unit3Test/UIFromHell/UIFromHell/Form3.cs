using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    // Class: ItemSelect
    // Extends: Form
    // Author: Nat/Noah Manoucheri
    // Purpose: Used to select a item to place on the parent form
    // Restrictions: Can only be closed after an item is selected
    public partial class ItemSelect : Form
    {
        // holds the parent form so that the edit mode can be altered 
        private FormDesigner parent;

        // Constructor: ItemSelect
        // Author: Nat/Noah Manoucheri
        // Purpose: Initializes the parent pointer, and all delegates for the form controls
        // Parameters: FormDesigner parent - holds the parent form so the editMode variable can be edited
        // Returns: None
        // Restrictions: None
        public ItemSelect(FormDesigner parent)
        {
            InitializeComponent();

            // set parent form so designing can be smoother
            this.parent = parent;

            /******************** DELEGATES ********************/
            // sets on click delegates for the group boxes
            //      when clicked, set the edit mode, then close the form
            this.radioButtonGroupBox.Click += new EventHandler(RadioButtonGroupBox__Click);
            this.labelGroupBox.Click += new EventHandler(LabelGroupBox__Click);
            this.textBoxGroupBox.Click += new EventHandler(TextBoxGroupBox__Click);
        }

        // Method: RadioButtonGroupBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This sets the edit mode to adding Radio Buttons
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Closes the form
        private void RadioButtonGroupBox__Click(object sender, EventArgs e)
        {
            // set edit mode to RADIO
            this.parent.editMode = "RADIO";
            // close form
            this.Close();
        }

        // Method: LabelGroupBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This sets the edit mode to adding Labels
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Closes the form
        private void LabelGroupBox__Click(object sender, EventArgs e)
        {
            // set edit mode to LABEL
            this.parent.editMode = "LABEL";
            // close form
            this.Close();
        }

        // Method: TextBoxGroupBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: This sets the edit mode to adding Text Boxes
        // Parameters: object sender - the item that was interacted with
        //             EventArgs e - background info about the event
        // Returns: None
        // Restrictions: Closes the form
        private void TextBoxGroupBox__Click(object sender, EventArgs e)
        {
            // set edit mode to TEXT
            this.parent.editMode = "TEXT";
            // close form
            this.Close();
        }
    }
}
