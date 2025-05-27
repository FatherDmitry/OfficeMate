using OfficeMate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeMate.Controller
{
    public class TaskController
    {
        private List<TaskItem> tasks = new List<TaskItem>();

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
    }
}
