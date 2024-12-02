using Lesson23._2;
using OfficeOpenXml;
using System.Diagnostics;
using System.Xml.Linq;

int currentRow = 2;
string? filePath = "products.xlsx";
ExcelPackage.LicenseContext =
    OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage package = new ExcelPackage(filePath);
ExcelWorksheet worksheet = package.Workbook.Worksheets["Лист1"];
bool exit=false;
do
{
    Console.Clear();
    currentRow = 2;
    while (worksheet.Cells[currentRow, 1].Value!=null)
    {
        Tovar tovar = new Tovar()
        {
            Name = worksheet.Cells[currentRow, 1].Value.ToString(),
            Count = int.Parse(worksheet.Cells[currentRow, 2].Value.ToString()!),
            CostPrice = decimal.Parse(worksheet.Cells[currentRow, 3].Value.ToString()!),
            Total = decimal.Parse(worksheet.Cells[currentRow, 4].Value.ToString()!),
            Price = decimal.Parse(worksheet.Cells[currentRow, 5].Value.ToString()!),
            Remainder = decimal.Parse(worksheet.Cells[currentRow, 6].Value.ToString()!),
            Start = DateTime.Parse(worksheet.Cells[currentRow, 7].Value.ToString()!)
        };
        tovar.Print();
        Console.WriteLine();
        currentRow++;
    }
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Поступление товара");
    Console.WriteLine("2. Продажа товара");
    Console.WriteLine("3. Поиск товара");
    Console.WriteLine("4. Выход");
    Console.Write("Выберите пункт меню:");
    int n = int.Parse(Console.ReadLine()!);
    switch (n) 
    {
        case 1: 
            {
                Console.Write("Введите наменование товара:");
                string name=Console.ReadLine()!;
                Console.Write("Введите количество в наличии:");
                int count=int.Parse(Console.ReadLine()!);
                Console.Write("Введите cебестоимость:");
                decimal  costPrice= decimal.Parse(Console.ReadLine()!);
                Console.Write("Введите цену:");
                decimal price = decimal.Parse(Console.ReadLine()!);
                Console.Write("Введите дату поступления:");
                DateTime time = DateTime.Parse(Console.ReadLine()!);
                Tovar tovar = new Tovar
                {
                    Name = name,
                    Count = count,
                    CostPrice = costPrice,
                    Total = count * costPrice,
                    Price = price,
                    Remainder=costPrice*count,
                    Start=time
                };
                worksheet.Cells[currentRow,1].Value=tovar.Name;
                worksheet.Cells[currentRow, 2].Value = tovar.Count;
                worksheet.Cells[currentRow, 3].Value = tovar.CostPrice;
                worksheet.Cells[currentRow, 4].Value = tovar.Total;
                worksheet.Cells[currentRow, 5].Value = tovar.Price;
                worksheet.Cells[currentRow, 6].Value = tovar.Remainder;
                worksheet.Cells[currentRow, 7].Value = tovar.Start.ToShortDateString();
                package.Save();
                currentRow++;
            } 
            break;
        case 2:
            {
                Console.Write("Введите товар:");
                string name=Console.ReadLine()!;
                Console.Write("Введите количество:");
                int count = int.Parse(Console.ReadLine()!);
                for (int row = 2; row < currentRow; row++)
                {
                    if(worksheet.Cells[row, 1].Value.ToString() == name)
                    {
                        if (count < int.Parse(worksheet.Cells[row, 2].
                            Value.ToString()!))
                        {
                            int nCount = int.Parse(worksheet.Cells[row, 2].
                            Value.ToString()!) - count;
                            worksheet.Cells[row, 2].Value = nCount;
                            package.Save();
                        }
                        else
                        {
                            Console.WriteLine("Такого количества на складе нет!");
                            Console.ReadKey();
                        }
                    }
                }
            }
            break;
        case 3:
            {

            }
            break;
        case 4: 
            { 
                exit = true;
            } 
            break;
    }
}
while (!exit);
