using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWindows
{
    public partial class Form1 : Form
    {
        //Initialize the connection class
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //start register window
            Register register = new Register();
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //db.ExecuteSelect("SELECT * FROM `user_info` where username='" + textBox1.Text + "' and password='" + textBox2 + "'");

            //query MySQL database for the data passed from textboxes
            db.ExecuteSelect("SELECT * FROM `user_info` where username='" + usernameTextBox.Text + "' and password='" + passwordTextBox.Text + "'");

            if(db.Count() == 1)
            {
                MessageBox.Show("Success You Will Login as" + db.Results(0, " names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
