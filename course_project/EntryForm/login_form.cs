using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace InventoryManagementSystem
{
    public partial class login_form : Form
    {
        private static string userLog;
        private static string userPass;

        private DB db;

        public login_form()
        {
            InitializeComponent();

            loginText.Text = "Логин";
            loginText.ForeColor = Color.Gray;

            PasswordText.Text = "Пароль";
            PasswordText.ForeColor = Color.Gray;


            this.MaximizeBox = false;
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Логин")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Black;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                loginText.Text = "Логин";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Пароль")
            {
                PasswordText.Text = "";
                PasswordText.PasswordChar = '*';
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.PasswordChar = '\0';
                PasswordText.Text = "Пароль";
                PasswordText.ForeColor = Color.Gray;
            }
        }


        private void log_btn_Click(object sender, EventArgs e)
        {

            userLog = loginText.Text;
            userPass = PasswordText.Text;

            db = new DB(userLog, userPass);

            if (db.IsUserVarification)
            {
                string userRole = db.UserRoleName;
                OpenUserFormByRole(userRole, userLog);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }


        private void OpenUsersForm(Form userForm)
        {
            userLog = loginText.Text;
            userPass = PasswordText.Text;
            this.Hide();
            userForm.Show();
        }

        private void OpenUserFormByRole(string userRole, string userLogin)
        {
            switch (userRole)
            {
                case "banker":
                    OpenUsersForm(new mainFormBanker(userLogin, ref db));
                    break;
                case "loan_specialist":
                    OpenUsersForm(new mainFormLoanSpec(userLogin, ref db)); 
                    break;
                case "administrator":
                    OpenUsersForm(new mainFormAdmin(userLogin, ref db));
                    break;
                default:
                    break;
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg_form newRegForm = new reg_form();
            newRegForm.Show();
        }

    }
}
