using CsvHelper;
using CsvHelper.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
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
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                records = records.GroupBy(d => new { d.Name, d.Provider, d.Recipient, d.DateOrder, d.Price })
                    .Select(g => new Nakladnaya()
                    {
                        Name = g.Key.Name,
                        Provider = g.Key.Provider,
                        Recipient = g.Key.Recipient,
                        DateOrder = g.Key.DateOrder,
                        Price = g.Key.Price,
                        Quantity = g.Sum(d => d.Quantity)
                    }).ToList();
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

        private void ���������XlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage newBook = new ExcelPackage(fileInfo);
                if (newBook.Workbook.Worksheets.Contains(newBook.Workbook.Worksheets["��������"]) == false)
                    newBook.Workbook.Worksheets.Add("��������");
                ExcelWorksheet worksheet = newBook.Workbook.Worksheets["��������"];
                worksheet.Cells[1, 1].Value = "��������";
                worksheet.Cells[1, 2].Value = "����������";
                worksheet.Cells[1, 3].Value = "����";
                worksheet.Cells[1, 4].Value = "���������";
                worksheet.Cells[1, 5].Value = "����������";
                worksheet.Cells[1, 6].Value = "����";
                for (int i = 0; i < records.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = records[i].Name;
                    worksheet.Cells[i + 2, 2].Value = records[i].Quantity;
                    worksheet.Cells[i + 2, 3].Value = records[i].Price;
                    worksheet.Cells[i + 2, 4].Value = records[i].Provider;
                    worksheet.Cells[i + 2, 5].Value = records[i].Recipient;
                    worksheet.Cells[i + 2, 6].Value = Convert.ToDateTime(records[i].DateOrder);
                }
                newBook.SaveAs(fileInfo);
            }
        }

        private void dataGridViewTovar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (direction == ListSortDirection.Ascending) direction = ListSortDirection.Descending;
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

        private void buttonWord_Click(object sender, EventArgs e)
        {
            if (dataGridViewTovar.SelectedRows.Count != 0)
            {
                int index=dataGridViewTovar.CurrentRow.Index;
                Nakladnaya current = records[index];
                Word.Application wordApp = new Word.Application();
                string path = Environment.CurrentDirectory + @"\�������� ���������.docx";
                Word.Document doc = wordApp.Documents.Open(path);
                Word.Range range = doc.Content;
                range.Find.Execute("�����", ReplaceWith:(index+1).ToString());
                range = doc.Content;
                range.Find.Execute("����", ReplaceWith:current.DateOrder);
                range = doc.Content;
                range.Find.Execute("��� ����������", ReplaceWith: current.Provider);
                range = doc.Content;
                range.Find.Execute("��� ����������", ReplaceWith: current.Recipient);
                range = doc.Content;
                range.Find.Execute("�����_��������", ReplaceWith: "������ ��������");
                range = doc.Content;
                range.Find.Execute("�����_�����1", ReplaceWith:current.Price*current.Quantity);
                range = doc.Content;
                range.Find.Execute("���-��", current.Quantity);
                range = doc.Content;
                range.Find.Execute("c����_�����2", ReplaceWith: current.Price * current.Quantity);
                doc.SaveAs(Environment.CurrentDirectory +$"\\��������� {index+1}.docx");
                if (File.Exists(Environment.CurrentDirectory + $"\\��������� {index + 1}.docx"))
                    MessageBox.Show("��������� ������� �������!");
                doc.Close();
                wordApp.Quit();
            }
            else
            {
                MessageBox.Show("�������� ������!");
            }
        }
    }
}
