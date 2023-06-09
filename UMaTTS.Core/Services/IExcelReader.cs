﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMaTLMS.Core.Services;

public interface IExcelReader
{
    ExcelPackage CreateNew(string filePath);
    ExcelWorksheet GetWorkSheet(string filePath, string worksheet);
    ExcelWorksheet GetWorkSheet(string filePath, int index);
    string? GetCellValue(ExcelWorksheet worksheet, int row, string col);
    int NoOfWorkSheets(string filePath);
    Task SaveAsync();
}
