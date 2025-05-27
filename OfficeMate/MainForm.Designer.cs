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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContact = new System.Windows.Forms.TabPage();
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
            this.tabTask = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTaskStatus = new System.Windows.Forms.ComboBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeDue = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.dataGridTasks = new System.Windows.Forms.DataGridView();
            this.txtSearchTask = new System.Windows.Forms.TextBox();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.calendarTask = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.tabTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Controls.Add(this.tabTask);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.txtPhoneInternal);
            this.tabContact.Controls.Add(this.txtPhonePersonal);
            this.tabContact.Controls.Add(this.txtSearch);
            this.tabContact.Controls.Add(this.btnSearchContact);
            this.tabContact.Controls.Add(this.label8);
            this.tabContact.Controls.Add(this.btnImportContacts);
            this.tabContact.Controls.Add(this.btnExportContacts);
            this.tabContact.Controls.Add(this.btnDeleteContact);
            this.tabContact.Controls.Add(this.btnEditContact);
            this.tabContact.Controls.Add(this.btnAddContact);
            this.tabContact.Controls.Add(this.dataGridContacts);
            this.tabContact.Controls.Add(this.label7);
            this.tabContact.Controls.Add(this.txtEmail);
            this.tabContact.Controls.Add(this.label6);
            this.tabContact.Controls.Add(this.txtPosition);
            this.tabContact.Controls.Add(this.label5);
            this.tabContact.Controls.Add(this.txtCompany);
            this.tabContact.Controls.Add(this.label4);
            this.tabContact.Controls.Add(this.txtMiddleName);
            this.tabContact.Controls.Add(this.label3);
            this.tabContact.Controls.Add(this.txtFirstName);
            this.tabContact.Controls.Add(this.label2);
            this.tabContact.Controls.Add(this.txtLastName);
            this.tabContact.Controls.Add(this.label1);
            this.tabContact.Location = new System.Drawing.Point(4, 25);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(1104, 516);
            this.tabContact.TabIndex = 0;
            this.tabContact.Text = "Контакты";
            this.tabContact.UseVisualStyleBackColor = true;
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
            this.txtSearch.Size = new System.Drawing.Size(584, 31);
            this.txtSearch.TabIndex = 23;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchContact.Location = new System.Drawing.Point(1002, 23);
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
            this.dataGridContacts.Size = new System.Drawing.Size(868, 450);
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
            // tabTask
            // 
            this.tabTask.Controls.Add(this.calendarTask);
            this.tabTask.Controls.Add(this.btnSearchTask);
            this.tabTask.Controls.Add(this.txtSearchTask);
            this.tabTask.Controls.Add(this.dataGridTasks);
            this.tabTask.Controls.Add(this.btnDeleteTask);
            this.tabTask.Controls.Add(this.btnEditTask);
            this.tabTask.Controls.Add(this.btnAddTask);
            this.tabTask.Controls.Add(this.label12);
            this.tabTask.Controls.Add(this.dateTimeDue);
            this.tabTask.Controls.Add(this.label11);
            this.tabTask.Controls.Add(this.cmbTaskStatus);
            this.tabTask.Controls.Add(this.txtTaskDescription);
            this.tabTask.Controls.Add(this.label10);
            this.tabTask.Controls.Add(this.txtTaskTitle);
            this.tabTask.Controls.Add(this.label9);
            this.tabTask.Location = new System.Drawing.Point(4, 25);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(1104, 516);
            this.tabTask.TabIndex = 1;
            this.tabTask.Text = "Задачи";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Статус";
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.FormattingEnabled = true;
            this.cmbTaskStatus.Items.AddRange(new object[] {
            "Выполняется",
            "Под вопросом",
            "Завершено"});
            this.cmbTaskStatus.Location = new System.Drawing.Point(9, 274);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(160, 24);
            this.cmbTaskStatus.TabIndex = 4;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(9, 77);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(412, 175);
            this.txtTaskDescription.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Описание задачи";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(9, 22);
            this.txtTaskTitle.Multiline = true;
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(412, 33);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Задача";
            // 
            // dateTimeDue
            // 
            this.dateTimeDue.Location = new System.Drawing.Point(211, 276);
            this.dateTimeDue.Name = "dateTimeDue";
            this.dateTimeDue.Size = new System.Drawing.Size(192, 22);
            this.dateTimeDue.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Срок выполнения";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(9, 319);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(92, 34);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(107, 319);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(92, 34);
            this.btnEditTask.TabIndex = 9;
            this.btnEditTask.Text = "Изменить";
            this.btnEditTask.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(54, 359);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(92, 34);
            this.btnDeleteTask.TabIndex = 10;
            this.btnDeleteTask.Text = "Удалить";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // dataGridTasks
            // 
            this.dataGridTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTasks.Location = new System.Drawing.Point(437, 58);
            this.dataGridTasks.Name = "dataGridTasks";
            this.dataGridTasks.RowHeadersWidth = 51;
            this.dataGridTasks.RowTemplate.Height = 24;
            this.dataGridTasks.Size = new System.Drawing.Size(659, 450);
            this.dataGridTasks.TabIndex = 11;
            // 
            // txtSearchTask
            // 
            this.txtSearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTask.Location = new System.Drawing.Point(437, 22);
            this.txtSearchTask.Multiline = true;
            this.txtSearchTask.Name = "txtSearchTask";
            this.txtSearchTask.Size = new System.Drawing.Size(561, 33);
            this.txtSearchTask.TabIndex = 12;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTask.Location = new System.Drawing.Point(1004, 22);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(92, 34);
            this.btnSearchTask.TabIndex = 13;
            this.btnSearchTask.Text = "Поиск";
            this.btnSearchTask.UseVisualStyleBackColor = true;
            // 
            // calendarTask
            // 
            this.calendarTask.Location = new System.Drawing.Point(211, 301);
            this.calendarTask.Name = "calendarTask";
            this.calendarTask.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 545);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OfficeMateApp";
            this.tabControl1.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.tabTask.ResumeLayout(false);
            this.tabTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TabPage tabTask;
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
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTaskStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeDue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.TextBox txtSearchTask;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.MonthCalendar calendarTask;
    }
}

