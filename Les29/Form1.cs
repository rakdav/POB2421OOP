using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Les29
{
    public partial class Form1 : Form
    {
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
                    new CsvConfiguration(CultureInfo.InvariantCulture));
                List<Nakladnaya> records = csvReader.GetRecords<Nakladnaya>().ToList();
                reader.Close();
            }
        }
    }
}
