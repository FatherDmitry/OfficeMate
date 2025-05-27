using OfficeMate.Model;
using OfficeMate.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeMate.Controller
{
    public class ContactController
    {
        // Список контактов
        private List<Contact> contacts = new List<Contact>();

        private DataGridView dataGrid;
        private TextBox txtSearch;
        private TextBox txtFirstName, txtLastName, txtMiddleName, txtCompany, txtPosition, txtEmail;
        private MaskedTextBox txtPhonePersonal;
        private MaskedTextBox txtPhoneInternal;

        private readonly string defaultJsonPath = "OfficeMateContacts.json";
        private int editingIndex = -1;


        // // Обработчик выбора строки в таблице контактов
        public ContactController(DataGridView grid, TextBox searchBox,
            TextBox firstName, TextBox lastName, TextBox middleName, TextBox company,
            TextBox position, TextBox email, MaskedTextBox phonePersonal, MaskedTextBox phoneInternal)
        {
            dataGrid = grid;
            txtSearch = searchBox;
            txtFirstName = firstName;
            txtLastName = lastName;
            txtMiddleName = middleName;
            txtCompany = company;
            txtPosition = position;
            txtEmail = email;
            txtPhonePersonal = phonePersonal;
            txtPhoneInternal = phoneInternal;
        }

        // Кнопка <Добавить>
        public void OnAddContact(object sender, EventArgs e)
        {
            var newContact = GetContactFromFields();
            if (string.IsNullOrWhiteSpace(newContact.FirstName) || string.IsNullOrWhiteSpace(newContact.LastName))
            {
                MessageBox.Show("Пожалуйста, укажите как минимум имя и фамилию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contacts.Add(newContact);
            RefreshGrid();
            ClearFields();
        }

        // Кнопка <Изменить>
        public void OnEditContact(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= contacts.Count)
            {
                MessageBox.Show("Выберите контакт двойным щелчком для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updatedContact = GetContactFromFields();
            contacts[editingIndex] = updatedContact;
            RefreshGrid();
            ClearFields();
            editingIndex = -1;
        }

        // Кнопка <Удалить>
        public void OnDeleteContact(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите контакт для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGrid.SelectedRows[0].Index;
            if (index >= 0 && index < contacts.Count)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный контакт?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    contacts.RemoveAt(index);
                    RefreshGrid();
                    ClearFields();
                }
            }
        }

        // Кнопка <Поиск>
        public void OnSearchContact(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var filtered = contacts.Where(c =>
                (c.FirstName?.ToLower().Contains(query) ?? false) || (c.LastName?.ToLower().Contains(query) ?? false) ||
                (c.MiddleName?.ToLower().Contains(query) ?? false) || (c.Company?.ToLower().Contains(query) ?? false) ||
                (c.Position?.ToLower().Contains(query) ?? false) || (c.Email?.ToLower().Contains(query) ?? false) ||
                (c.PhonePersonal?.ToLower().Contains(query) ?? false) || (c.PhoneInternal?.ToLower().Contains(query) ?? false)).ToList();

            dataGrid.DataSource = null;
            dataGrid.DataSource = filtered;
        }

        // Загрузка контактов при открытии формы
        public void OnFormLoad()
        {
            contacts = ContactStorage.LoadContacts(defaultJsonPath); // Загрузка из JSON-файла
            RefreshGrid(); // Обновление таблицы
        }

        // Кнопка <Сохранить>
        public void OnExportContacts(object sender, EventArgs e)
        {
            ContactStorage.SaveContacts(contacts, defaultJsonPath);
            MessageBox.Show("Контакты успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Кнопка <Обновить>
        public void OnImportContacts(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(defaultJsonPath))
            {
                contacts = ContactStorage.LoadContacts(defaultJsonPath);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Логика выбора при двойном клика
        public void OnContactDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < contacts.Count)
            {
                Contact selectedContact = contacts[e.RowIndex];
                txtLastName.Text = selectedContact.LastName;
                txtFirstName.Text = selectedContact.FirstName;
                txtMiddleName.Text = selectedContact.MiddleName;
                txtCompany.Text = selectedContact.Company;
                txtPosition.Text = selectedContact.Position;
                txtEmail.Text = selectedContact.Email;
                txtPhonePersonal.Text = selectedContact.PhonePersonal;
                txtPhoneInternal.Text = selectedContact.PhoneInternal;

                editingIndex = e.RowIndex;
            }
        }

        private void RefreshGrid()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = contacts;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.MultiSelect = false;
            dataGrid.AllowUserToAddRows = false;
        }

        private void ClearFields()
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

    }
}
