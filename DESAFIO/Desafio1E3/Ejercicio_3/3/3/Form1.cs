using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();
        private List<Task> completedTasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de tarea válido.");
                return;
            }

            if (dtpDueDate.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha límite no puede ser una fecha pasada.");
                return;
            }

            Task newTask = new Task { Name = txtTaskName.Text, DueDate = dtpDueDate.Value };
            tasks.Add(newTask);
            UpdateTaskList();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Task selectedTask = (Task)listView1.SelectedItems[0].Tag;
                tasks.Remove(selectedTask);
                UpdateTaskList();
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Task selectedTask = (Task)listView1.SelectedItems[0].Tag;
                selectedTask.Name = txtTaskName.Text;
                selectedTask.DueDate = dtpDueDate.Value;
                UpdateTaskList();
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Task selectedTask = (Task)listView1.SelectedItems[0].Tag;
                tasks.Remove(selectedTask);
                completedTasks.Add(selectedTask);
                UpdateTaskList();
                UpdateCompletedTaskList();
            }
        }

        private void UpdateTaskList()
        {
            listView1.Items.Clear();
            foreach (var task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                item.Tag = task;
                listView1.Items.Add(item);
            }
        }

        private void UpdateCompletedTaskList()
        {
            lstCompletedTasks.Items.Clear();
            foreach (var task in completedTasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.DueDate.ToShortDateString());
                item.Tag = task;
                lstCompletedTasks.Items.Add(item);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksToFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        private void SaveTasksToFile()
        {
            using (StreamWriter writer = new StreamWriter("tasks.tx"))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Name}|{task.DueDate}");
                }
            }

            using (StreamWriter writer = new StreamWriter("completedTasks.txt"))
            {
                foreach (var task in completedTasks)
                {
                    writer.WriteLine($"{task.Name}|{task.DueDate}");
                }
            }
        }

        private void LoadTasksFromFile()
        {
            if (File.Exists("tasks.txt"))
            {
                using (StreamReader reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        tasks.Add(new Task { Name = parts[0], DueDate = DateTime.Parse(parts[1]) });
                    }
                }
            }

            if (File.Exists("completedTasks.txt"))
            {
                using (StreamReader reader = new StreamReader("completedTasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        completedTasks.Add(new Task { Name = parts[0], DueDate = DateTime.Parse(parts[1]) });
                    }
                }
            }

            UpdateTaskList();
            UpdateCompletedTaskList();
            {
                lstCompletedTasks.Items.Clear();
                foreach (var task in completedTasks)
                {
                    ListViewItem item = new ListViewItem(task.Name);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    item.Tag = task;
                    item.Checked = true; // Esto añade un CheckBox
                    lstCompletedTasks.Items.Add(item);
                }
            }

        }


        public class Task
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Display => $"{Name} - {DueDate.ToShortDateString()}";
    }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Habilitar los botones de Editar, Eliminar y Marcar como Completada
                btnEditTask.Enabled = true;
                btnDeleteTask.Enabled = true;
                btnCompleteTask.Enabled = true;
            }
            else
            {
                // Deshabilitar los botones si no hay elementos seleccionados
                btnEditTask.Enabled = false;
                btnDeleteTask.Enabled = false;
                btnCompleteTask.Enabled = false;
            }
        }

        private void lstCompletedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
