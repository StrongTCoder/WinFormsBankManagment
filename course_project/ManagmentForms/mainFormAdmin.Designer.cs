
namespace InventoryManagementSystem
{
    partial class mainFormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.usersCompany = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.usersName = new System.Windows.Forms.Label();
            this.clientManagmentBtn = new System.Windows.Forms.Button();
            this.accountInfoBtn = new System.Windows.Forms.Button();
            this.cardManagmentBtn = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.DataGridView();
            this.changeBtnPanel = new System.Windows.Forms.Panel();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.employeeInfoBtn = new System.Windows.Forms.Button();
            this.loanManagmentBtn = new System.Windows.Forms.Button();
            this.loanPaymentManagmentBtn = new System.Windows.Forms.Button();
            this.transactionManagmentBtn = new System.Windows.Forms.Button();
            this.bankInfoBtn = new System.Windows.Forms.Button();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            this.changeBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeadingPanel.BackgroundImage")));
            this.HeadingPanel.Controls.Add(this.ProgramName);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(1067, 58);
            this.HeadingPanel.TabIndex = 1;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.ProgramName.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.ForeColor = System.Drawing.Color.Black;
            this.ProgramName.Location = new System.Drawing.Point(503, 9);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(92, 42);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "Bank";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyLabel.Location = new System.Drawing.Point(55, 61);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(130, 30);
            this.companyLabel.TabIndex = 2;
            this.companyLabel.Text = "Должность:";
            // 
            // usersCompany
            // 
            this.usersCompany.AutoSize = true;
            this.usersCompany.BackColor = System.Drawing.Color.Transparent;
            this.usersCompany.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersCompany.Location = new System.Drawing.Point(181, 63);
            this.usersCompany.Name = "usersCompany";
            this.usersCompany.Size = new System.Drawing.Size(171, 30);
            this.usersCompany.TabIndex = 3;
            this.usersCompany.Text = "Администратор";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(55, 93);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(160, 30);
            this.user.TabIndex = 4;
            this.user.Text = "Пользователь:";
            // 
            // usersName
            // 
            this.usersName.AutoSize = true;
            this.usersName.BackColor = System.Drawing.Color.Transparent;
            this.usersName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersName.Location = new System.Drawing.Point(221, 93);
            this.usersName.Name = "usersName";
            this.usersName.Size = new System.Drawing.Size(67, 30);
            this.usersName.TabIndex = 5;
            this.usersName.Text = "name";
            // 
            // clientManagmentBtn
            // 
            this.clientManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientManagmentBtn.Location = new System.Drawing.Point(55, 126);
            this.clientManagmentBtn.Name = "clientManagmentBtn";
            this.clientManagmentBtn.Size = new System.Drawing.Size(165, 28);
            this.clientManagmentBtn.TabIndex = 7;
            this.clientManagmentBtn.Text = "Управление клиентами";
            this.clientManagmentBtn.UseVisualStyleBackColor = true;
            this.clientManagmentBtn.Click += new System.EventHandler(this.clientManagmentBtn_Click);
            // 
            // accountInfoBtn
            // 
            this.accountInfoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.accountInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountInfoBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountInfoBtn.Location = new System.Drawing.Point(315, 126);
            this.accountInfoBtn.Name = "accountInfoBtn";
            this.accountInfoBtn.Size = new System.Drawing.Size(165, 28);
            this.accountInfoBtn.TabIndex = 8;
            this.accountInfoBtn.Text = "Управление счетами";
            this.accountInfoBtn.UseVisualStyleBackColor = true;
            this.accountInfoBtn.Click += new System.EventHandler(this.accountInfoBtn_Click);
            // 
            // cardManagmentBtn
            // 
            this.cardManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardManagmentBtn.Location = new System.Drawing.Point(604, 130);
            this.cardManagmentBtn.Name = "cardManagmentBtn";
            this.cardManagmentBtn.Size = new System.Drawing.Size(165, 28);
            this.cardManagmentBtn.TabIndex = 9;
            this.cardManagmentBtn.Text = "Управление картами";
            this.cardManagmentBtn.UseVisualStyleBackColor = true;
            this.cardManagmentBtn.Click += new System.EventHandler(this.cardManagmentBtn_Click);
            // 
            // information
            // 
            this.information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.information.Location = new System.Drawing.Point(55, 198);
            this.information.Name = "information";
            this.information.RowTemplate.Height = 25;
            this.information.Size = new System.Drawing.Size(962, 356);
            this.information.TabIndex = 10;
            // 
            // changeBtnPanel
            // 
            this.changeBtnPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeBtnPanel.BackgroundImage")));
            this.changeBtnPanel.Controls.Add(this.updateTableBtn);
            this.changeBtnPanel.Controls.Add(this.saveBtn);
            this.changeBtnPanel.Controls.Add(this.deleteBtn);
            this.changeBtnPanel.Controls.Add(this.editBtn);
            this.changeBtnPanel.Location = new System.Drawing.Point(0, 572);
            this.changeBtnPanel.Name = "changeBtnPanel";
            this.changeBtnPanel.Size = new System.Drawing.Size(1067, 65);
            this.changeBtnPanel.TabIndex = 11;
            // 
            // updateTableBtn
            // 
            this.updateTableBtn.Location = new System.Drawing.Point(55, -1);
            this.updateTableBtn.Name = "updateTableBtn";
            this.updateTableBtn.Size = new System.Drawing.Size(75, 23);
            this.updateTableBtn.TabIndex = 3;
            this.updateTableBtn.Text = "Обновить";
            this.updateTableBtn.UseVisualStyleBackColor = true;
            this.updateTableBtn.Click += new System.EventHandler(this.updateTableBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(780, -1);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Добавить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(942, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(861, -1);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // employeeInfoBtn
            // 
            this.employeeInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeInfoBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeInfoBtn.Location = new System.Drawing.Point(55, 164);
            this.employeeInfoBtn.Name = "employeeInfoBtn";
            this.employeeInfoBtn.Size = new System.Drawing.Size(165, 28);
            this.employeeInfoBtn.TabIndex = 12;
            this.employeeInfoBtn.Text = "Управление сотрудниками";
            this.employeeInfoBtn.UseVisualStyleBackColor = true;
            this.employeeInfoBtn.Click += new System.EventHandler(this.employeeInfoBtn_Click);
            // 
            // loanManagmentBtn
            // 
            this.loanManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanManagmentBtn.Location = new System.Drawing.Point(315, 164);
            this.loanManagmentBtn.Name = "loanManagmentBtn";
            this.loanManagmentBtn.Size = new System.Drawing.Size(165, 28);
            this.loanManagmentBtn.TabIndex = 13;
            this.loanManagmentBtn.Text = "Управление кредитами";
            this.loanManagmentBtn.UseVisualStyleBackColor = true;
            this.loanManagmentBtn.Click += new System.EventHandler(this.loanManagmentBtn_Click);
            // 
            // loanPaymentManagmentBtn
            // 
            this.loanPaymentManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanPaymentManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanPaymentManagmentBtn.Location = new System.Drawing.Point(604, 164);
            this.loanPaymentManagmentBtn.Name = "loanPaymentManagmentBtn";
            this.loanPaymentManagmentBtn.Size = new System.Drawing.Size(165, 28);
            this.loanPaymentManagmentBtn.TabIndex = 14;
            this.loanPaymentManagmentBtn.Text = "Управление платежами";
            this.loanPaymentManagmentBtn.UseVisualStyleBackColor = true;
            this.loanPaymentManagmentBtn.Click += new System.EventHandler(this.loanPaymentManagmentBtn_Click);
            // 
            // transactionManagmentBtn
            // 
            this.transactionManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionManagmentBtn.Location = new System.Drawing.Point(852, 130);
            this.transactionManagmentBtn.Name = "transactionManagmentBtn";
            this.transactionManagmentBtn.Size = new System.Drawing.Size(165, 28);
            this.transactionManagmentBtn.TabIndex = 15;
            this.transactionManagmentBtn.Text = "Управление транзакциями";
            this.transactionManagmentBtn.UseVisualStyleBackColor = true;
            this.transactionManagmentBtn.Click += new System.EventHandler(this.transactionManagmentBtn_Click);
            // 
            // bankInfoBtn
            // 
            this.bankInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankInfoBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bankInfoBtn.Location = new System.Drawing.Point(852, 164);
            this.bankInfoBtn.Name = "bankInfoBtn";
            this.bankInfoBtn.Size = new System.Drawing.Size(165, 28);
            this.bankInfoBtn.TabIndex = 16;
            this.bankInfoBtn.Text = "Управление банками";
            this.bankInfoBtn.UseVisualStyleBackColor = true;
            this.bankInfoBtn.Click += new System.EventHandler(this.bankInfoBtn_Click);
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.bankInfoBtn);
            this.Controls.Add(this.transactionManagmentBtn);
            this.Controls.Add(this.loanPaymentManagmentBtn);
            this.Controls.Add(this.loanManagmentBtn);
            this.Controls.Add(this.employeeInfoBtn);
            this.Controls.Add(this.changeBtnPanel);
            this.Controls.Add(this.information);
            this.Controls.Add(this.cardManagmentBtn);
            this.Controls.Add(this.accountInfoBtn);
            this.Controls.Add(this.clientManagmentBtn);
            this.Controls.Add(this.usersName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usersCompany);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.HeadingPanel);
            this.Name = "mainFormAdmin";
            this.Text = "Bank";
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            this.changeBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label usersCompany;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label usersName;
        private System.Windows.Forms.Button clientManagmentBtn;
        private System.Windows.Forms.Button accountInfoBtn;
        private System.Windows.Forms.Button cardManagmentBtn;
        private System.Windows.Forms.DataGridView information;
        private System.Windows.Forms.Panel changeBtnPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateTableBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Button employeeInfoBtn;
        private System.Windows.Forms.Button loanManagmentBtn;
        private System.Windows.Forms.Button loanPaymentManagmentBtn;
        private System.Windows.Forms.Button transactionManagmentBtn;
        private System.Windows.Forms.Button bankInfoBtn;
    }
}