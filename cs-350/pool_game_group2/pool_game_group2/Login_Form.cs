using pool_game_group2.Connection;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pool_game_group2
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassword.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void RegisterFormLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Form form = new Register_Form();
            form.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM LOGIN ";
                mySQL += "WHERE Username = '" + usernameTextBox.Text + "' ";
                mySQL += "AND Password = '" + passwordTextBox.Text + "'";

                DataTable Data = SQLServerConnection.executeSQL(mySQL);

                if (Data.Rows.Count > 0)
                {
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    showPassword.Checked = false;


                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();
                    this.Show();
                    this.usernameTextBox.Select();
                }
                else
                {
                     MessageBox.Show("The username or password is incorrect. Try again!",
                       "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.", "Login Form",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Select();
            }
        }
    }
}
