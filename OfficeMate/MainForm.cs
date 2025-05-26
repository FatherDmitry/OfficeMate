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
        // Список контактов
        private List<Contact> contacts = new List<Contact>();

        private readonly string defaultJsonPath = "OfficeMateContacts.json";

        public MainForm()
        {

            InitializeComponent();

            // Подключение кнопок <Добавить>, <Изменить> и <Удалить>
            btnAddContact.Click += btnAddContact_Click;
            btnEditContact.Click += btnEditContact_Click;
            btnDeleteContact.Click += btnDeleteContact_Click;

            // Подключение двойного щелчка по строке таблицы
            dataGridContacts.CellDoubleClick += dataGridContacts_CellDoubleClick;

            btnSearchContact.Click += btnSearchContact_Click; // Подключение кнопки <Поиск>

            // Подключение кнопок <Сохранить> и <Обновить>
            btnExportContacts.Click += btnExportContacts_Click;
            btnImportContacts.Click += btnImportContacts_Click;

            // Подключение загрузки формы
            this.Load += MainForm_Load;
        }

        // Создание нового контакта
        private Contact GetContactFromFields()
        {
            return new Contact
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhonePersonal = txtPhonePersonal.Text.Trim(),
                PhoneInternal = txtPhoneInternal.Text.Trim()
            };
        }

        // Кнопака <Добавить>
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            var newContact = GetContactFromFields();

            // Простая проверка: хотя бы имя и фамилия
            if (string.IsNullOrWhiteSpace(newContact.FirstName) || string.IsNullOrWhiteSpace(newContact.LastName))
            {
                MessageBox.Show("Пожалуйста, укажите как минимум имя и фамилию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contacts.Add(newContact);
            RefreshContactGrid();
            ClearInputFields();
        }

        // Обработчик выбора строки в таблице контактов
        private void dataGridContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < contacts.Count)
            {
                Contact selectedContact = contacts[e.RowIndex];

                // Заполняем поля формы
                txtLastName.Text = selectedContact.LastName;
                txtFirstName.Text = selectedContact.FirstName;
                txtMiddleName.Text = selectedContact.MiddleName;
                txtCompany.Text = selectedContact.Company;
                txtPosition.Text = selectedContact.Position;
                txtEmail.Text = selectedContact.Email;
                txtPhonePersonal.Text = selectedContact.PhonePersonal;
                txtPhoneInternal.Text = selectedContact.PhoneInternal;

                // Сохраняем индекс выбранного контакта для редактирования
                editingIndex = e.RowIndex;
            }
        }

        // Индекс редактируемого контакта
        private int editingIndex = -1;

        // Кнопка <Изменить>
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= contacts.Count)
            {
                MessageBox.Show("Выберите контакт двойным щелчком для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updatedContact = GetContactFromFields();

            contacts[editingIndex] = updatedContact;

            RefreshContactGrid();
            ClearInputFields();
            editingIndex = -1; // сбрасываем режим редактирования
        }


        // Очистка полей ввода
        private void ClearInputFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCompany.Clear();
            txtPosition.Clear();
            txtEmail.Clear();
            txtPhonePersonal.Clear();
            txtPhoneInternal.Clear();
        }


        // Кнопка <Удалить>
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dataGridContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите контакт для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGridContacts.SelectedRows[0].Index;
            if (index >= 0 && index < contacts.Count)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный контакт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    contacts.RemoveAt(index);
                    RefreshContactGrid();
                    ClearInputFields();
                }
            }
        }


        // Кнопка <Поиск>
        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();

            var filtered = contacts.Where(c =>
                (c.FirstName?.ToLower().Contains(query) ?? false) ||
                (c.LastName?.ToLower().Contains(query) ?? false) ||
                (c.MiddleName?.ToLower().Contains(query) ?? false) ||
                (c.Company?.ToLower().Contains(query) ?? false) ||
                (c.Position?.ToLower().Contains(query) ?? false) ||
                (c.Email?.ToLower().Contains(query) ?? false) ||
                (c.PhonePersonal?.ToLower().Contains(query) ?? false) ||
                (c.PhoneInternal?.ToLower().Contains(query) ?? false)
            ).ToList();

            dataGridContacts.DataSource = null;
            dataGridContacts.DataSource = filtered;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        // Загрузка контактов при открытии формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            contacts = ContactStorage.LoadContacts(); // Загрузка из JSON-файла
            RefreshContactGrid(); // Обновление таблицы
        }

        // Метод обновления таблицы контактов
        private void RefreshContactGrid()
        {
            dataGridContacts.DataSource = null; // Очистка источника данных
            dataGridContacts.DataSource = contacts; // Повторное подключение списка контактов

            // Настройка внешнего вида таблицы
            dataGridContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridContacts.ReadOnly = true;
            dataGridContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridContacts.MultiSelect = false;
            dataGridContacts.AllowUserToAddRows = false;
        }

        // Кнопка <Сохранить>
        private void btnExportContacts_Click(object sender, EventArgs e)
        {
            ContactStorage.SaveContacts(contacts, defaultJsonPath);
            MessageBox.Show("Контакты успешно сохранены в файл по умолчанию.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Кнопка <Обновить>
        private void btnImportContacts_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(defaultJsonPath))
            {
                contacts = ContactStorage.LoadContacts(defaultJsonPath);
                RefreshContactGrid();
            }
            else
            {
                MessageBox.Show("Файл contacts.json не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}