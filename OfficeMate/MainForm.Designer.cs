namespace OfficeMate
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPhoneInternal = new System.Windows.Forms.MaskedTextBox();
            this.txtPhonePersonal = new System.Windows.Forms.MaskedTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImportContacts = new System.Windows.Forms.Button();
            this.btnExportContacts = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.dataGridContacts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPhoneInternal);
            this.tabPage1.Controls.Add(this.txtPhonePersonal);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnSearchContact);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnImportContacts);
            this.tabPage1.Controls.Add(this.btnExportContacts);
            this.tabPage1.Controls.Add(this.btnDeleteContact);
            this.tabPage1.Controls.Add(this.btnEditContact);
            this.tabPage1.Controls.Add(this.btnAddContact);
            this.tabPage1.Controls.Add(this.dataGridContacts);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtPosition);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCompany);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMiddleName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Контакты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPhoneInternal
            // 
            this.txtPhoneInternal.Location = new System.Drawing.Point(9, 384);
            this.txtPhoneInternal.Mask = "0000";
            this.txtPhoneInternal.Name = "txtPhoneInternal";
            this.txtPhoneInternal.Size = new System.Drawing.Size(203, 22);
            this.txtPhoneInternal.TabIndex = 25;
            // 
            // txtPhonePersonal
            // 
            this.txtPhonePersonal.Location = new System.Drawing.Point(9, 340);
            this.txtPhonePersonal.Mask = "+7 (000) 000-00-00";
            this.txtPhonePersonal.Name = "txtPhonePersonal";
            this.txtPhonePersonal.Size = new System.Drawing.Size(203, 22);
            this.txtPhonePersonal.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(412, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(636, 31);
            this.txtSearch.TabIndex = 23;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchContact.Location = new System.Drawing.Point(1054, 23);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(94, 30);
            this.btnSearchContact.TabIndex = 22;
            this.btnSearchContact.Text = "Поиск";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Служебный Телефон";
            // 
            // btnImportContacts
            // 
            this.btnImportContacts.Location = new System.Drawing.Point(233, 21);
            this.btnImportContacts.Name = "btnImportContacts";
            this.btnImportContacts.Size = new System.Drawing.Size(94, 31);
            this.btnImportContacts.TabIndex = 19;
            this.btnImportContacts.Text = "Обновить";
            this.btnImportContacts.UseVisualStyleBackColor = true;
            // 
            // btnExportContacts
            // 
            this.btnExportContacts.Location = new System.Drawing.Point(118, 470);
            this.btnExportContacts.Name = "btnExportContacts";
            this.btnExportContacts.Size = new System.Drawing.Size(94, 38);
            this.btnExportContacts.TabIndex = 18;
            this.btnExportContacts.Text = "Сохранить";
            this.btnExportContacts.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(9, 470);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(94, 38);
            this.btnDeleteContact.TabIndex = 17;
            this.btnDeleteContact.Text = "Удалить";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(118, 426);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(94, 38);
            this.btnEditContact.TabIndex = 16;
            this.btnEditContact.Text = "Изменить";
            this.btnEditContact.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(9, 426);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(94, 38);
            this.btnAddContact.TabIndex = 15;
            this.btnAddContact.Text = "Добавить";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacts.Location = new System.Drawing.Point(233, 58);
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.RowHeadersWidth = 51;
            this.dataGridContacts.RowTemplate.Height = 24;
            this.dataGridContacts.Size = new System.Drawing.Size(920, 450);
            this.dataGridContacts.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Личный Телефон";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 287);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 31);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(9, 234);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(203, 31);
            this.txtPosition.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Должность";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(9, 181);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(203, 31);
            this.txtCompany.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Компания";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(9, 128);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(203, 31);
            this.txtMiddleName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(9, 75);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(9, 22);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 31);
            this.txtLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "OfficeMateApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnExportContacts;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.DataGridView dataGridContacts;
        private System.Windows.Forms.Button btnImportContacts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MaskedTextBox txtPhonePersonal;
        private System.Windows.Forms.MaskedTextBox txtPhoneInternal;
    }
}

