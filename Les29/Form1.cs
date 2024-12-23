using CsvHelper;
using CsvHelper.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Les29
{
    public partial class Form1 : Form
    {
        private List<Nakladnaya> records;
        private ListSortDirection direction;
        public Form1()
        {
            InitializeComponent();
            direction = ListSortDirection.Ascending;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Csv files(*.csv)|*.csv|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                CsvReader csvReader = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";",
                        HasHeaderRecord = false,
                        HeaderValidated = null
                    });
                records = csvReader.GetRecords<Nakladnaya>().ToList();
                reader.Close();
                records.RemoveAt(0);
                records.Sort();
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

        private void сохранитьXlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage newBook = new ExcelPackage(fileInfo);
                if (newBook.Workbook.Worksheets.Contains(newBook.Workbook.Worksheets["Продукты"]) == false)
                    newBook.Workbook.Worksheets.Add("Продукты");
                ExcelWorksheet worksheet = newBook.Workbook.Worksheets["Продукты"];
                worksheet.Cells[1, 1].Value = "Название";
                worksheet.Cells[1, 2].Value = "Количество";
                worksheet.Cells[1, 3].Value = "Цена";
                worksheet.Cells[1, 4].Value = "Поставщик";
                worksheet.Cells[1, 5].Value = "Получатель";
                worksheet.Cells[1, 6].Value = "Дата";
                for (int i = 0; i < records.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = records[i].Name;
                    worksheet.Cells[i + 2, 2].Value = records[i].Quantity;
                    worksheet.Cells[i + 2, 3].Value = records[i].Price;
                    worksheet.Cells[i + 2, 4].Value = records[i].Provider;
                    worksheet.Cells[i + 2, 5].Value = records[i].Recipient;
                    worksheet.Cells[i + 2, 6].Value = records[i].DateOrder;
                }
                newBook.SaveAs(fileInfo);
            }
        }

        private void dataGridViewTovar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(direction==ListSortDirection.Ascending) direction = ListSortDirection.Descending;
            else direction = ListSortDirection.Ascending;
            List<Nakladnaya> temp = new List<Nakladnaya>();
            switch (e.ColumnIndex)
            {
                case 0: 
                    { 
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.Name).ToList();
                        else
                            temp = records.OrderByDescending(p => p.Name).ToList();
                    }
                    break;
                case 1:
                    {
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.Quantity).ToList();
                        else
                            temp = records.OrderByDescending(p => p.Quantity).ToList();
                    }
                    break;
                case 2:
                    {
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.Price).ToList();
                        else
                            temp = records.OrderByDescending(p => p.Price).ToList();
                    }
                    break;
                case 3:
                    {
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.Provider).ToList();
                        else
                            temp = records.OrderByDescending(p => p.Provider).ToList();
                    }
                    break;
                case 4:
                    {
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.Recipient).ToList();
                        else
                            temp = records.OrderByDescending(p => p.Recipient).ToList();
                    }
                    break;
                case 5:
                    {
                        if (direction == ListSortDirection.Ascending)
                            temp = records.OrderBy(p => p.DateOrder).ToList();
                        else
                            temp = records.OrderByDescending(p => p.DateOrder).ToList();
                    }
                    break;
            }
            UpdateForm(temp);
        }
    }
}
