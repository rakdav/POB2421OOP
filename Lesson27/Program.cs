using Word = Microsoft.Office.Interop.Word;
Word.Application wordApp=new Word.Application();
//Word.Document wordDoc=wordApp.Documents.Add();
Word.Document wordDoc= wordApp.Documents.Open(@"C:\Users\C5PCT\first.docx");
Word.Paragraph para1 = wordDoc.Paragraphs.Add();
//para1.Range.Text = "Это первый текстовый блок. \n";
//Word.Paragraph para2 = wordDoc.Paragraphs.Add();
//para2.Range.Text = "Это второй текстовый блок. \n";
//Word.Paragraph para3 = wordDoc.Paragraphs.Add();
//para3.Range.Text = "Это третий текстовый блок.";
Word.Range range = wordDoc.Content;
//range.Find.Execute("Это второй текстовый блок.", ReplaceWith:
//"Замененный параграф");
//range.Font.Name = "Arial"; // Определяем шрифт 
//range.Font.Size = 14; // Размер шрифта 
//range.Font.Bold = 1; // Жирный текст 
//range.Font.Color = Word.WdColor.wdColorRed; // Красный цвет 

//Word.Paragraph heading = wordDoc.Paragraphs.Add();
//heading.Range.Font.Name = "Times New Roman";
//heading.Range.Font.Color = Word.WdColor.wdColorOliveGreen;
//heading.Range.Font.Size = 18;
//heading.Range.Text = "Замененный параграф";
range.ParagraphFormat.Alignment =
Word.WdParagraphAlignment.wdAlignParagraphJustify;
wordDoc.SaveAs(@"C:\Users\C5PCT\first.docx");
wordDoc.Close();
wordApp.Quit();