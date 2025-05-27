using OfficeMate.Controller;
using OfficeMate.Model;
using OfficeMate.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeMate
{
    public partial class MainForm : Form
    {
        // Подключение контроля кнопок во вкладке "Контакты"
        private ContactController contactController;

        // Подключение контроля кнопок во вкладке "Задачи"
        private TaskController taskController;

        public MainForm()
        {

            InitializeComponent();

            contactController = new ContactController(
                dataGridContacts, txtSearch,
                txtFirstName, txtLastName, txtMiddleName, txtCompany,
                txtPosition, txtEmail, txtPhonePersonal, txtPhoneInternal
            );

            // Подключение кнопок <Добавить>, <Изменить> и <Удалить>
            btnAddContact.Click += contactController.OnAddContact;
            btnEditContact.Click += contactController.OnEditContact;
            btnDeleteContact.Click += contactController.OnDeleteContact;

            // Подключение двойного щелчка по строке таблицы
            dataGridContacts.CellDoubleClick += contactController.OnContactDoubleClick;

            btnSearchContact.Click += contactController.OnSearchContact; // Подключение кнопки <Поиск>

            // Подключение кнопок <Сохранить> и <Обновить>
            btnExportContacts.Click += contactController.OnExportContacts;
            btnImportContacts.Click += contactController.OnImportContacts;

            // Подключение загрузки формы
            this.Load += (s, e) => contactController.OnFormLoad();

            /////////////////___tabTasks____/////////////////
            taskController = new TaskController(
                dataGridTasks,
                txtTaskTitle,
                txtTaskDescription,
                cmbTaskStatus,
                dateTimeDue,
                txtSearchTask
            );

            // Подключение кнопки <Добавить задачу>
            btnAddTask.Click += taskController.OnAddTask;

            // Подключение кнопки <Изменить задачу>
            btnEditTask.Click += taskController.OnEditTask;

            // Подключение двойного щелчка по строке таблицы
            dataGridTasks.CellDoubleClick += taskController.OnTaskDoubleClick;

            // Подключение кнопки <Удалить задачу>
            btnDeleteTask.Click += taskController.OnDeleteTask;

            // Подключение <Поиска задачи>
            btnSearchTask.Click += taskController.OnSearchTask;

            btnExportTasks.Click += taskController.OnExportTasks; // Подключение <Сохранить список задач>
            btnImportTasks.Click += taskController.OnImportTasks; // Подключение <Обновить список задач>
        }

    }
}