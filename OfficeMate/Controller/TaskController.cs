using OfficeMate.Model;
using OfficeMate.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OfficeMate.Controller
{
    public class TaskController
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        private readonly string defaultJsonPath = "OfficeMateTasks.json";

        private DataGridView dataGrid;
        private TextBox txtTitle, txtDescription;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimeDue;
        private TextBox txtSearch;

        public TaskController(
        DataGridView grid,
        TextBox title,
        TextBox description,
        ComboBox status,
        DateTimePicker dueDate,
        TextBox searchBox)
        {
            dataGrid = grid;
            txtTitle = title;
            txtDescription = description;
            cmbStatus = status;
            dateTimeDue = dueDate;
            txtSearch = searchBox;
        }


        // Кнопка <Добавить Задачу>
        public void OnAddTask(object sender, EventArgs e)
        {
            var newTask = GetTaskFromFields();

            if (string.IsNullOrWhiteSpace(newTask.Title))
            {
                MessageBox.Show("Пожалуйста, укажите название задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tasks.Add(newTask);
            RefreshGrid();
            ClearFields();
        }

        private TaskItem GetTaskFromFields()
        {
            return new TaskItem
            {
                Title = txtTitle.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Открыта",
                DueDate = dateTimeDue.Value.Date
            };
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            dateTimeDue.Value = DateTime.Today;
        }

        private void RefreshGrid()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = tasks;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.MultiSelect = false;
            dataGrid.AllowUserToAddRows = false;
        }

        // Поле для редактирования задачи
        private int editingIndex = -1;

        // Выбор задачи при двойном нажатии
        public void OnTaskDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tasks.Count)
            {
                var selectedTask = tasks[e.RowIndex];
                txtTitle.Text = selectedTask.Title;
                txtDescription.Text = selectedTask.Description;
                cmbStatus.SelectedItem = selectedTask.Status;
                dateTimeDue.Value = selectedTask.DueDate;

                editingIndex = e.RowIndex;
            }
        }

        // Кнопка <Изменить Задачу>
        public void OnEditTask(object sender, EventArgs e)
        {
            if (editingIndex < 0 || editingIndex >= tasks.Count)
            {
                MessageBox.Show("Выберите задачу двойным щелчком для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updatedTask = GetTaskFromFields();
            tasks[editingIndex] = updatedTask;
            RefreshGrid();
            ClearFields();
            editingIndex = -1;
        }

        // Кнопка <Удалить Задачу>
        public void OnDeleteTask(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGrid.SelectedRows[0].Index;
            if (index >= 0 && index < tasks.Count)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную задачу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tasks.RemoveAt(index);
                    RefreshGrid();
                    ClearFields();
                    editingIndex = -1;
                }
            }
        }

        // Кнопка <Поиск Задачи>
        public void OnSearchTask(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();

            var filtered = tasks.Where(task =>
                (task.Title?.ToLower().Contains(query) ?? false) || (task.Description?.ToLower().Contains(query) ?? false) ||
                (task.Status?.ToLower().Contains(query) ?? false)
            ).ToList();

            dataGrid.DataSource = null;
            dataGrid.DataSource = filtered;
        }

        // Кнопка <Сохранить список Задач в JSON>
        public void OnExportTasks(object sender, EventArgs e)
        {
            TaskStorage.SaveTasks(tasks, defaultJsonPath);
            MessageBox.Show("Задачи успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Кнопка <Обновить список Задач из JSON>
        public void OnImportTasks(object sender, EventArgs e)
        {
            if (File.Exists(defaultJsonPath))
            {
                tasks = TaskStorage.LoadTasks(defaultJsonPath);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Файл задач не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
