using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelProject
{
    internal class Program
    {
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            Process[] process;
            process = Process.GetProcessesByName("Excel");
            foreach (var p in process)
            {
                p.Kill();
            }
        }

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;

            bool systemLoop = true;
            while (systemLoop)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Student Management Program");
                Console.WriteLine("---------------------------");
                Console.WriteLine("[1] 추가 [2] 출력 [3] 검색 [4] 수정 [5] 삭제 [0] 프로그램 종료");

                var key = Console.ReadLine();
                ExcelLib xlLib = new ExcelLib();
                switch (key)
                {
                    case "1":
                        if (xlLib.AddExcel(CreateStudent()))
                        {
                            Console.WriteLine("등록되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine("등록에 실패하였습니다..");
                        }
                        break;

                    case "2":
                        var list = xlLib.GetExcel();
                        PrintStudents(list);

                        break;
                    case "0":
                        systemLoop = false;

                        break;
                    default:
                        break;

                }
            }

        }
        static void PrintStudents(List<Student> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} \t\t {s.Name} \t\t {string.Format("{0,3:0}", s.Kor)} \t\t {string.Format("{0,3:0}", s.Eng)} \t\t {string.Format("{0,3:0}", s.Math)} \t\t {s.IsActive}");
            }
        }
        static Student CreateStudent()
        {
            Console.WriteLine("Please input infomation for creating");
            Console.WriteLine("1.Name 2.Kor 3.Eng 4.Math 5.IsActive");
            var read = Console.ReadLine();
            var student = new Student();

            student.Name = read.Split(' ')[0];
            student.Kor = GetScore(read.Split(' ')[1]);
            student.Eng = GetScore(read.Split(' ')[2]);
            student.Math = GetScore(read.Split(' ')[3]);
            student.IsActive = read.Split(' ')[4] == "true" || read.Split(' ')[4] == "True" ? true : false;

            return student;
        }
        static int GetScore(string str)
        {
            if (!int.TryParse(str, out int score))
            {
                var repeat = Console.ReadLine();
                GetScore(repeat);
            }
            return score;

        }
    }
    public class ExcelLib
    {
        private string _path;

        private void DeleteObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }


        public ExcelLib()
        {
            _path = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy\management.xlsx";
        }

        public List<Student> GetExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(_path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets.get_Item(1) as Excel.Worksheet;
            Excel.Range range = xlWorksheet.UsedRange;

            List<Student> students = new List<Student>();

            for (int i = 2; i <= range.Rows.Count; i++)
            {

                try
                {
                    students.Add(new Student()
                    {
                        Id = Convert.ToInt32((range.Cells[i, 1] as Excel.Range).Value),
                        Name = (range.Cells[i, 2] as Excel.Range).Value.ToString(),
                        Kor = Convert.ToInt32((range.Cells[i, 3] as Excel.Range).Value),
                        Eng = Convert.ToInt32((range.Cells[i, 4] as Excel.Range).Value),
                        Math = Convert.ToInt32((range.Cells[i, 5] as Excel.Range).Value),
                        IsActive = ((range.Cells[i, 6] as Excel.Range).Value.ToString() == "True") ? true : false,
                    });
                }
                catch
                {

                }


            }
            xlWorkbook.Save();
            xlWorkbook.Close(true);
            xlApp.Quit();

            DeleteObject(range);
            DeleteObject(xlWorksheet);
            return students;
        }

        public bool AddExcel(Student s)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(_path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets.get_Item(1) as Excel.Worksheet;

            if (File.Exists(_path))
            {
                try
                {
                    xlWorkbook.Application.ActiveWorkbook.Saved = true;
                    var id = xlWorksheet.UsedRange.Rows.Count + 1;

                    xlWorksheet.Cells[id, 1] = id - 1;
                    xlWorksheet.Cells[id, 2] = s.Name;
                    xlWorksheet.Cells[id, 3] = s.Kor;
                    xlWorksheet.Cells[id, 4] = s.Eng;
                    xlWorksheet.Cells[id, 5] = s.Math;
                    xlWorksheet.Cells[id, 6] = s.IsActive;

                    xlWorkbook.Save();
                }
                catch
                {
                    xlWorkbook.Close(true);
                    xlApp.Quit();

                    DeleteObject(xlWorksheet);
                    return false;
                }

            }
            else
            {
                try
                {
                    xlWorksheet.Cells[1, 1] = "Id";
                    xlWorksheet.Cells[1, 2] = "Name";
                    xlWorksheet.Cells[1, 3] = "Kor";
                    xlWorksheet.Cells[1, 4] = "Eng";
                    xlWorksheet.Cells[1, 5] = "Math";
                    xlWorksheet.Cells[1, 6] = "IsActive";

                    var id = xlWorksheet.UsedRange.Rows.Count + 1;

                    xlWorksheet.Cells[id, 1] = id - 1;
                    xlWorksheet.Cells[id, 2] = s.Name;
                    xlWorksheet.Cells[id, 3] = s.Kor;
                    xlWorksheet.Cells[id, 4] = s.Eng;
                    xlWorksheet.Cells[id, 5] = s.Math;
                    xlWorksheet.Cells[id, 6] = s.IsActive;

                    xlWorksheet.Columns.AutoFit();
                    xlWorkbook.SaveAs(_path);

                    xlWorkbook.Close();
                    xlApp.Quit();
                }
                catch
                {
                    DeleteObject(xlWorksheet);
                    xlWorkbook.Close(true);
                    xlApp.Quit();
                    return false;
                }

            }


            xlWorkbook.Close(true);
            xlApp.Quit();

            DeleteObject(xlWorksheet);

            return true;
        }
    }
}
