using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public class DB
    {
        private static string connectionStr;
        private NpgsqlConnection connection;
        private NpgsqlCommand command;

        private string userLogin;
        public string UserLogin { get { return userLogin; } }

        private string userPass;
        public string UserPass { get { return userPass; } }

        private bool isUserVarification;
        public bool IsUserVarification { get { return isUserVarification; } }

        private string userRoleName;
        public string UserRoleName {  get { return GetUserRoleName(); } }

        public DB(string loginperson, string passpeerson)
        {
            connectionStr = $"Host=localhost;Username={loginperson};Password={passpeerson};Database=Bank;";
            connection = new NpgsqlConnection(connectionStr);
            userLogin = loginperson;
            userPass = passpeerson;

            isUserVarification = UserVarification();
        }


        public void openConnectionDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnectionDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection genConnectionDB()
        {
            return connection;
        }

        public bool UserVarification()
        {
            try
            {
                using (NpgsqlConnection tempConnection = new NpgsqlConnection(connectionStr))
                {
                    tempConnection.Open();
                    return true;
                }

            }
            catch (NpgsqlException ex)
            {
                return false;
            }
        }
       
        private string GetUserRoleName()
        {
            string userRole;

            openConnectionDB();

            command = new NpgsqlCommand("SELECT r.rolname AS rolename FROM pg_user u JOIN pg_auth_members m ON u.usesysid = m.member JOIN pg_roles r ON m.roleid = r.oid Where u.usename = @uL", genConnectionDB());
            command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userLogin;
            userRole = command.ExecuteScalar() as string;
            closeConnectionDB();
            return userRole;

        }

    }
}
