using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Les29
{
    public partial class Form1 : Form
    {
        private List<Nakladnaya> records;
        public Form1()
        {
            InitializeComponent();
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "Csv files(*.csv)|*.csv|All files(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                CsvReader csvReader = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false,
                        HeaderValidated = null
                    });
                records = csvReader.GetRecords<Nakladnaya>().ToList();
                reader.Close();
                records.RemoveAt(0);
                UpdateForm(records);
            }
        }
        private void UpdateForm(List<Nakladnaya> list)
        {
            dataGridViewTovar.DataSource = list;
            for (int i = 0; i < dataGridViewTovar.Columns.Count; i++)
            {
                dataGridViewTovar.Columns[i].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
