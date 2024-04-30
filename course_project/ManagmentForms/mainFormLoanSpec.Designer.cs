
namespace InventoryManagementSystem
{
    partial class mainFormLoanSpec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormLoanSpec));
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.usersCompany = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.usersName = new System.Windows.Forms.Label();
            this.clientManagmentBtn = new System.Windows.Forms.Button();
            this.loanInfoBtn = new System.Windows.Forms.Button();
            this.loanpaymentManagmentBtn = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.DataGridView();
            this.changeBtnPanel = new System.Windows.Forms.Panel();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
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
            this.ProgramName.Location = new System.Drawing.Point(515, 9);
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
            this.usersCompany.Size = new System.Drawing.Size(267, 30);
            this.usersCompany.TabIndex = 3;
            this.usersCompany.Text = "Специалист по кредитам";
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
            this.clientManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientManagmentBtn.Location = new System.Drawing.Point(55, 140);
            this.clientManagmentBtn.Name = "clientManagmentBtn";
            this.clientManagmentBtn.Size = new System.Drawing.Size(209, 43);
            this.clientManagmentBtn.TabIndex = 7;
            this.clientManagmentBtn.Text = "Информация о клиентах";
            this.clientManagmentBtn.UseVisualStyleBackColor = true;
            this.clientManagmentBtn.Click += new System.EventHandler(this.clientManagmentBtn_Click);
            // 
            // loanInfoBtn
            // 
            this.loanInfoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.loanInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanInfoBtn.Location = new System.Drawing.Point(453, 140);
            this.loanInfoBtn.Name = "loanInfoBtn";
            this.loanInfoBtn.Size = new System.Drawing.Size(195, 43);
            this.loanInfoBtn.TabIndex = 8;
            this.loanInfoBtn.Text = "Управление кредитами";
            this.loanInfoBtn.UseVisualStyleBackColor = true;
            this.loanInfoBtn.Click += new System.EventHandler(this.loanInfoBtn_Click);
            // 
            // loanpaymentManagmentBtn
            // 
            this.loanpaymentManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanpaymentManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanpaymentManagmentBtn.Location = new System.Drawing.Point(822, 140);
            this.loanpaymentManagmentBtn.Name = "loanpaymentManagmentBtn";
            this.loanpaymentManagmentBtn.Size = new System.Drawing.Size(195, 43);
            this.loanpaymentManagmentBtn.TabIndex = 9;
            this.loanpaymentManagmentBtn.Text = "Управление платежами";
            this.loanpaymentManagmentBtn.UseVisualStyleBackColor = true;
            this.loanpaymentManagmentBtn.Click += new System.EventHandler(this.loanpaymentManagmentBtn_Click);
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
            this.changeBtnPanel.Location = new System.Drawing.Point(0, 570);
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
            this.saveBtn.Location = new System.Drawing.Point(780, 0);
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
            this.editBtn.Location = new System.Drawing.Point(861, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // mainFormLoanSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.changeBtnPanel);
            this.Controls.Add(this.information);
            this.Controls.Add(this.loanpaymentManagmentBtn);
            this.Controls.Add(this.loanInfoBtn);
            this.Controls.Add(this.clientManagmentBtn);
            this.Controls.Add(this.usersName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usersCompany);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.HeadingPanel);
            this.Name = "mainFormLoanSpec";
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
        private System.Windows.Forms.Button loanInfoBtn;
        private System.Windows.Forms.Button loanpaymentManagmentBtn;
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
    }
}