using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.FalinGS.Sprint7.Project.V2
{
    public partial class FormShop1 : Form
    {
        public FormShop1()
        {
            InitializeComponent();
        }

        private void Diag_FGS_Click(object sender, EventArgs e)
        {

        }

        private void buttonShop1Graph_FGS_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base1.csv"; // Укажите путь к вашему файлу CSV


            // Чтение CSV и добавление данных в список строк
            List<string[]> rows = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    rows.Add(line);
                }
            }

            // Получение данных для графика (x - месяцы, y - обороты)
            Series series = Diag_FGS.Series[0];
            Series series1 = Diag_FGS.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.Points.Clear();

            for (int i = 1; i < rows.Count; i++) // Начинаем с 1, чтобы пропустить заголовок
            {
                if (rows[i].Length > 6) // Проверяем, что строка содержит не менее 7 столбцов
                {
                    string month = rows[i][0];
                    double turnover;
                    // Пытаемся конвертировать строку в число с учетом различных форматов
                    if (double.TryParse(rows[i][6], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out turnover))
                    {
                        series.Points.AddXY(month, turnover);
                    }
                    else
                    {
                        // Обработка ошибок конвертации значения оборотов
                        Console.WriteLine($"Ошибка конвертации оборота в строке {i}: '{rows[i][6]}'");
                    }
                }
                else
                {
                    // Обработка строк с недостаточным количеством столбцов
                    Console.WriteLine($"Строка {i} содержит недостаточное количество столбцов");
                }
            }
        }
    }
}
