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
    // Class: ToolBox
    // Extends: Form
    // Author: Nat/Noah Manoucheri
    // Purpose: Used to select the editing mode on the parent form
    // Restrictions: Can only be closed after the word "exit" has been typed
    public partial class ToolBox : Form
    {
        // holds the parent form so that the edit mode can be altered 
        private FormDesigner parent;

        // Constructor: ToolBox
        // Author: Nat/Noah Manoucheri
        // Purpose: Initializes the parent pointer, and all delegates for the form controls
        // Parameters: FormDesigner parent - holds the parent form so the editMode variable can be edited
        // Returns: None
        // Restrictions: None
        public ToolBox(FormDesigner parent)
        {
            InitializeComponent();

            // sets the parent
            this.parent = parent;

            /******************** DELEGATES ********************/
            // checks for when the toolbox can be closed
            this.exitTextBox.TextChanged += new EventHandler(ExitTextBox__TextChanged);

            // changes backgrolund of tool when hovered over
            this.itemSelectPictureBox.MouseHover += new EventHandler(Tool__MouseHover);
            this.itemSelectPictureBox.MouseLeave += new EventHandler(Tool__MouseLeave);
            this.movePictureBox.MouseHover += new EventHandler(Tool__MouseHover);
            this.movePictureBox.MouseLeave += new EventHandler(Tool__MouseLeave);
            this.deletePictureBox.MouseHover += new EventHandler(Tool__MouseHover);
            this.deletePictureBox.MouseLeave += new EventHandler(Tool__MouseLeave);

            // sets the edit mode based upon the clicked item
            this.itemSelectPictureBox.Click += new EventHandler(ItemSelectPictureBox__Click);
            this.movePictureBox.Click += new EventHandler(MovePictureBox__Click);
            this.deletePictureBox.Click += new EventHandler(DeletePictureBox__Click);
        }

        // Constructor: ItemSelectPictureBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: Opens a new ItemSelect form to choose a Form Control to add to
        //          the parent form
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs on click. Specific to the itemSelectPhotoBox
        private void ItemSelectPictureBox__Click(object sender, EventArgs e)
        {
            // open a new ItemSelect Form instance
            ItemSelect itemSelect = new ItemSelect(this.parent);
            // open it so that only it can be edited and nothing else
            itemSelect.ShowDialog();
        }

        // Constructor: MovePictureBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: Sets the edit mode of the parent form to "move"
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs on click. Specific to the movePhotoBox
        private void MovePictureBox__Click(object sender, EventArgs e)
        {
            // set mode mode to move
            this.parent.editMode = "move";
        }

        // Constructor: DeletePictureBox__Click
        // Author: Nat/Noah Manoucheri
        // Purpose: Sets the edit mode of the parent form to "delete"
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs on click. Specific to the deletePhotoBox
        private void DeletePictureBox__Click(object sender, EventArgs e)
        {
            // set edit mode to delete
            this.parent.editMode = "delete";
        }

        // Constructor: Tool__MouseHover
        // Author: Nat/Noah Manoucheri
        // Purpose: Generic delegate that sets the backColor for all photoBoxes when the mouse enters them to gray
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs every time the mouse hovers over the image. Is generic and affects all photoBoxes
        private void Tool__MouseHover(object sender, EventArgs e)
        {
            // store picture box
            PictureBox pb = (PictureBox)sender;
            // set background to gray
            pb.BackColor = Color.Gray;
        }

        // Constructor: Tool__MouseLeave
        // Author: Nat/Noah Manoucheri
        // Purpose: Generic delegate that resets the backColor for all photoBoxes when the mouse leaves them
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs every time the mouse leaves the image. Is generic and affects all photoBoxes
        private void Tool__MouseLeave(object sender, EventArgs e)
        {
            // store picture box
            PictureBox pb = (PictureBox)sender;
            // set background to transparent
            pb.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        // Constructor: ExitTextBox__TextChanged
        // Author: Nat/Noah Manoucheri
        // Purpose: Checks every time the text box is edited to see if it reads out "exit"
        //              if it does, close the form
        // Parameters: object sender - information about the Form Control that had an event occur
        //             EventArgs e - extra information about the event
        // Returns: None
        // Restrictions: Occurs every time a key is pressed
        private void ExitTextBox__TextChanged(object sender, EventArgs e)
        {
            // when the user leaves, check if they typed "exit"
            // if they did, close the form, otherwise, clear the text
            if (this.exitTextBox.Text.ToLower().Trim() == "exit")
            {
                this.Close();
            }
        }
    }
}
