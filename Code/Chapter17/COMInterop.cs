using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMInterop
{
    class MainApp
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbook.Add(Type.Missing);

            Excel.WorkSheet workSheet = (Excel.WorkSheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)workSheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\shpark-book-old.xlsx",
                                                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbook.Add();

            Excel.WorkSheet workSheet = (Excel.WorkSheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)workSheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\shpark-book-dynamic.xlsx");
            excelApp.Quit();
        }

        static void Main()
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                { "임재준", "1998"},
                { "홍길동", "1992"},
                { "비쥬얼", "1995"},
                { "스튜디오", "1982"},
                { "스팀", "1930"},
                { "코드", "1983"},
                { "라이더", "2000"}
            };

            Console.WriteLine("Creating Excel document in old way...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel document in new way...");
            NewWay(array, savePath);
        }
    }
}
