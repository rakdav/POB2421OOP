using OfficeOpenXml;
using System.ComponentModel;

Tovar[] mas =
{
    new Tovar("Обои виниловые",TypeOfTovar.Строительство,
    150,3),
    new Tovar("Обои флизелиновые",TypeOfTovar.Строительство,
    250,5),
    new Tovar("Обои бумажные",TypeOfTovar.Строительство,
    100,2),
    new Tovar("Обои жидкие",TypeOfTovar.Строительство,
    90,10),
    new Tovar("Штукатурка “Соседи не услышат",TypeOfTovar.Строительство,
    120,15),
    new Tovar("Шпатлевка \"Сладко да гладко\"",TypeOfTovar.Строительство,
    34,12),
    new Tovar("Дрель \"Буровик 3000\"",TypeOfTovar.Электроинструмент,
    250,5),
    new Tovar("Молоток \"Тор\"",TypeOfTovar.Электроинструмент,
    250,5),
    new Tovar("Сок апельсиновый",TypeOfTovar.Напитки,
    23,500),
    new Tovar("Чипсы со вкусом зелени",TypeOfTovar.Закуска,
    2,245)
};
FileInfo fileInfo = new FileInfo("МагазинМечты.xlsx");
if(!fileInfo.Exists)fileInfo.Create();
ExcelPackage.LicenseContext =
    OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage("МагазинМечты.xlsx");
newBook.Workbook.Worksheets.Add("Складской учет");
ExcelWorksheet worksheet =
    newBook.Workbook.Worksheets["Складской учет"];
worksheet.Cells["A1"].Value = "Наименование";
worksheet.Cells["B1"].Value = "Тип товара";
worksheet.Cells["C1"].Value = "Стоимость";
worksheet.Cells["D1"].Value = "Количество";
for (int i = 0; i < mas.Length; i++)
{
    worksheet.Cells[2 + i, 1].Value = mas[i].Name;
    worksheet.Cells[2 + i, 2].Value = mas[i].TypeOfTovar;
    worksheet.Cells[2 + i, 3].Value = mas[i].Price;
    worksheet.Cells[2 + i, 4].Value = mas[i].Count;
}
newBook.Save();
newBook.SaveAs(fileInfo);
class Tovar
{
    public string? Name { get; set; }
    public TypeOfTovar TypeOfTovar { get; set; }
    public decimal Price {  get; set; } 
    public int Count {  get; set; }

    public Tovar(string? name, TypeOfTovar typeOfTovar,
        decimal price, int count)
    {
        Name = name;
        TypeOfTovar = typeOfTovar;
        Price = price;
        Count = count;
    }
}
enum TypeOfTovar
{
    Канцелярия,
    Молочная,
    Закуска,
    Электроинструмент,
    Напитки,
    Строительство
}