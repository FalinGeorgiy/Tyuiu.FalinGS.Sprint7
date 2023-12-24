using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.FalinGS.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public int LoadFromDataFile(string path)
        {
            int columnIndexToSum = 6;
            string[] lines = File.ReadAllLines(path);
            int sum = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields.Length > columnIndexToSum)
                {
                    if (int.TryParse(fields[columnIndexToSum], out int value)) 
                    {
                        sum += value;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: Невозможно преобразовать значение в числовой формат в строке {i}, столбец {columnIndexToSum + 1}");
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка: Недостаточно столбцов в строке {i}");
                }
            }
            return sum; 
        }

    }
}
