using System;
//add this for MessageBox
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//add data function classes
using System.Data;

namespace LoginRegisterWindows
{
    class Config
    {
        string ConnectionString = "";
        public MySqlConnection connection = null;
        public string server = "localhost"; //MySQL host / ip of the computer
        public string user = "root"; //MySQL user
        public string password = "root"; //MySQL password
        DataSet ds;
        DataTable dt;
        public string Table = "user_info";//initialize db table
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public Config()
        {

        }

        //function to connect to database
        public void Connect(string database_name)
        {
            try
            {

                ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(ConnectionString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        //Function to execute select statements
        public void ExecuteSql(string Sql_command)
        {
            nowquiee(Sql_command);
        }

        //Creates connection to MySQL before Execution
        public void nowquiee(string sql_comn)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comn, cs);
                myc.ExecuteNonQuery();

                cs.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //Function to execute delete, insert and update
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);

            try
            {
                string command = RecordSource.ToUpper();

                //if sql contains select
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);
                //
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        //Function to bring selected results based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        //Function to bring selected results based on column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
        }

        //Execute select statement
        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //Count number of rows after select
        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
