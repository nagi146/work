using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GenealogyTree : Form
    {
        List<Person> people = new List<Person>();

        public GenealogyTree()
        {
            InitializeComponent();
        }

        // виклик форми
        private string ShowInputDialog(string title, string prompt)
        {
            using (var dialog = new InputDialog(title, prompt))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.InputText;
            }
            return null;
        }

        // виведення дерева
        private void BuildTree(TreeNode node, Person person)
        {
            foreach (var parent in person.Parents)
            {
                TreeNode parentNode = new TreeNode($"{parent.Name} {parent.Surname} (дата нар. {parent.BirthDate})");
                node.Nodes.Add(parentNode);
                BuildTree(parentNode, parent);
            }
        }

        // запис вузлів
        private void WriteNodeToFile(TreeNode node, StreamWriter writer, int indentLevel)
        {
            string indent = new string('\t', indentLevel);
            writer.WriteLine(indent + node.Text);

            foreach (TreeNode child in node.Nodes)
            {
                WriteNodeToFile(child, writer, indentLevel + 1);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string birthDate = mtxtBirthDate.Text;

            // перевірка що все введено
            if (name == "" || surname == "")
            {
                MessageBox.Show("Будь ласка, введіть ім’я та прізвище.");
                return;
            }

            people.Add(new Person(name, surname, birthDate)); // додаємо людину 
            listPeople.Items.Add($"{name} {surname}"); // виводимо людину в listBox
            txtName.Clear();
            txtSurname.Clear();
            mtxtBirthDate.Clear();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            if (listPeople.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть людину зі списку.");
                return;
            }

            string childName = listPeople.SelectedItem.ToString();
            var child = people.First(p => $"{p.Name} {p.Surname}" == childName);

            string parentName = ShowInputDialog("Додати батька/матір", "Введіть ім’я та прізвище батька/матері:"); // виведення ім'я форми та такст

            var parent = people.FirstOrDefault(p => $"{p.Name} {p.Surname}" == parentName);
            if (parent != null)
            {
                child.Parents.Add(parent);
                MessageBox.Show("Батько/матір додано.");
            }
            else
            {
                MessageBox.Show("Людину не знайдено.");
            }
        }

        private void btnShowTree_Click(object sender, EventArgs e)
        {
            treevFamily.Nodes.Clear();

            string targetName = ShowInputDialog("Генеалогічне дерево", "Введіть ім’я та прізвище людини:");
            var person = people.FirstOrDefault(p => $"{p.Name} {p.Surname}" == targetName);

            if (person != null)
            {
                TreeNode r = new TreeNode($"{person.Name} {person.Surname} (дата нар. {person.BirthDate})");
                treevFamily.Nodes.Add(r);
                BuildTree(r, person);

                treevFamily.ExpandAll();
            }
        }

        private void btnSaveTree_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстові файли (*.txt)|*.txt";
            saveFileDialog1.Title = "Зберегти TreeView у файл";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (TreeNode node in treevFamily.Nodes)
                    {
                        WriteNodeToFile(node, writer, 0);
                    }
                }

                MessageBox.Show("TreeView успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}