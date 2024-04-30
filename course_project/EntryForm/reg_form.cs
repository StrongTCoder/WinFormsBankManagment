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
    public partial class reg_form : Form
    {
        public reg_form()
        {
            InitializeComponent();

            personId.Text = "ID";
            personId.ForeColor = Color.Gray;
            
            nameText.Text = "Введите ФИО";
            nameText.ForeColor = Color.Gray;

            bankID.Text = "ID банка";
            bankID.ForeColor = Color.Gray;

            jobTitle.Text = "Введите должность";
            jobTitle.ForeColor = Color.Gray;

            emailText.Text = "Введите email";
            emailText.ForeColor = Color.Gray;

            phoneText.Text = "Введите телефон";
            phoneText.ForeColor = Color.Gray;

            loginText.Text = "Введите логин";
            loginText.ForeColor = Color.Gray;

            passwordText.Text = "Введите пароль";
            passwordText.ForeColor = Color.Gray;


            this.MaximizeBox = false;
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            if (nameText.Text == "Введите ФИО")
            {
                nameText.Text = "";
                nameText.ForeColor = Color.Black;
            }
        }

        private void nameText_Leave(object sender, EventArgs e)
        {
            if (nameText.Text == "")
            {
                nameText.Text = "Введите ФИО";
                nameText.ForeColor = Color.Gray;
            }
        }


        private void companyName_Enter(object sender, EventArgs e)
        {
            if (jobTitle.Text == "Введите должность")
            {
                jobTitle.Text = "";
                jobTitle.ForeColor = Color.Black;
            }
        }

        private void companyName_Leave(object sender, EventArgs e)
        {
            if (jobTitle.Text == "")
            {
                jobTitle.Text = "Введите должность";
                jobTitle.ForeColor = Color.Gray;
            }
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginText.Text == "Введите логин")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Black;
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginText.Text == "")
            {
                loginText.Text = "Введите логин";
                loginText.ForeColor = Color.Gray;
            }
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.Text == "Введите пароль")
            {
                passwordText.Text = "";
                passwordText.PasswordChar = '*';
                passwordText.ForeColor = Color.Black;
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.Text == "")
            {
                passwordText.PasswordChar = '\0';
                passwordText.Text = "Введите пароль";
                passwordText.ForeColor = Color.Gray;
            }
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if (personId.Text == "ID")
            {
                MessageBox.Show("Введите ID");
                return;
            }
            if (nameText.Text == "Введите ФИО")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            if (bankID.Text == "ID банка")
            {
                MessageBox.Show("Введите id банка");
                return;
            }
            if (jobTitle.Text == "Введите должность")
            {
                MessageBox.Show("Введите должность");
                return;
            }
            if (emailText.Text == "Введите email")
            {
                MessageBox.Show("Введите email");
                return;
            }
            if (phoneText.Text == "Введите номер")
            {
                MessageBox.Show("Введите номер");
                return;
            }
            if (loginText.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
            }
            if (passwordText.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (isUserExists())
                return;

            DB db = new DB("postgres", "Zx21346578Sr");

            db.openConnectionDB();

            string userLogin = loginText.Text;
            string userPassword = passwordText.Text;

            NpgsqlCommand checkRoleCommand = new NpgsqlCommand($"SELECT COUNT(*) FROM pg_roles WHERE rolname = @uL", db.genConnectionDB());
            checkRoleCommand.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userLogin;

            int roleCount = Convert.ToInt32(checkRoleCommand.ExecuteScalar());

            db.closeConnectionDB();
            if (roleCount == 0)
            {
            

                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO Employee (EmployeeID, NameOfEmployee, Position, Branch_id, email, phone, hiredate, workedtime_lastMonth, prize) VALUES (@uPID, @uN, @uT, @uBID, @uE, @uP, @hD, 0, 0)", db.genConnectionDB());


                int person_ID = int.Parse(personId.Text);
                string userName = nameText.Text;
                int idbank = int.Parse(bankID.Text);
                string userTitle = jobTitle.Text;
                string userEmail = emailText.Text;
                string userPhone = phoneText.Text;
                DateTime hiredate = DateTime.Now.Date;


                command.Parameters.Add("@uPID", NpgsqlTypes.NpgsqlDbType.Integer).Value = person_ID;
                command.Parameters.Add("@uN", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userName;
                command.Parameters.Add("@uBID", NpgsqlTypes.NpgsqlDbType.Integer).Value = idbank;
                command.Parameters.Add("@uT", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userTitle;
                command.Parameters.Add("@uE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userEmail;
                command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userPhone;
                command.Parameters.Add("@hD", NpgsqlTypes.NpgsqlDbType.Date).Value = hiredate;

                db.openConnectionDB();

                if (command.ExecuteNonQuery() == 1)
                {
                    NpgsqlCommand addUserCommand = new NpgsqlCommand($"CREATE user {userLogin} password '{@userPassword}'", db.genConnectionDB());
                    addUserCommand.ExecuteNonQuery();

                    // Присваиваем роль созданному пользователю
                    if (userTitle == "Банкир")
                    {
                        NpgsqlCommand assignRoleCommand = new NpgsqlCommand($"GRANT banker TO {userLogin}", db.genConnectionDB());
                        assignRoleCommand.ExecuteNonQuery();
                    }
                    if (userTitle == "Специалист по кредитам")
                    {
                        NpgsqlCommand assignRoleCommand = new NpgsqlCommand($"GRANT loan_specialist TO {userLogin}", db.genConnectionDB());
                        assignRoleCommand.ExecuteNonQuery();
                    }
                    if (userTitle == "администратор")
                    {
                        NpgsqlCommand assignRoleCommand = new NpgsqlCommand($"GRANT administrator TO {userLogin}", db.genConnectionDB());
                        assignRoleCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Аккаунт создан!");
                    this.Close();
                    login_form logForm = new login_form();
                    logForm.Show();
                }
                else
                {
                    MessageBox.Show("Не удалось создать аккаунт!");
                }
            }
            else
            {
                MessageBox.Show("Аккаунт с таким пользователем уже существует!");
            }
            db.closeConnectionDB();
        }

        private Boolean isUserExists()
        {
            DB db = new DB("postgres", "Zx21346578Sr");

            db.openConnectionDB();

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            string userLogin = loginText.Text;

            NpgsqlCommand checkRoleCommand = new NpgsqlCommand($"SELECT COUNT(*) FROM pg_roles WHERE rolname = @uL", db.genConnectionDB());
            checkRoleCommand.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userLogin;

            int roleCount = Convert.ToInt32(checkRoleCommand.ExecuteScalar());

            db.closeConnectionDB();

            if (roleCount > 0)
            {
                MessageBox.Show("Логин уже занят, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form login = new login_form();
            login.Show();
        }

        private void personId_Enter(object sender, EventArgs e)
        {
            if (personId.Text == "ID")
            {
                personId.Text = "";
                personId.ForeColor = Color.Black;
            }
        }

        private void personId_Leave(object sender, EventArgs e)
        {
            if (personId.Text == "")
            {
                personId.Text = "ID";
                personId.ForeColor = Color.Gray;
            }
        }

        private void bankID_Enter(object sender, EventArgs e)
        {
            if (bankID.Text == "ID банка")
            {
                bankID.Text = "";
                bankID.ForeColor = Color.Black;
            }
        }

        private void bankID_Leave(object sender, EventArgs e)
        {
            if (bankID.Text == "")
            {
                bankID.Text = "ID банка";
                bankID.ForeColor = Color.Gray;
            }
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "Введите email")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Введите email";
                emailText.ForeColor = Color.Gray;
            }
        }

        private void phoneText_Enter(object sender, EventArgs e)
        {
            if (phoneText.Text == "Введите телефон")
            {
                phoneText.Text = "";
                phoneText.ForeColor = Color.Black;
            }
        }

        private void phoneText_Leave(object sender, EventArgs e)
        {
            if (phoneText.Text == "")
            {
                phoneText.Text = "Введите телефон";
                phoneText.ForeColor = Color.Gray;
            }
        }
    }
}
