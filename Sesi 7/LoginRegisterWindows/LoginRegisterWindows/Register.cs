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
    public partial class Register : Form
    {
    Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //closes the register windows
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //db.ExecuteSql("INSERT INTO `user_info` (`id`, `names`, `username`, `password`) " +
            //    "VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')");

            //saves data in the database
            db.Execute("INSERT INTO `user_info` (`id`, `names`, `username`, `password`) " +
                "VALUES (NULL, '" + nameTextBox.Text + "' , '" + usernameTextBox.Text + "' , '" + passwordTextBox.Text + "')");

            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
