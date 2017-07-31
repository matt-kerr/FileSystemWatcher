// Matthew Kerr
// CSCD371
// Midterm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using System.Data.SQLite;

namespace FSW
{
    public partial class Form1 : Form
    {
        public static SQLiteConnection sqlite_conn;
        public static SQLiteCommand sqlite_cmd;
        public static SQLiteDataReader sqlite_datareader;
        public static FileSystemWatcher watcher = new FileSystemWatcher();
        public static DateTime dt;
        public static bool isWatching;
        public static string user_directory;
        public static string user_extension;
        public static DataTable data_table;
        public static BindingSource bs;
        public static Form queryForm;
        public static Form aboutForm;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeWatcher();
            InitializeDataTable();
            queryForm = new Form2();
            queryForm.Owner = this;
            aboutForm = new Form3();
            aboutForm.Owner = this;
            isWatching = false;
            startButton.Enabled = false;
            stopButton.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            clearEventsToolStripMenuItem.Enabled = false;
            writeToDatabaseToolStripMenuItem.Enabled = false;
            writeToolStripButton.Enabled = false;
            clearToolStripButton.Enabled = false;
            startToolStripButton.Enabled = false;
            stopToolStripButton.Enabled = false;
            user_extension = "";
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void InitializeDatabase()
        {
            dt = DateTime.Now;

            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS fsw (id integer primary key autoincrement"
                + ", Date varchar(255), Time varchar(255)"
                + ", Event varchar(255), Extension varchar(255)"
                + ",Name varchar(255) , Path varchar(255));";
            sqlite_cmd.ExecuteNonQuery();

            
        }

        private void InitializeWatcher()
        {
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
        }

        private void InitializeDataTable()
        {
            data_table = new DataTable();
            data_table.Columns.Add("Date");
            data_table.Columns.Add("Time");
            data_table.Columns.Add("Event");
            data_table.Columns.Add("Extension");
            data_table.Columns.Add("Name");       
            data_table.Columns.Add("Path");            
        }

        private void addFileEvent(string date_string, string time_string, string event_string, string extension_string, string name_string, string path_string)
        {
            data_table.Rows.Add(new object[] { date_string, time_string, event_string, extension_string, name_string, path_string });



            string result = string.Format("{0,-10}{1,-12}{2,-10}{3,-5}{4,-25}{5}\n",
                                    date_string,
                                    time_string,
                                    event_string,
                                    extension_string,
                                    name_string,
                                    path_string);

            outputRichTextBox.AppendText(result);


            clearEventsToolStripMenuItem.Enabled = true;
            writeToDatabaseToolStripMenuItem.Enabled = true;  
            clearToolStripButton.Enabled = true;
            writeToolStripButton.Enabled = true;

        }


        private void OnChanged(object source, FileSystemEventArgs e)
        {
            string date_string = dt.ToString("d");
            string time_string = dt.ToString("T");
            string event_string = "Changed";
            string name_string = e.Name;
            string extension_string = GetExtension(name_string).ToLower();           
            string path_string = e.FullPath;
            if (user_extension == "" || user_extension == extension_string)
            {
                addFileEvent(date_string, time_string, event_string, extension_string, name_string, path_string);
            }
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            
            string date_string = dt.ToString("d");
            string time_string = dt.ToString("T");
            string event_string = "Created";
            string name_string = e.Name;
            string extension_string = GetExtension(name_string).ToLower();     
            string path_string = e.FullPath;
            if (user_extension == "" || user_extension == extension_string)
            {
                addFileEvent(date_string, time_string, event_string, extension_string, name_string, path_string);
            }
        }

        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            string date_string = dt.ToString("d");
            string time_string = dt.ToString("T");
            string event_string = "Deleted";
            string name_string = e.Name;
            string extension_string = GetExtension(name_string).ToLower(); 
            string path_string = e.FullPath;
            if (user_extension == "" || user_extension == extension_string)
            {
                addFileEvent(date_string, time_string, event_string, extension_string, name_string, path_string);
            }
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            string date_string = dt.ToString("d");
            string time_string = dt.ToString("T");
            string event_string = "Renamed";
            string name_string = e.Name;  
            string extension_string = GetExtension(name_string).ToLower();   
            string path_string = e.FullPath;
            if (user_extension == "" || user_extension == extension_string)
            {
                addFileEvent(date_string, time_string, event_string, extension_string, name_string, path_string);
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            StartWatcher();   
        }

        private void StartWatcher()
        {
            IsWatching = true;
            watcher.Path = user_directory;
            watcher.EnableRaisingEvents = true;

        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopWatcher();
        }

        private void StopWatcher()
        {
            IsWatching = false;
            watcher.EnableRaisingEvents = false;
        }

        private void directorySubmitButton_Click(object sender, EventArgs e)
        {
            if (directoryTextbox.Text == "C:\\")
            {
                MessageBox.Show("Directory too large to watch");
            }
            else if (IsValidWatchPath(directoryTextbox.Text) && IsWatching == false)
            {
                    user_directory = directoryTextbox.Text;
                    startButton.Enabled = true;
                    startToolStripButton.Enabled = true;
                    startToolStripMenuItem.Enabled = true;

            }
        }

        private Boolean IsValidWatchPath(string dir)
        {
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Error: Invalid path");
                startButton.Enabled = false;
                return false;
            }
            string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            int i;
            for (i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith("database.db"))
                {
                    MessageBox.Show("Error: Path contained log database");
                    return false;
                }
            }
            return true;
        }

