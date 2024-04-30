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
using NpgsqlTypes;

namespace InventoryManagementSystem
{
    public partial class mainFormAdmin : Form
    {

        private DB db;
        private DataSet dataSet = null;

        NpgsqlDataAdapter adapter;
        NpgsqlCommandBuilder builder;

        string tableName;


        

        public mainFormAdmin(String LoginPerson, ref DB db)
        {
            InitializeComponent();

            this.usersName.Text = LoginPerson;

            this.MaximizeBox = false;

            this.db = db;

        }

        private void LoadData(string TableName)
        {
            db.openConnectionDB();
            NpgsqlCommand command = new NpgsqlCommand($"select * from {TableName};", db.genConnectionDB());
            adapter = new NpgsqlDataAdapter(command);
            dataSet = new DataSet();
            builder = new NpgsqlCommandBuilder(adapter);


            builder.GetDeleteCommand();
            builder.GetInsertCommand();
            builder.GetUpdateCommand();

            adapter.Fill(dataSet, TableName);

            db.closeConnectionDB();

            information.DataSource = dataSet.Tables[TableName];
        }

        private void ReloadData(string tableName)
        {
            try
            {
                dataSet.Tables[tableName].Clear();
                NpgsqlCommand command = new NpgsqlCommand($"select * from {tableName};", db.genConnectionDB());
                adapter = new NpgsqlDataAdapter(command);

                adapter.Fill(dataSet, tableName);
                information.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void clientManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "Client";
            LoadData(tableName);
        }

        private void accountInfoBtn_Click(object sender, EventArgs e)
        {
            tableName = "Account";
            LoadData(tableName);
        }

        private void cardManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "Bankcard";
            LoadData(tableName);
        }

        private void transactionManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "Transaction";
            LoadData(tableName);
        }

        private void employeeInfoBtn_Click(object sender, EventArgs e)
        {
            tableName = "Employee";
            LoadData(tableName);
        }

        private void loanManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "Loan";
            LoadData(tableName);
        }

        private void loanPaymentManagmentBtn_Click(object sender, EventArgs e)
        {
            tableName = "Loanpayment";
            LoadData(tableName);
        }

        private void bankInfoBtn_Click(object sender, EventArgs e)
        {
            tableName = "Branch";
            LoadData(tableName);
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = information.Rows.Count - 2;

            NpgsqlCommand saveCommand = GetSaveCommand();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.UpdateCommand = saveCommand;

            adapter = new NpgsqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

            adapter.Update(dataSet, tableName);

            ReloadData(tableName);
        }

        private NpgsqlCommand GetSaveCommand()
        {
            NpgsqlCommand saveCommand = null;
            int rowIndex = information.Rows.Count - 2;

            string tableName = this.tableName;

            saveCommand = new NpgsqlCommand($"INSERT INTO {tableName} VALUES (", db.genConnectionDB());

            DataTable table = dataSet.Tables[tableName];

            DataColumnCollection columns = table.Columns;

            foreach (DataColumn column in columns)
            {
                string columnName = column.ColumnName;
                NpgsqlParameter parameter = new NpgsqlParameter($"@{columnName}", GetNpgsqlDbType(column.DataType));
                parameter.Value = information.Rows[rowIndex].Cells[columnName].Value;
                saveCommand.Parameters.Add(parameter);

                saveCommand.CommandText += $"@{columnName}, ";
            }

            saveCommand.CommandText = saveCommand.CommandText.TrimEnd(',', ' ') + ")";

            return saveCommand;
        }

        private NpgsqlDbType GetNpgsqlDbType(Type type)
        {
            if (type == typeof(int))
                return NpgsqlTypes.NpgsqlDbType.Integer;
            else if (type == typeof(string))
                return NpgsqlTypes.NpgsqlDbType.Varchar;
            else if (type == typeof(DateTime))
                return NpgsqlTypes.NpgsqlDbType.Date;
            else if (type == typeof(decimal))
                return NpgsqlTypes.NpgsqlDbType.Numeric;

            throw new ArgumentException($"Не поддерживаемый тип данных: {type}");
        }

        private void Information_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void updateTableBtn_Click(object sender, EventArgs e)
        {
            ReloadData(tableName);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DataGridView c = this.information;

            if (MessageBox.Show("Удалить эти данные?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int rowIndex = c.CurrentCell.RowIndex;

                information.Rows.RemoveAt(rowIndex);

                dataSet.Tables[tableName].Rows[rowIndex].Delete();

                DataGridViewRow row = information.CurrentRow;
                DataGridViewCell cell = row.Cells[1];
                object value = cell.Value;

                NpgsqlCommand deleteCommand = new NpgsqlCommand($"delete from {tableName} where ID = {value}", db.genConnectionDB());
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.DeleteCommand = deleteCommand;

                adapter = new NpgsqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
                NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

                adapter.Update(dataSet, tableName);

            }

            ReloadData(tableName);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить значение?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {        

                object value = information.CurrentCell;
                NpgsqlCommand editCommand = new NpgsqlCommand($"update {tableName} set {information.Columns[information.CurrentCell.ColumnIndex].Name} = {value}", db.genConnectionDB());

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                adapter.UpdateCommand = editCommand;

                adapter = new NpgsqlDataAdapter($"select * from {tableName}", db.genConnectionDB());
                NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);

                adapter.Update(dataSet, tableName);

            }
        }


    }

}
