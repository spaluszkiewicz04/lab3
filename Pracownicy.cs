using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab3
{
    public partial class Pracownicy : Form
    {
        private DataTable dataTable;
        private BindingSource bindingSource1 = new BindingSource();

        public Pracownicy()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dataTable = new DataTable();

            DataColumn idColumn = new DataColumn("ID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            dataTable.Columns.Add(idColumn);
            dataTable.Columns.Add("Imię", typeof(string));
            dataTable.Columns.Add("Nazwisko", typeof(string));
            dataTable.Columns.Add("Wiek", typeof(int));
            dataTable.Columns.Add("Stanowisko", typeof(string));

            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            using (var form = new Dodaj())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataTable.Rows.Add(null, form.Imie, form.Nazwisko, form.Wiek, form.Stanowisko);
                }
            }
        }

        private void BtnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void BtnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Zapisz";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            string[] headers = dataGridView.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText).ToArray();
            string csvContent = string.Join(",", headers) + Environment.NewLine;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value?.ToString() ?? "")) + Environment.NewLine;
                }
            }
            File.WriteAllText(filePath, csvContent);
        }

        private void BtnOdczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wczytaj";

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("404", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0) return;

            DataTable newDataTable = new DataTable();

            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                newDataTable.Columns.Add(header);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                newDataTable.Rows.Add(values);
            }

            dataTable = newDataTable;
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}