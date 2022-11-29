namespace Presidents
{
    partial class Presidents
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.webBrowserGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.exitButton = new System.Windows.Forms.Button();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.federalistRadioButton = new System.Windows.Forms.RadioButton();
            this.democraticRepublicanRadioButton = new System.Windows.Forms.RadioButton();
            this.republicanRadioButton = new System.Windows.Forms.RadioButton();
            this.democratRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.benjaminHarrisonRadioButton = new System.Windows.Forms.RadioButton();
            this.franklinDRooseveltRadioButton = new System.Windows.Forms.RadioButton();
            this.williamJClintonRadioButton = new System.Windows.Forms.RadioButton();
            this.jamesBuchananRadioButton = new System.Windows.Forms.RadioButton();
            this.franklinPierceRadioButton = new System.Windows.Forms.RadioButton();
            this.georgeWBushRadioButton = new System.Windows.Forms.RadioButton();
            this.barackObamaRadioButton = new System.Windows.Forms.RadioButton();
            this.johnFKennedyRadioButton = new System.Windows.Forms.RadioButton();
            this.benjaminHarrisonTextBox = new System.Windows.Forms.TextBox();
            this.franklinDRooseveltTextBox = new System.Windows.Forms.TextBox();
            this.williamJClintonTextBox = new System.Windows.Forms.TextBox();
            this.jamesBuchananTextBox = new System.Windows.Forms.TextBox();
            this.franklinPierceTextBox = new System.Windows.Forms.TextBox();
            this.georgeWBushTextBox = new System.Windows.Forms.TextBox();
            this.barackObamaTextBox = new System.Windows.Forms.TextBox();
            this.johnFKennedyTextBox = new System.Windows.Forms.TextBox();
            this.williamMcKinleyTextBox = new System.Windows.Forms.TextBox();
            this.ronaldRaeganTextBox = new System.Windows.Forms.TextBox();
            this.dwightDEisenhowerTextBox = new System.Windows.Forms.TextBox();
            this.martinVanBurenTextBox = new System.Windows.Forms.TextBox();
            this.georgeWashingtonTextBox = new System.Windows.Forms.TextBox();
            this.johnAdamsTextBox = new System.Windows.Forms.TextBox();
            this.theodoreRooseveltTextBox = new System.Windows.Forms.TextBox();
            this.thomasJeffersonTextBox = new System.Windows.Forms.TextBox();
            this.williamMcKinleyRadioButton = new System.Windows.Forms.RadioButton();
            this.ronaldRaeganRadioButton = new System.Windows.Forms.RadioButton();
            this.dwightDEisenhowerRadioButton = new System.Windows.Forms.RadioButton();
            this.martinVanBurenRadioButton = new System.Windows.Forms.RadioButton();
            this.georgeWashingtonRadioButton = new System.Windows.Forms.RadioButton();
            this.johnAdamsRadioButton = new System.Windows.Forms.RadioButton();
            this.theodoreRooseveltRadioButton = new System.Windows.Forms.RadioButton();
            this.thomasJeffersonRadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.webBrowserGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(985, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 240;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(780, 16);
            this.toolStripProgressBar1.Value = 240;
            // 
            // webBrowserGroupBox
            // 
            this.webBrowserGroupBox.Controls.Add(this.webBrowser1);
            this.webBrowserGroupBox.Location = new System.Drawing.Point(335, 12);
            this.webBrowserGroupBox.Name = "webBrowserGroupBox";
            this.webBrowserGroupBox.Size = new System.Drawing.Size(650, 547);
            this.webBrowserGroupBox.TabIndex = 1;
            this.webBrowserGroupBox.TabStop = false;
            this.webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(644, 528);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison", System.UriKind.Absolute);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(898, 579);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.federalistRadioButton);
            this.filterGroupBox.Controls.Add(this.democraticRepublicanRadioButton);
            this.filterGroupBox.Controls.Add(this.republicanRadioButton);
            this.filterGroupBox.Controls.Add(this.democratRadioButton);
            this.filterGroupBox.Controls.Add(this.allRadioButton);
            this.filterGroupBox.Location = new System.Drawing.Point(171, 212);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(158, 149);
            this.filterGroupBox.TabIndex = 3;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter";
            // 
            // federalistRadioButton
            // 
            this.federalistRadioButton.AutoSize = true;
            this.federalistRadioButton.Location = new System.Drawing.Point(7, 116);
            this.federalistRadioButton.Name = "federalistRadioButton";
            this.federalistRadioButton.Size = new System.Drawing.Size(70, 17);
            this.federalistRadioButton.TabIndex = 4;
            this.federalistRadioButton.Text = "Federalist";
            this.federalistRadioButton.UseVisualStyleBackColor = true;
            // 
            // democraticRepublicanRadioButton
            // 
            this.democraticRepublicanRadioButton.AutoSize = true;
            this.democraticRepublicanRadioButton.Location = new System.Drawing.Point(7, 92);
            this.democraticRepublicanRadioButton.Name = "democraticRepublicanRadioButton";
            this.democraticRepublicanRadioButton.Size = new System.Drawing.Size(136, 17);
            this.democraticRepublicanRadioButton.TabIndex = 3;
            this.democraticRepublicanRadioButton.Text = "Democratic-Republican";
            this.democraticRepublicanRadioButton.UseVisualStyleBackColor = true;
            // 
            // republicanRadioButton
            // 
            this.republicanRadioButton.AutoSize = true;
            this.republicanRadioButton.Location = new System.Drawing.Point(7, 68);
            this.republicanRadioButton.Name = "republicanRadioButton";
            this.republicanRadioButton.Size = new System.Drawing.Size(79, 17);
            this.republicanRadioButton.TabIndex = 2;
            this.republicanRadioButton.Text = "Republican";
            this.republicanRadioButton.UseVisualStyleBackColor = true;
            // 
            // democratRadioButton
            // 
            this.democratRadioButton.AutoSize = true;
            this.democratRadioButton.Location = new System.Drawing.Point(7, 44);
            this.democratRadioButton.Name = "democratRadioButton";
            this.democratRadioButton.Size = new System.Drawing.Size(71, 17);
            this.democratRadioButton.TabIndex = 1;
            this.democratRadioButton.Text = "Democrat";
            this.democratRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(7, 20);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
            this.pictureBox1.Location = new System.Drawing.Point(12, 212);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(143, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // benjaminHarrisonRadioButton
            // 
            this.benjaminHarrisonRadioButton.AutoSize = true;
            this.benjaminHarrisonRadioButton.Checked = true;
            this.benjaminHarrisonRadioButton.Location = new System.Drawing.Point(12, 13);
            this.benjaminHarrisonRadioButton.Name = "benjaminHarrisonRadioButton";
            this.benjaminHarrisonRadioButton.Size = new System.Drawing.Size(110, 17);
            this.benjaminHarrisonRadioButton.TabIndex = 6;
            this.benjaminHarrisonRadioButton.TabStop = true;
            this.benjaminHarrisonRadioButton.Text = "Benjamin Harrison";
            this.benjaminHarrisonRadioButton.UseVisualStyleBackColor = true;
            // 
            // franklinDRooseveltRadioButton
            // 
            this.franklinDRooseveltRadioButton.AutoSize = true;
            this.franklinDRooseveltRadioButton.Location = new System.Drawing.Point(12, 37);
            this.franklinDRooseveltRadioButton.Name = "franklinDRooseveltRadioButton";
            this.franklinDRooseveltRadioButton.Size = new System.Drawing.Size(124, 17);
            this.franklinDRooseveltRadioButton.TabIndex = 7;
            this.franklinDRooseveltRadioButton.Text = "Franklin D Roosevelt";
            this.franklinDRooseveltRadioButton.UseVisualStyleBackColor = true;
            // 
            // williamJClintonRadioButton
            // 
            this.williamJClintonRadioButton.AutoSize = true;
            this.williamJClintonRadioButton.Location = new System.Drawing.Point(12, 61);
            this.williamJClintonRadioButton.Name = "williamJClintonRadioButton";
            this.williamJClintonRadioButton.Size = new System.Drawing.Size(101, 17);
            this.williamJClintonRadioButton.TabIndex = 8;
            this.williamJClintonRadioButton.Text = "William J Clinton";
            this.williamJClintonRadioButton.UseVisualStyleBackColor = true;
            // 
            // jamesBuchananRadioButton
            // 
            this.jamesBuchananRadioButton.AutoSize = true;
            this.jamesBuchananRadioButton.Location = new System.Drawing.Point(12, 85);
            this.jamesBuchananRadioButton.Name = "jamesBuchananRadioButton";
            this.jamesBuchananRadioButton.Size = new System.Drawing.Size(107, 17);
            this.jamesBuchananRadioButton.TabIndex = 9;
            this.jamesBuchananRadioButton.Text = "James Buchanan";
            this.jamesBuchananRadioButton.UseVisualStyleBackColor = true;
            // 
            // franklinPierceRadioButton
            // 
            this.franklinPierceRadioButton.AutoSize = true;
            this.franklinPierceRadioButton.Location = new System.Drawing.Point(12, 109);
            this.franklinPierceRadioButton.Name = "franklinPierceRadioButton";
            this.franklinPierceRadioButton.Size = new System.Drawing.Size(95, 17);
            this.franklinPierceRadioButton.TabIndex = 10;
            this.franklinPierceRadioButton.Text = "Franklin Pierce";
            this.franklinPierceRadioButton.UseVisualStyleBackColor = true;
            // 
            // georgeWBushRadioButton
            // 
            this.georgeWBushRadioButton.AutoSize = true;
            this.georgeWBushRadioButton.Location = new System.Drawing.Point(12, 133);
            this.georgeWBushRadioButton.Name = "georgeWBushRadioButton";
            this.georgeWBushRadioButton.Size = new System.Drawing.Size(101, 17);
            this.georgeWBushRadioButton.TabIndex = 11;
            this.georgeWBushRadioButton.Text = "George W Bush";
            this.georgeWBushRadioButton.UseVisualStyleBackColor = true;
            // 
            // barackObamaRadioButton
            // 
            this.barackObamaRadioButton.AutoSize = true;
            this.barackObamaRadioButton.Location = new System.Drawing.Point(12, 157);
            this.barackObamaRadioButton.Name = "barackObamaRadioButton";
            this.barackObamaRadioButton.Size = new System.Drawing.Size(96, 17);
            this.barackObamaRadioButton.TabIndex = 12;
            this.barackObamaRadioButton.Text = "Barack Obama";
            this.barackObamaRadioButton.UseVisualStyleBackColor = true;
            // 
            // johnFKennedyRadioButton
            // 
            this.johnFKennedyRadioButton.AutoSize = true;
            this.johnFKennedyRadioButton.Location = new System.Drawing.Point(12, 181);
            this.johnFKennedyRadioButton.Name = "johnFKennedyRadioButton";
            this.johnFKennedyRadioButton.Size = new System.Drawing.Size(102, 17);
            this.johnFKennedyRadioButton.TabIndex = 13;
            this.johnFKennedyRadioButton.Text = "John F Kennedy";
            this.johnFKennedyRadioButton.UseVisualStyleBackColor = true;
            // 
            // benjaminHarrisonTextBox
            // 
            this.benjaminHarrisonTextBox.Location = new System.Drawing.Point(137, 13);
            this.benjaminHarrisonTextBox.Name = "benjaminHarrisonTextBox";
            this.benjaminHarrisonTextBox.Size = new System.Drawing.Size(28, 20);
            this.benjaminHarrisonTextBox.TabIndex = 14;
            this.benjaminHarrisonTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.benjaminHarrisonTextBox, "Which # President\r\n");
            // 
            // franklinDRooseveltTextBox
            // 
            this.franklinDRooseveltTextBox.Location = new System.Drawing.Point(137, 37);
            this.franklinDRooseveltTextBox.Name = "franklinDRooseveltTextBox";
            this.franklinDRooseveltTextBox.Size = new System.Drawing.Size(28, 20);
            this.franklinDRooseveltTextBox.TabIndex = 15;
            this.franklinDRooseveltTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.franklinDRooseveltTextBox, "Which # President\r\n");
            // 
            // williamJClintonTextBox
            // 
            this.williamJClintonTextBox.Location = new System.Drawing.Point(137, 61);
            this.williamJClintonTextBox.Name = "williamJClintonTextBox";
            this.williamJClintonTextBox.Size = new System.Drawing.Size(28, 20);
            this.williamJClintonTextBox.TabIndex = 16;
            this.williamJClintonTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.williamJClintonTextBox, "Which # President\r\n");
            // 
            // jamesBuchananTextBox
            // 
            this.jamesBuchananTextBox.Location = new System.Drawing.Point(137, 84);
            this.jamesBuchananTextBox.Name = "jamesBuchananTextBox";
            this.jamesBuchananTextBox.Size = new System.Drawing.Size(28, 20);
            this.jamesBuchananTextBox.TabIndex = 17;
            this.jamesBuchananTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.jamesBuchananTextBox, "Which # President\r\n");
            // 
            // franklinPierceTextBox
            // 
            this.franklinPierceTextBox.Location = new System.Drawing.Point(137, 108);
            this.franklinPierceTextBox.Name = "franklinPierceTextBox";
            this.franklinPierceTextBox.Size = new System.Drawing.Size(28, 20);
            this.franklinPierceTextBox.TabIndex = 18;
            this.franklinPierceTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.franklinPierceTextBox, "Which # President\r\n");
            // 
            // georgeWBushTextBox
            // 
            this.georgeWBushTextBox.Location = new System.Drawing.Point(137, 132);
            this.georgeWBushTextBox.Name = "georgeWBushTextBox";
            this.georgeWBushTextBox.Size = new System.Drawing.Size(28, 20);
            this.georgeWBushTextBox.TabIndex = 19;
            this.georgeWBushTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.georgeWBushTextBox, "Which # President\r\n");
            // 
            // barackObamaTextBox
            // 
            this.barackObamaTextBox.Location = new System.Drawing.Point(137, 156);
            this.barackObamaTextBox.Name = "barackObamaTextBox";
            this.barackObamaTextBox.Size = new System.Drawing.Size(28, 20);
            this.barackObamaTextBox.TabIndex = 20;
            this.barackObamaTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.barackObamaTextBox, "Which # President\r\n");
            // 
            // johnFKennedyTextBox
            // 
            this.johnFKennedyTextBox.Location = new System.Drawing.Point(137, 180);
            this.johnFKennedyTextBox.Name = "johnFKennedyTextBox";
            this.johnFKennedyTextBox.Size = new System.Drawing.Size(28, 20);
            this.johnFKennedyTextBox.TabIndex = 21;
            this.johnFKennedyTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.johnFKennedyTextBox, "Which # President\r\n");
            // 
            // williamMcKinleyTextBox
            // 
            this.williamMcKinleyTextBox.Location = new System.Drawing.Point(300, 13);
            this.williamMcKinleyTextBox.Name = "williamMcKinleyTextBox";
            this.williamMcKinleyTextBox.Size = new System.Drawing.Size(28, 20);
            this.williamMcKinleyTextBox.TabIndex = 22;
            this.williamMcKinleyTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.williamMcKinleyTextBox, "Which # President\r\n");
            // 
            // ronaldRaeganTextBox
            // 
            this.ronaldRaeganTextBox.Location = new System.Drawing.Point(300, 37);
            this.ronaldRaeganTextBox.Name = "ronaldRaeganTextBox";
            this.ronaldRaeganTextBox.Size = new System.Drawing.Size(28, 20);
            this.ronaldRaeganTextBox.TabIndex = 23;
            this.ronaldRaeganTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.ronaldRaeganTextBox, "Which # President\r\n");
            // 
            // dwightDEisenhowerTextBox
            // 
            this.dwightDEisenhowerTextBox.Location = new System.Drawing.Point(300, 61);
            this.dwightDEisenhowerTextBox.Name = "dwightDEisenhowerTextBox";
            this.dwightDEisenhowerTextBox.Size = new System.Drawing.Size(28, 20);
            this.dwightDEisenhowerTextBox.TabIndex = 24;
            this.dwightDEisenhowerTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.dwightDEisenhowerTextBox, "Which # President\r\n");
            // 
            // martinVanBurenTextBox
            // 
            this.martinVanBurenTextBox.Location = new System.Drawing.Point(300, 85);
            this.martinVanBurenTextBox.Name = "martinVanBurenTextBox";
            this.martinVanBurenTextBox.Size = new System.Drawing.Size(28, 20);
            this.martinVanBurenTextBox.TabIndex = 25;
            this.martinVanBurenTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.martinVanBurenTextBox, "Which # President\r\n");
            // 
            // georgeWashingtonTextBox
            // 
            this.georgeWashingtonTextBox.Location = new System.Drawing.Point(300, 109);
            this.georgeWashingtonTextBox.Name = "georgeWashingtonTextBox";
            this.georgeWashingtonTextBox.Size = new System.Drawing.Size(28, 20);
            this.georgeWashingtonTextBox.TabIndex = 26;
            this.georgeWashingtonTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.georgeWashingtonTextBox, "Which # President\r\n");
            // 
            // johnAdamsTextBox
            // 
            this.johnAdamsTextBox.Location = new System.Drawing.Point(300, 132);
            this.johnAdamsTextBox.Name = "johnAdamsTextBox";
            this.johnAdamsTextBox.Size = new System.Drawing.Size(28, 20);
            this.johnAdamsTextBox.TabIndex = 27;
            this.johnAdamsTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.johnAdamsTextBox, "Which # President\r\n");
            // 
            // theodoreRooseveltTextBox
            // 
            this.theodoreRooseveltTextBox.Location = new System.Drawing.Point(300, 156);
            this.theodoreRooseveltTextBox.Name = "theodoreRooseveltTextBox";
            this.theodoreRooseveltTextBox.Size = new System.Drawing.Size(28, 20);
            this.theodoreRooseveltTextBox.TabIndex = 28;
            this.theodoreRooseveltTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.theodoreRooseveltTextBox, "Which # President\r\n");
            // 
            // thomasJeffersonTextBox
            // 
            this.thomasJeffersonTextBox.CausesValidation = false;
            this.thomasJeffersonTextBox.Location = new System.Drawing.Point(300, 180);
            this.thomasJeffersonTextBox.Name = "thomasJeffersonTextBox";
            this.thomasJeffersonTextBox.Size = new System.Drawing.Size(28, 20);
            this.thomasJeffersonTextBox.TabIndex = 29;
            this.thomasJeffersonTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.thomasJeffersonTextBox, "Which # President\r\n");
            // 
            // williamMcKinleyRadioButton
            // 
            this.williamMcKinleyRadioButton.AutoSize = true;
            this.williamMcKinleyRadioButton.Location = new System.Drawing.Point(171, 14);
            this.williamMcKinleyRadioButton.Name = "williamMcKinleyRadioButton";
            this.williamMcKinleyRadioButton.Size = new System.Drawing.Size(104, 17);
            this.williamMcKinleyRadioButton.TabIndex = 30;
            this.williamMcKinleyRadioButton.Text = "William McKinley";
            this.williamMcKinleyRadioButton.UseVisualStyleBackColor = true;
            // 
            // ronaldRaeganRadioButton
            // 
            this.ronaldRaeganRadioButton.AutoSize = true;
            this.ronaldRaeganRadioButton.Location = new System.Drawing.Point(171, 37);
            this.ronaldRaeganRadioButton.Name = "ronaldRaeganRadioButton";
            this.ronaldRaeganRadioButton.Size = new System.Drawing.Size(100, 17);
            this.ronaldRaeganRadioButton.TabIndex = 31;
            this.ronaldRaeganRadioButton.Text = "Ronald Reagan";
            this.ronaldRaeganRadioButton.UseVisualStyleBackColor = true;
            // 
            // dwightDEisenhowerRadioButton
            // 
            this.dwightDEisenhowerRadioButton.AutoSize = true;
            this.dwightDEisenhowerRadioButton.Location = new System.Drawing.Point(171, 61);
            this.dwightDEisenhowerRadioButton.Name = "dwightDEisenhowerRadioButton";
            this.dwightDEisenhowerRadioButton.Size = new System.Drawing.Size(127, 17);
            this.dwightDEisenhowerRadioButton.TabIndex = 32;
            this.dwightDEisenhowerRadioButton.Text = "Dwight D Eisenhower";
            this.dwightDEisenhowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // martinVanBurenRadioButton
            // 
            this.martinVanBurenRadioButton.AutoSize = true;
            this.martinVanBurenRadioButton.Location = new System.Drawing.Point(171, 85);
            this.martinVanBurenRadioButton.Name = "martinVanBurenRadioButton";
            this.martinVanBurenRadioButton.Size = new System.Drawing.Size(104, 17);
            this.martinVanBurenRadioButton.TabIndex = 33;
            this.martinVanBurenRadioButton.Text = "Martin VanBuren";
            this.martinVanBurenRadioButton.UseVisualStyleBackColor = true;
            // 
            // georgeWashingtonRadioButton
            // 
            this.georgeWashingtonRadioButton.AutoSize = true;
            this.georgeWashingtonRadioButton.Location = new System.Drawing.Point(171, 109);
            this.georgeWashingtonRadioButton.Name = "georgeWashingtonRadioButton";
            this.georgeWashingtonRadioButton.Size = new System.Drawing.Size(120, 17);
            this.georgeWashingtonRadioButton.TabIndex = 34;
            this.georgeWashingtonRadioButton.Text = "George Washington";
            this.georgeWashingtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // johnAdamsRadioButton
            // 
            this.johnAdamsRadioButton.AutoSize = true;
            this.johnAdamsRadioButton.Location = new System.Drawing.Point(171, 133);
            this.johnAdamsRadioButton.Name = "johnAdamsRadioButton";
            this.johnAdamsRadioButton.Size = new System.Drawing.Size(83, 17);
            this.johnAdamsRadioButton.TabIndex = 35;
            this.johnAdamsRadioButton.Text = "John Adams";
            this.johnAdamsRadioButton.UseVisualStyleBackColor = true;
            // 
            // theodoreRooseveltRadioButton
            // 
            this.theodoreRooseveltRadioButton.AutoSize = true;
            this.theodoreRooseveltRadioButton.Location = new System.Drawing.Point(171, 157);
            this.theodoreRooseveltRadioButton.Name = "theodoreRooseveltRadioButton";
            this.theodoreRooseveltRadioButton.Size = new System.Drawing.Size(122, 17);
            this.theodoreRooseveltRadioButton.TabIndex = 36;
            this.theodoreRooseveltRadioButton.Text = "Theodore Roosevelt";
            this.theodoreRooseveltRadioButton.UseVisualStyleBackColor = true;
            // 
            // thomasJeffersonRadioButton
            // 
            this.thomasJeffersonRadioButton.AutoSize = true;
            this.thomasJeffersonRadioButton.Location = new System.Drawing.Point(171, 181);
            this.thomasJeffersonRadioButton.Name = "thomasJeffersonRadioButton";
            this.thomasJeffersonRadioButton.Size = new System.Drawing.Size(109, 17);
            this.thomasJeffersonRadioButton.TabIndex = 37;
            this.thomasJeffersonRadioButton.Text = "Thomas Jefferson";
            this.thomasJeffersonRadioButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Presidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(985, 642);
            this.ControlBox = false;
            this.Controls.Add(this.thomasJeffersonRadioButton);
            this.Controls.Add(this.theodoreRooseveltRadioButton);
            this.Controls.Add(this.johnAdamsRadioButton);
            this.Controls.Add(this.georgeWashingtonRadioButton);
            this.Controls.Add(this.martinVanBurenRadioButton);
            this.Controls.Add(this.dwightDEisenhowerRadioButton);
            this.Controls.Add(this.ronaldRaeganRadioButton);
            this.Controls.Add(this.williamMcKinleyRadioButton);
            this.Controls.Add(this.thomasJeffersonTextBox);
            this.Controls.Add(this.theodoreRooseveltTextBox);
            this.Controls.Add(this.johnAdamsTextBox);
            this.Controls.Add(this.georgeWashingtonTextBox);
            this.Controls.Add(this.martinVanBurenTextBox);
            this.Controls.Add(this.dwightDEisenhowerTextBox);
            this.Controls.Add(this.ronaldRaeganTextBox);
            this.Controls.Add(this.williamMcKinleyTextBox);
            this.Controls.Add(this.johnFKennedyTextBox);
            this.Controls.Add(this.barackObamaTextBox);
            this.Controls.Add(this.georgeWBushTextBox);
            this.Controls.Add(this.franklinPierceTextBox);
            this.Controls.Add(this.jamesBuchananTextBox);
            this.Controls.Add(this.williamJClintonTextBox);
            this.Controls.Add(this.franklinDRooseveltTextBox);
            this.Controls.Add(this.benjaminHarrisonTextBox);
            this.Controls.Add(this.johnFKennedyRadioButton);
            this.Controls.Add(this.barackObamaRadioButton);
            this.Controls.Add(this.georgeWBushRadioButton);
            this.Controls.Add(this.franklinPierceRadioButton);
            this.Controls.Add(this.jamesBuchananRadioButton);
            this.Controls.Add(this.williamJClintonRadioButton);
            this.Controls.Add(this.franklinDRooseveltRadioButton);
            this.Controls.Add(this.benjaminHarrisonRadioButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.webBrowserGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Presidents";
            this.Text = "Presidents";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.webBrowserGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox webBrowserGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton federalistRadioButton;
        private System.Windows.Forms.RadioButton democraticRepublicanRadioButton;
        private System.Windows.Forms.RadioButton republicanRadioButton;
        private System.Windows.Forms.RadioButton democratRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton benjaminHarrisonRadioButton;
        private System.Windows.Forms.RadioButton franklinDRooseveltRadioButton;
        private System.Windows.Forms.RadioButton williamJClintonRadioButton;
        private System.Windows.Forms.RadioButton jamesBuchananRadioButton;
        private System.Windows.Forms.RadioButton franklinPierceRadioButton;
        private System.Windows.Forms.RadioButton georgeWBushRadioButton;
        private System.Windows.Forms.RadioButton barackObamaRadioButton;
        private System.Windows.Forms.RadioButton johnFKennedyRadioButton;
        private System.Windows.Forms.TextBox benjaminHarrisonTextBox;
        private System.Windows.Forms.TextBox franklinDRooseveltTextBox;
        private System.Windows.Forms.TextBox williamJClintonTextBox;
        private System.Windows.Forms.TextBox jamesBuchananTextBox;
        private System.Windows.Forms.TextBox franklinPierceTextBox;
        private System.Windows.Forms.TextBox georgeWBushTextBox;
        private System.Windows.Forms.TextBox barackObamaTextBox;
        private System.Windows.Forms.TextBox johnFKennedyTextBox;
        private System.Windows.Forms.TextBox williamMcKinleyTextBox;
        private System.Windows.Forms.TextBox ronaldRaeganTextBox;
        private System.Windows.Forms.TextBox dwightDEisenhowerTextBox;
        private System.Windows.Forms.TextBox martinVanBurenTextBox;
        private System.Windows.Forms.TextBox georgeWashingtonTextBox;
        private System.Windows.Forms.TextBox johnAdamsTextBox;
        private System.Windows.Forms.TextBox theodoreRooseveltTextBox;
        private System.Windows.Forms.TextBox thomasJeffersonTextBox;
        private System.Windows.Forms.RadioButton williamMcKinleyRadioButton;
        private System.Windows.Forms.RadioButton ronaldRaeganRadioButton;
        private System.Windows.Forms.RadioButton dwightDEisenhowerRadioButton;
        private System.Windows.Forms.RadioButton martinVanBurenRadioButton;
        private System.Windows.Forms.RadioButton georgeWashingtonRadioButton;
        private System.Windows.Forms.RadioButton johnAdamsRadioButton;
        private System.Windows.Forms.RadioButton theodoreRooseveltRadioButton;
        private System.Windows.Forms.RadioButton thomasJeffersonRadioButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

