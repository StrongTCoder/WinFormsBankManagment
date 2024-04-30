
namespace InventoryManagementSystem
{
    partial class mainFormBanker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormBanker));
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.usersCompany = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.usersName = new System.Windows.Forms.Label();
            this.accountManagmentBtn = new System.Windows.Forms.Button();
            this.bankCardInfoBtn = new System.Windows.Forms.Button();
            this.tarnsactionManagmentBtn = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.DataGridView();
            this.changeBtnPanel = new System.Windows.Forms.Panel();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.clientInfoBtn = new System.Windows.Forms.Button();
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
            this.ProgramName.Location = new System.Drawing.Point(523, 9);
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
            this.usersCompany.Size = new System.Drawing.Size(87, 30);
            this.usersCompany.TabIndex = 3;
            this.usersCompany.Text = "Банкир";
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
            // accountManagmentBtn
            // 
            this.accountManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountManagmentBtn.Location = new System.Drawing.Point(55, 140);
            this.accountManagmentBtn.Name = "accountManagmentBtn";
            this.accountManagmentBtn.Size = new System.Drawing.Size(195, 43);
            this.accountManagmentBtn.TabIndex = 7;
            this.accountManagmentBtn.Text = "Управление счетами";
            this.accountManagmentBtn.UseVisualStyleBackColor = true;
            this.accountManagmentBtn.Click += new System.EventHandler(this.accountManagmentBtn_Click);
            // 
            // bankCardInfoBtn
            // 
            this.bankCardInfoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.bankCardInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankCardInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bankCardInfoBtn.Location = new System.Drawing.Point(451, 140);
            this.bankCardInfoBtn.Name = "bankCardInfoBtn";
            this.bankCardInfoBtn.Size = new System.Drawing.Size(195, 43);
            this.bankCardInfoBtn.TabIndex = 8;
            this.bankCardInfoBtn.Text = "Управление картами";
            this.bankCardInfoBtn.UseVisualStyleBackColor = true;
            this.bankCardInfoBtn.Click += new System.EventHandler(this.bankCardInfoBtn_Click);
            // 
            // tarnsactionManagmentBtn
            // 
            this.tarnsactionManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarnsactionManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarnsactionManagmentBtn.Location = new System.Drawing.Point(803, 140);
            this.tarnsactionManagmentBtn.Name = "tarnsactionManagmentBtn";
            this.tarnsactionManagmentBtn.Size = new System.Drawing.Size(214, 43);
            this.tarnsactionManagmentBtn.TabIndex = 9;
            this.tarnsactionManagmentBtn.Text = "Управление транзакциями";
            this.tarnsactionManagmentBtn.UseVisualStyleBackColor = true;
            this.tarnsactionManagmentBtn.Click += new System.EventHandler(this.transactionManagmentBtn_Click);
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
            this.saveBtn.Location = new System.Drawing.Point(861, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Добавить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(942, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // clientInfoBtn
            // 
            this.clientInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientInfoBtn.Location = new System.Drawing.Point(768, 80);
            this.clientInfoBtn.Name = "clientInfoBtn";
            this.clientInfoBtn.Size = new System.Drawing.Size(249, 43);
            this.clientInfoBtn.TabIndex = 12;
            this.clientInfoBtn.Text = "Информация о пользователях";
            this.clientInfoBtn.UseVisualStyleBackColor = true;
            this.clientInfoBtn.Click += new System.EventHandler(this.clientInfoBtn_Click);
            // 
            // mainFormBanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 635);
            this.Controls.Add(this.clientInfoBtn);
            this.Controls.Add(this.changeBtnPanel);
            this.Controls.Add(this.information);
            this.Controls.Add(this.tarnsactionManagmentBtn);
            this.Controls.Add(this.bankCardInfoBtn);
            this.Controls.Add(this.accountManagmentBtn);
            this.Controls.Add(this.usersName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usersCompany);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.HeadingPanel);
            this.Name = "mainFormBanker";
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
        private System.Windows.Forms.Button accountManagmentBtn;
        private System.Windows.Forms.Button bankCardInfoBtn;
        private System.Windows.Forms.Button tarnsactionManagmentBtn;
        private System.Windows.Forms.DataGridView information;
        private System.Windows.Forms.Panel changeBtnPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button updateTableBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Button clientInfoBtn;
    }
}