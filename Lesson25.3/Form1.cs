using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace Lesson25._3
{
    public partial class Form1 : Form
    {
        private List<Inventory> records;
        public Form1()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("inventoryControl.csv");
            CsvReader csvReader = new CsvReader(reader,
                new CsvConfiguration(CultureInfo.InvariantCulture));
            records = csvReader.GetRecords<Inventory>().ToList();
            reader.Close();
            UpdateForm(records);
            comboBoxFilter.SelectedIndex = 0;
        }
        private void UpdateForm(List<Inventory> list)
        {
            dataGridViewInentors.DataSource = null;
            dataGridViewInentors.DataSource = list;
            for (int i = 0; i < dataGridViewInentors.Columns.Count; i++)
            {
                dataGridViewInentors.Columns[i].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewInentors.Columns[i].ReadOnly = true;
            }
            toolStripStatusLabelCount.Text = "Количество записей:"
                + records.Count.ToString();
        }
        private void dataGridViewInentors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInentors.SelectedRows.Count > 0)
            {
                int index = dataGridViewInentors.SelectedRows[0].Index;
                textBoxCount.Text = records[index].Quantity.ToString();
                textBoxName.Text = records[index].Name;
                textBoxPrice.Text = records[index].Price.ToString();
                textBoxDesc.Text = records[index].Description;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Name = textBoxName.Text;
            inventory.Quantity = int.Parse(textBoxCount.Text);
            inventory.Price = decimal.Parse(textBoxPrice.Text);
            inventory.Description = textBoxDesc.Text;
            records.Add(inventory);
            UpdateForm(records);
        }

        private void сохранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("inventoryControl.csv");
            CsvWriter csvWriter = new CsvWriter(writer,
               new CsvConfiguration(CultureInfo.InvariantCulture));
            csvWriter.WriteRecords(records);
            writer.Close();
            MessageBox.Show("Файл успешно сохранен!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewInentors.SelectedRows.Count > 0)
            {
                int index = dataGridViewInentors.SelectedRows[0].Index;
                records[index].Quantity = int.Parse(textBoxCount.Text);
                records[index].Name = textBoxName.Text;
                records[index].Price = decimal.Parse(textBoxPrice.Text);
                records[index].Description = textBoxDesc.Text;
                UpdateForm(records);
            }
        }

        private void dataGridViewInentors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewInentors.SelectedRows.Count > 0)
                {
                    int index = dataGridViewInentors.SelectedRows[0].Index;
                    records.RemoveAt(index);
                    UpdateForm(records);
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length != 0)
            {
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Name!.StartsWith(textBoxSearch.Text)).ToList();
                            UpdateForm(list);
                        }
                        break;
                    case 1:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Quantity==int.Parse(textBoxSearch.Text)).ToList();
                            UpdateForm(list);
                        }
                        break;
                    case 2:
                        {
                            List<Inventory> list = records.
                                Where(p => p.Price == int.Parse(textBoxSearch.Text)).ToList();
                            UpdateForm(list);
                        }
                        break;
                }
            }
            else UpdateForm(records);
        }
    }
}
