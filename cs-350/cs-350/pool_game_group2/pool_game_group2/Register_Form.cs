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
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Save Data";

            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Please enter First Name", caption, btn, ico);
                NameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter Username", caption, btn, ico);
                usernameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please enter Email", caption, btn, ico);
                emailTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please enter Password", caption, btn, ico);
                passwordTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter Confirmation Password", caption, btn, ico);
                confirmPasswordTextBox.Select();
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Your password and confirmation password do not match", caption, btn, ico);
                confirmPasswordTextBox.Select();
                return;
            }

            string theSQL = "SELECT Username FROM LOGIN WHERE Username = '" + usernameTextBox.Text + "'";

            DataTable checkDuplicates = pool_game_group2.Connection.SQLServerConnection.executeSQL(theSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The username already exists. Please try another username",
                    "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameTextBox.SelectAll();
                return;
            }

            DialogResult result;

            result = MessageBox.Show("Do you want to save the record?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO LOGIN (Name, Username, Email, Password) ";
                mySQL += "VALUES ('" + NameTextBox.Text + "','" + usernameTextBox.Text + "','" + emailTextBox.Text + "','" + passwordTextBox.Text + "')";

                pool_game_group2.Connection.SQLServerConnection.executeSQL(mySQL);

                MessageBox.Show("The record has beem saved successfully.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

