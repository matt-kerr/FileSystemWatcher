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
using System.Data.SQLite;

namespace FSW
{
    public partial class Form2 : Form
    {
        
        public static string user_extension;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        
        public Form2()
        {
            InitializeComponent();
            user_extension = "";
            eraseButton.Enabled = false;
        }

        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void QueryDatabase()
        {

            
            outputRichTextBox.Clear();
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;
            string cur_date, cur_time, cur_event, cur_extension, cur_name, cur_path;

            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();

            if (user_extension == "")
            {
                sqlite_cmd.CommandText = "SELECT * FROM fsw";
            }
            else
            {
                sqlite_cmd.CommandText = "SELECT * FROM fsw WHERE extension LIKE'" + user_extension + "'";
            }

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                eraseButton.Enabled = true;
            }
            while (sqlite_datareader.Read())
            {
                string result;
                cur_date = sqlite_datareader["Date"].ToString();
                cur_time = sqlite_datareader["Time"].ToString();
                cur_event = sqlite_datareader["Event"].ToString();
                cur_extension = sqlite_datareader["Extension"].ToString();
                cur_name = sqlite_datareader["Name"].ToString();
                cur_path = sqlite_datareader["Path"].ToString();
                
                result = string.Format("{0,-10}{1,-12}{2,-10}{3,-5}{4,-25}{5}\n",
                                        cur_date,
                                        cur_time,
                                        cur_event,
                                        cur_extension,
                                        cur_name,
                                        cur_path);
                
                outputRichTextBox.AppendText(result);
            }
            sqlite_conn.Close();


        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            QueryDatabase();
        }

        private void extensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            user_extension = extensionTextBox.Text;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result =  MessageBox.Show("Are you sure you want to erase the database?", "Erase Database", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EraseDatabase();
            }
        }

        public void EraseDatabase()
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "DELETE FROM fsw WHERE 1==1;";


            sqlite_cmd.ExecuteNonQuery();
            outputRichTextBox.Clear();
            eraseButton.Enabled = false;
        }
    }
}
