using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PedleyProductManagement
{
    public partial class CreateJob : Window
    {
        const string DatabaseFileExtension = ".sqlite";
        string JobStorageLocation = @"D:\jobs\";

        DateTime TodaysDate;
        string JobName;
        string FilePath;


        public CreateJob()
        {
            InitializeComponent();
            TodaysDate = GetDate();
            CurrentDateTextBox.Text = TodaysDate.ToString("dd/MM/yyyy");
        }

        //Gets the current date from the system
        private DateTime GetDate()
        {
            DateTime today = DateTime.UtcNow.Date;
            return today;
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            //Resets error message
            if (!string.IsNullOrEmpty(ErrorMsgTextBlock.Text))
            {
                ErrorMsgTextBlock.Text = "";
            }

            //Makes sure a job name has been entered and if it has stores it.
            if (!string.IsNullOrEmpty(JobNameTextBox.Text))
            {
                JobName = JobNameTextBox.Text;
                FilePath = JobStorageLocation + "Jobs" + DatabaseFileExtension;
            }
            else
            {
                ErrorMsgTextBlock.Text = "Please Enter A Job name";
                return;
            }

            //Makes sure there is a directory to store the database file inside of
            if (Directory.Exists(JobStorageLocation))
            {
                CreateTable();
            }
            else
            {
                Directory.CreateDirectory(JobStorageLocation);
                CreateTable();
            }

        }
        private void CreateTable()
        {
            //Creates a database file for jobs if one doesnt already exist.
            if (!File.Exists(FilePath))
            {
                SQLiteConnection.CreateFile(FilePath); 
            }

            //Creates a connection to database file so that it can be modified.
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=D:\jobs\jobs.sqlite;Version=3");
            m_dbConnection.Open();

            //creates table in database file for the job being created.
            try
            {
                string sql = "SELECT name FROM sqlite_master WHERE name = '" + JobName + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    //Table already exsits
                    ErrorMsgTextBlock.Text = "Job Already Exists";
                    return;
                }
            }
            catch (Exception e){
                throw e;
            }

            ExecuteSQL("CREATE table " + JobName + "(ID int, Name CHARACTER(20))", m_dbConnection);
            ExecuteSQL("INSERT into '" + JobName + "' (ID, Name) values (1,'Cable')", m_dbConnection);

            //closes connection to save memory
            m_dbConnection.Close();
        }

        private void ExecuteSQL(string sql, SQLiteConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) {
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            else
            {
                //Connection wasnt open
            }
        }
    }
}
