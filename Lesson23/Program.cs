using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

string? filePath = "formules.xlsx";
ExcelPackage.LicenseContext =
    OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage package = new ExcelPackage(filePath);
//package.Workbook.Worksheets.Add("Functions");
ExcelWorksheet worksheet = package.Workbook.Worksheets["Functions"];
//worksheet.Cells["A1"].Value = 10;
//worksheet.Cells["A2"].Value = 20;
//worksheet.Cells["A3"].Value = 30;

//worksheet.Cells["B1"].Value = 5;
//worksheet.Cells["B2"].Value = 10;
//worksheet.Cells["B3"].Value = 15;

//worksheet.Cells["C1"].Formula = "SUM(A1:B1)";
//worksheet.Cells["C2"].Formula = "SUM(A2:B2)";
//worksheet.Cells["C3"].Formula = "SUM(A3:B3)";
//package.Save();
//package.SaveAs("formules.xlsx");
Random random = new Random();
for (int i = 1; i < 6; i++)
{
    worksheet.Cells[4, i].Value = random.Next(10, 100).ToString();
}
worksheet.Cells[4, 6].Formula = "Count(A4:E4)";

worksheet.Cells["A4:F4"].Style.Border.Top.Style = ExcelBorderStyle.Double;
worksheet.Cells["A4:F4"].Style.Border.Bottom.Style = ExcelBorderStyle.Double;
worksheet.Cells["A4:F4"].Style.Border.Left.Style = ExcelBorderStyle.Double;
worksheet.Cells["A4:F4"].Style.Border.Right.Style = ExcelBorderStyle.Double;

worksheet.Cells["A4:F4"].Style.Border.Top.Color.SetColor(Color.Black);
worksheet.Cells["A4:F4"].Style.Border.Bottom.Color.SetColor(Color.Black);
worksheet.Cells["A4:F4"].Style.Border.Left.Color.SetColor(Color.Black);
worksheet.Cells["A4:F4"].Style.Border.Right.Color.SetColor(Color.Black);
package.Save();