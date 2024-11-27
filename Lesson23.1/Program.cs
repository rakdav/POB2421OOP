using OfficeOpenXml;

//string? filePath = "practice1.xlsx";
//ExcelPackage.LicenseContext =
//    OfficeOpenXml.LicenseContext.NonCommercial;
//ExcelPackage package = new ExcelPackage(filePath);
//ExcelWorksheet worksheet = package.Workbook.Worksheets["Лист1"];
//worksheet.Cells["B20"].Formula = "SUM(B1:B19)";
//worksheet.Cells["B21"].Formula = "Average(B1:B19)";
//worksheet.Cells["B22"].Formula = "MAX(B1:B19)";
//worksheet.Cells["B23"].Formula = "MIN(B1:B19)";
//package.Save();

string? filePath = "VLOOKUP.xlsx";
ExcelPackage.LicenseContext =
    OfficeOpenXml.LicenseContext.NonCommercial;
ExcelPackage package = new ExcelPackage(filePath);
ExcelWorksheet worksheet = package.Workbook.Worksheets["Лист1"];
//worksheet.Cells["A1"].Value =