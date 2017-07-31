namespace FSW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.writeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.queryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.directoryToMonitorLabel = new System.Windows.Forms.Label();
            this.directoryTextbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.extensionSubmitButton = new System.Windows.Forms.Button();
            this.directorySubmitButton = new System.Windows.Forms.Button();
            this.fileSystemWatcherEventsLabel = new System.Windows.Forms.Label();
            this.extensionDropDown = new System.Windows.Forms.ComboBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dateColumnLabel = new System.Windows.Forms.Label();
            this.timeColumnLabel = new System.Windows.Forms.Label();
            this.eventColumnLabel = new System.Windows.Forms.Label();
            this.extensionColumnLabel = new System.Windows.Forms.Label();
            this.nameColumnLabel = new System.Windows.Forms.Label();
            this.pathColumnLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearEventsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // clearEventsToolStripMenuItem
            // 
            this.clearEventsToolStripMenuItem.Name = "clearEventsToolStripMenuItem";
            this.clearEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.clearEventsToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.clearEventsToolStripMenuItem.Text = "Clear Events";
            this.clearEventsToolStripMenuItem.Click += new System.EventHandler(this.clearEventsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToDatabaseToolStripMenuItem,
            this.queryDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // writeToDatabaseToolStripMenuItem
            // 
            this.writeToDatabaseToolStripMenuItem.Name = "writeToDatabaseToolStripMenuItem";
            this.writeToDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.writeToDatabaseToolStripMenuItem.Text = "Write to Database";
            this.writeToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.writeToDatabaseToolStripMenuItem_Click);
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.queryDatabaseToolStripMenuItem.Text = "Query Database";
            this.queryDatabaseToolStripMenuItem.Click += new System.EventHandler(this.queryDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripButton,
            this.stopToolStripButton,
            this.writeToolStripButton,
            this.clearToolStripButton,
            this.queryToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripButton.Image")));
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.startToolStripButton.Text = "Start";
            this.startToolStripButton.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolStripButton.Text = "Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // writeToolStripButton
            // 
            this.writeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("writeToolStripButton.Image")));
            this.writeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeToolStripButton.Name = "writeToolStripButton";
            this.writeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.writeToolStripButton.Text = "Write to Database";
            this.writeToolStripButton.Click += new System.EventHandler(this.writeToolStripButton_Click);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripButton.Image")));
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clearToolStripButton.Text = "Clear Events";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButton_Click);
            // 
            // queryToolStripButton
            // 
            this.queryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("queryToolStripButton.Image")));
            this.queryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.queryToolStripButton.Name = "queryToolStripButton";
            this.queryToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.queryToolStripButton.Text = "Query Database";
            this.queryToolStripButton.Click += new System.EventHandler(this.queryToolStripButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 53);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(600, 34);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Enter a valid directory and press \'Submit\'.  Optionally enter a file extension an" +
    "d press \'Submit\'.\r\nPress \'Start\' to begin monitoring and \'Stop\' to quit monitori" +
    "ng.";
            // 
            // directoryToMonitorLabel
            // 
            this.directoryToMonitorLabel.AutoSize = true;
            this.directoryToMonitorLabel.Location = new System.Drawing.Point(51, 106);
            this.directoryToMonitorLabel.Name = "directoryToMonitorLabel";
            this.directoryToMonitorLabel.Size = new System.Drawing.Size(132, 17);
            this.directoryToMonitorLabel.TabIndex = 3;
            this.directoryToMonitorLabel.Text = "Directory to monitor";
            // 
            // directoryTextbox
            // 
            this.directoryTextbox.Location = new System.Drawing.Point(15, 126);
            this.directoryTextbox.Name = "directoryTextbox";
            this.directoryTextbox.Size = new System.Drawing.Size(200, 22);
            this.directoryTextbox.TabIndex = 4;
            this.directoryTextbox.Text = "C:\\";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 154);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(121, 154);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(364, 100);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(151, 17);
            this.extensionLabel.TabIndex = 7;
            this.extensionLabel.Text = "Extension (empty = all)";
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(367, 126);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(75, 22);
            this.extensionTextBox.TabIndex = 9;
            // 
            // extensionSubmitButton
            // 
            this.extensionSubmitButton.Location = new System.Drawing.Point(448, 126);
            this.extensionSubmitButton.Name = "extensionSubmitButton";
            this.extensionSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.extensionSubmitButton.TabIndex = 10;
            this.extensionSubmitButton.Text = "Submit";
            this.extensionSubmitButton.UseVisualStyleBackColor = true;
            this.extensionSubmitButton.Click += new System.EventHandler(this.extensionSubmitButton_Click);
            // 
            // directorySubmitButton
            // 
            this.directorySubmitButton.Location = new System.Drawing.Point(222, 125);
            this.directorySubmitButton.Name = "directorySubmitButton";
            this.directorySubmitButton.Size = new System.Drawing.Size(75, 23);
            this.directorySubmitButton.TabIndex = 12;
            this.directorySubmitButton.Text = "Submit";
            this.directorySubmitButton.UseVisualStyleBackColor = true;
            this.directorySubmitButton.Click += new System.EventHandler(this.directorySubmitButton_Click);
            // 
            // fileSystemWatcherEventsLabel
            // 
            this.fileSystemWatcherEventsLabel.AutoSize = true;
            this.fileSystemWatcherEventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSystemWatcherEventsLabel.Location = new System.Drawing.Point(25, 188);
            this.fileSystemWatcherEventsLabel.Name = "fileSystemWatcherEventsLabel";
            this.fileSystemWatcherEventsLabel.Size = new System.Drawing.Size(184, 17);
            this.fileSystemWatcherEventsLabel.TabIndex = 14;
            this.fileSystemWatcherEventsLabel.Text = "File System Watcher Events";
            // 
            // extensionDropDown
            // 
            this.extensionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionDropDown.FormattingEnabled = true;
            this.extensionDropDown.Items.AddRange(new object[] {
            "(all)",
            "exe",
            "txt",
            "pdf",
            "doc",
            "docx",
            "mp3",
            "bmp",
            "png",
            "jpg",
            "zip",
            "7z"});
            this.extensionDropDown.Location = new System.Drawing.Point(367, 154);
            this.extensionDropDown.Name = "extensionDropDown";
            this.extensionDropDown.Size = new System.Drawing.Size(75, 24);
            this.extensionDropDown.TabIndex = 16;
            this.extensionDropDown.SelectedIndexChanged += new System.EventHandler(this.extensionDropDown_SelectedIndexChanged);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRichTextBox.Location = new System.Drawing.Point(15, 235);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(650, 300);
            this.outputRichTextBox.TabIndex = 17;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.WordWrap = false;
            // 
            // dateColumnLabel
            // 
            this.dateColumnLabel.AutoSize = true;
            this.dateColumnLabel.Location = new System.Drawing.Point(35, 214);
            this.dateColumnLabel.Name = "dateColumnLabel";
            this.dateColumnLabel.Size = new System.Drawing.Size(38, 17);
            this.dateColumnLabel.TabIndex = 18;
            this.dateColumnLabel.Text = "Date";
            // 
            // timeColumnLabel
            // 
            this.timeColumnLabel.AutoSize = true;
            this.timeColumnLabel.Location = new System.Drawing.Point(110, 214);
            this.timeColumnLabel.Name = "timeColumnLabel";
            this.timeColumnLabel.Size = new System.Drawing.Size(39, 17);
            this.timeColumnLabel.TabIndex = 19;
            this.timeColumnLabel.Text = "Time";
            // 
            // eventColumnLabel
            // 
            this.eventColumnLabel.AutoSize = true;
            this.eventColumnLabel.Location = new System.Drawing.Point(205, 214);
            this.eventColumnLabel.Name = "eventColumnLabel";
            this.eventColumnLabel.Size = new System.Drawing.Size(44, 17);
            this.eventColumnLabel.TabIndex = 20;
            this.eventColumnLabel.Text = "Event";
            // 
            // extensionColumnLabel
            // 
            this.extensionColumnLabel.AutoSize = true;
            this.extensionColumnLabel.Location = new System.Drawing.Point(273, 214);
            this.extensionColumnLabel.Name = "extensionColumnLabel";
            this.extensionColumnLabel.Size = new System.Drawing.Size(27, 17);
            this.extensionColumnLabel.TabIndex = 21;
            this.extensionColumnLabel.Text = "Ext";
            // 
            // nameColumnLabel
            // 
            this.nameColumnLabel.AutoSize = true;
            this.nameColumnLabel.Location = new System.Drawing.Point(375, 213);
            this.nameColumnLabel.Name = "nameColumnLabel";
            this.nameColumnLabel.Size = new System.Drawing.Size(45, 17);
            this.nameColumnLabel.TabIndex = 22;
            this.nameColumnLabel.Text = "Name";
            // 
            // pathColumnLabel
            // 
            this.pathColumnLabel.AutoSize = true;
            this.pathColumnLabel.Location = new System.Drawing.Point(550, 213);
            this.pathColumnLabel.Name = "pathColumnLabel";
            this.pathColumnLabel.Size = new System.Drawing.Size(37, 17);
            this.pathColumnLabel.TabIndex = 23;
            this.pathColumnLabel.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 555);
            this.Controls.Add(this.pathColumnLabel);
            this.Controls.Add(this.nameColumnLabel);
            this.Controls.Add(this.extensionColumnLabel);
            this.Controls.Add(this.eventColumnLabel);
            this.Controls.Add(this.timeColumnLabel);
            this.Controls.Add(this.dateColumnLabel);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.extensionDropDown);
            this.Controls.Add(this.fileSystemWatcherEventsLabel);
            this.Controls.Add(this.directorySubmitButton);
            this.Controls.Add(this.extensionSubmitButton);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.directoryTextbox);
            this.Controls.Add(this.directoryToMonitorLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label directoryToMonitorLabel;
        private System.Windows.Forms.TextBox directoryTextbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.ToolStripButton clearToolStripButton;
        private System.Windows.Forms.ToolStripButton writeToolStripButton;
        private System.Windows.Forms.ToolStripButton queryToolStripButton;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.ToolStripMenuItem writeToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Button extensionSubmitButton;
        private System.Windows.Forms.Button directorySubmitButton;
        private System.Windows.Forms.Label fileSystemWatcherEventsLabel;
        private System.Windows.Forms.ComboBox extensionDropDown;
        private System.Windows.Forms.ToolStripMenuItem clearEventsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Label dateColumnLabel;
        private System.Windows.Forms.Label timeColumnLabel;
        private System.Windows.Forms.Label eventColumnLabel;
        private System.Windows.Forms.Label extensionColumnLabel;
        private System.Windows.Forms.Label nameColumnLabel;
        private System.Windows.Forms.Label pathColumnLabel;
    }
}

