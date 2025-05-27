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
        private DateTimePicker dateDue;
        private TextBox txtSearch;
    }
}
