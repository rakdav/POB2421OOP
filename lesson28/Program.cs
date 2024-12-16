using Word = Microsoft.Office.Interop.Word;
Word.Application wordApp = new Word.Application();
Word.Document doc = wordApp.Documents.Open(@"C:\Users\C5PCT\Downloads\forma.docx");
Word.Range range = doc.Content;
int count=doc.Sections.Count;
Word.Range selRange = doc.Sections[1].Range;

range.Find.Execute(DateTime.Now.ToShortDateString(), ReplaceWith:
DateTime.Now.ToShortDateString());
selRange.Font.Bold = 1;
//doc.Content.Delete();
//AddNewTable(3, 7, "first",doc);
//AddNewTable(9, 5, "second", doc);
//Table table = doc.Tables[1];
//Random rnd = new Random();
//foreach (Row row in table.Rows)
//{
//    foreach (Cell cell in row.Cells)
//    {
//        cell.Range.Text = rnd.Next(1, 100).ToString();
//    }
//}
//table.Rows.Add();
//table.Columns.Add();
doc.Save();
doc.Close();
wordApp.Quit();
void AddNewTable(int rows,int colomns,string tableName, Word.Document doc)
{
    Word.Paragraph paragraph = doc.Paragraphs.Add();
    paragraph.Range.Text= $"\r{tableName}\n";
    Word.Table table = doc.Tables.Add(paragraph.Range, NumRows: rows, NumColumns: colomns);
    table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDot;
    table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDot;
    table.Borders.OutsideColor = Word.WdColor.wdColorDarkRed;
    table.Borders.InsideColor = Word.WdColor.wdColorDarkRed;
    table.Cell(1, 1).Range.Text = "Ячейка 1-1";
    table.Cell(1, 2).Range.Text = "Ячейка 1-2";
}

