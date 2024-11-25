using OfficeOpenXml;
string filePath = "ListExcel.xlsx";
ExcelPackage.LicenseContext =
    LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(filePath);
ExcelWorksheet worksheet1 = 
    newBook.Workbook.Worksheets["Лист1"];
//newBook.Workbook.Worksheets.Add("Лист2");
//newBook.Save();
//ExcelWorksheet worksheet2 = 
//    newBook.Workbook.Worksheets["Лист2"];
//if(worksheet2!= null)
//{
//    newBook.Workbook.Worksheets.Delete(worksheet2);
//    newBook.Save();
//}
//worksheet1.Cells["A1"].Value = "FIO";
//worksheet1.Cells["B1"].Value = "Age";
//worksheet1.Cells["C1"].Value = "Weight";
//newBook.Save();
//List<Person> list = new List<Person>()
//{
//    new Person(){FIO="Иван Иванов", Age=23,Weight=78},
//    new Person(){FIO="Сергей Михеев", Age=19,Weight=67},
//    new Person(){FIO="Алексей Алексеев", Age=34,Weight=80},
//    new Person(){FIO="Михаил Семенов", Age=28,Weight=74}
//};
//int k = 2;
//for (int i = 0; i < list.Count; i++)
//{
//    worksheet1.Cells[k+i, 1].Value = list[i].FIO;
//    worksheet1.Cells[k+i, 2].Value = list[i].Age;
//    worksheet1.Cells[k+i, 3].Value = list[i].Weight;
//}
//newBook.Save();
Console.Write("Введите строку для поиска:");
string str=Console.ReadLine()!;
int row,column;
foreach(var cell in worksheet1.Cells)
{
    if (cell.Text == str)
    {
        row = cell.Start.Row; 
        column = cell.Start.Column;
        Console.WriteLine($"Значение {str}" +
            $" найдено в ячейке с " +
            $"координатами { row }:{ column }");
    }
}
class Person
{
    public string? FIO { get; set; }
    public int? Age { get; set; }
    public double? Weight { get; set; }
}