        public Boolean IsWatching
        {
            get { return isWatching; }
            set
            {
                isWatching = value;
                if (value == true)
                {
                    startButton.Enabled = false;
                    stopButton.Enabled = true;
                    startToolStripMenuItem.Enabled = false;
                    stopToolStripMenuItem.Enabled = true;
                    startToolStripButton.Enabled = false;
                    stopToolStripButton.Enabled = true;
                    directoryTextbox.Enabled = false;
                    directorySubmitButton.Enabled = false;
                    extensionSubmitButton.Enabled = false;
                    extensionTextBox.Enabled = false;
                    extensionDropDown.Enabled = false;
                }
                else
                {
                    startButton.Enabled = true;
                    stopButton.Enabled = false;
                    startToolStripMenuItem.Enabled = true;
                    stopToolStripMenuItem.Enabled = false;
                    startToolStripButton.Enabled = true;
                    stopToolStripButton.Enabled = false;
                    directoryTextbox.Enabled = true;
                    directorySubmitButton.Enabled = true;
                    extensionSubmitButton.Enabled = true;
                    extensionTextBox.Enabled = true;
                    extensionDropDown.Enabled = true;
                }
            }
        }

        private void extensionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (extensionDropDown.Text == "(all)")
            {
                user_extension = "";
            }
            else
            {
                user_extension = extensionDropDown.Text;
            }
            extensionTextBox.Text = user_extension;
        }

        private void extensionSubmitButton_Click(object sender, EventArgs e)
        {
            user_extension = extensionTextBox.Text;
        }

        private String GetExtension(string filename)
        {
            string[] temp = filename.Split('.');
            return temp[temp.Length - 1];
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            StartWatcher();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            StopWatcher();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartWatcher();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatcher();
        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            ShowQueryForm();
        }

        private void ShowQueryForm()
        {
            queryForm.Show();
        }

        private void writeToolStripButton_Click(object sender, EventArgs e)
        {
            WriteToDatabase();
        }

        private void WriteToDatabase()
        {
            foreach (DataRow row in data_table.Rows)
            {
                sqlite_cmd.CommandText = "INSERT INTO fsw (Date, Time, Event, Extension, Name, Path) VALUES (?, ?, ?, ?, ?, ?);";
                sqlite_cmd.Parameters.Add("@Date", DbType.String).Value = row["Date"].ToString();
                sqlite_cmd.Parameters.Add("@Time", DbType.String).Value = row["Time"].ToString();
                sqlite_cmd.Parameters.Add("@Event", DbType.String).Value = row["Event"].ToString();
                sqlite_cmd.Parameters.Add("@Extension", DbType.String).Value = row["Extension"].ToString();
                sqlite_cmd.Parameters.Add("@Name", DbType.String).Value = row["Name"].ToString();  
                sqlite_cmd.Parameters.Add("@Path", DbType.String).Value = row["Path"].ToString();
                sqlite_cmd.ExecuteNonQuery();
            }
            data_table.Clear();
            outputRichTextBox.Clear();
            clearEventsToolStripMenuItem.Enabled = false;
            writeToDatabaseToolStripMenuItem.Enabled = false;
            clearToolStripButton.Enabled = false;
            writeToolStripButton.Enabled = false;
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            clearDataTable();
        }

        private void clearDataTable()
        {
            data_table.Clear();
            outputRichTextBox.Clear();
            clearEventsToolStripMenuItem.Enabled = false;
            writeToDatabaseToolStripMenuItem.Enabled = false;
            clearToolStripButton.Enabled = false;
            writeToolStripButton.Enabled = false;
        }

        private void clearEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearDataTable();
        }

        private void writeToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteToDatabase();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clearEventsToolStripMenuItem.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Would you like to write to the database before exiting?", "Write to Database?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    WriteToDatabase();
                }
                else if (result == DialogResult.No)
                {
                    // exit
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void queryDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQueryForm();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
