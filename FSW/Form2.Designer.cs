namespace FSW
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.extensionText = new System.Windows.Forms.Label();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.extensionDropDown = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.dateColumnLabel = new System.Windows.Forms.Label();
            this.timeColumnLabel = new System.Windows.Forms.Label();
            this.extensionColumnLabel = new System.Windows.Forms.Label();
            this.nameColumnLabel = new System.Windows.Forms.Label();
            this.eventColumnLabel = new System.Windows.Forms.Label();
            this.pathColumnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(15, 52);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(75, 22);
            this.extensionTextBox.TabIndex = 0;
            // 
            // extensionText
            // 
            this.extensionText.AutoSize = true;
            this.extensionText.Location = new System.Drawing.Point(12, 32);
            this.extensionText.Name = "extensionText";
            this.extensionText.Size = new System.Drawing.Size(151, 17);
            this.extensionText.TabIndex = 1;
            this.extensionText.Text = "Extension (empty = all)";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRichTextBox.Location = new System.Drawing.Point(15, 136);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(650, 275);
            this.outputRichTextBox.TabIndex = 2;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.WordWrap = false;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(221, 80);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(132, 23);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Query Database";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(595, 82);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.extensionDropDown.Location = new System.Drawing.Point(15, 80);
            this.extensionDropDown.Name = "extensionDropDown";
            this.extensionDropDown.Size = new System.Drawing.Size(75, 24);
            this.extensionDropDown.TabIndex = 5;
            this.extensionDropDown.SelectedIndexChanged += new System.EventHandler(this.extensionComboBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(97, 50);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(12, 417);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(137, 23);
            this.eraseButton.TabIndex = 7;
            this.eraseButton.Text = "Erase Database";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(218, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(391, 68);
            this.instructionsLabel.TabIndex = 8;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // dateColumnLabel
            // 
            this.dateColumnLabel.AutoSize = true;
            this.dateColumnLabel.Location = new System.Drawing.Point(35, 111);
            this.dateColumnLabel.Name = "dateColumnLabel";
            this.dateColumnLabel.Size = new System.Drawing.Size(38, 17);
            this.dateColumnLabel.TabIndex = 9;
            this.dateColumnLabel.Text = "Date";
            // 
            // timeColumnLabel
            // 
            this.timeColumnLabel.AutoSize = true;
            this.timeColumnLabel.Location = new System.Drawing.Point(110, 111);
            this.timeColumnLabel.Name = "timeColumnLabel";
            this.timeColumnLabel.Size = new System.Drawing.Size(39, 17);
            this.timeColumnLabel.TabIndex = 10;
            this.timeColumnLabel.Text = "Time";
            // 
            // extensionColumnLabel
            // 
            this.extensionColumnLabel.AutoSize = true;
            this.extensionColumnLabel.Location = new System.Drawing.Point(273, 111);
            this.extensionColumnLabel.Name = "extensionColumnLabel";
            this.extensionColumnLabel.Size = new System.Drawing.Size(27, 17);
            this.extensionColumnLabel.TabIndex = 11;
            this.extensionColumnLabel.Text = "Ext";
            // 
            // nameColumnLabel
            // 
            this.nameColumnLabel.AutoSize = true;
            this.nameColumnLabel.Location = new System.Drawing.Point(375, 111);
            this.nameColumnLabel.Name = "nameColumnLabel";
            this.nameColumnLabel.Size = new System.Drawing.Size(45, 17);
            this.nameColumnLabel.TabIndex = 12;
            this.nameColumnLabel.Text = "Name";
            // 
            // eventColumnLabel
            // 
            this.eventColumnLabel.AutoSize = true;
            this.eventColumnLabel.Location = new System.Drawing.Point(205, 111);
            this.eventColumnLabel.Name = "eventColumnLabel";
            this.eventColumnLabel.Size = new System.Drawing.Size(44, 17);
            this.eventColumnLabel.TabIndex = 13;
            this.eventColumnLabel.Text = "Event";
            // 
            // pathColumnLabel
            // 
            this.pathColumnLabel.AutoSize = true;
            this.pathColumnLabel.Location = new System.Drawing.Point(550, 111);
            this.pathColumnLabel.Name = "pathColumnLabel";
            this.pathColumnLabel.Size = new System.Drawing.Size(37, 17);
            this.pathColumnLabel.TabIndex = 14;
            this.pathColumnLabel.Text = "Path";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 455);
            this.Controls.Add(this.pathColumnLabel);
            this.Controls.Add(this.eventColumnLabel);
            this.Controls.Add(this.nameColumnLabel);
            this.Controls.Add(this.extensionColumnLabel);
            this.Controls.Add(this.timeColumnLabel);
            this.Controls.Add(this.dateColumnLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.extensionDropDown);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.extensionText);
            this.Controls.Add(this.extensionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Query Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label extensionText;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox extensionDropDown;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label dateColumnLabel;
        private System.Windows.Forms.Label timeColumnLabel;
        private System.Windows.Forms.Label extensionColumnLabel;
        private System.Windows.Forms.Label nameColumnLabel;
        private System.Windows.Forms.Label eventColumnLabel;
        private System.Windows.Forms.Label pathColumnLabel;
    }
}