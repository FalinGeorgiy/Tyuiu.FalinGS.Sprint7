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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.FalinGS.Sprint7.Project.V2
{
    public partial class FormUpdateShop : Form
    {
        public FormUpdateShop()
        {
            InitializeComponent();
        }

        private void button_shop_1_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string ovoshi = textBox_ovoshi_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            string sladosti = textBox_sladosti_FGS.Text;
            string krypi = textBox_krypi_FGS.Text;
            

            string DataToSave = $"{mounth},{ovoshi},{napitki},{vipechka},{sladosti},{krypi},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base1.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Месяц,Овощи,Напитки,Выпечка,Сладости,Крупы,Оборот";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(";", ","));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void textBox_mounth_FGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_money_FGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ovoshi_FGS_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void textBox_napitki_FGS_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void textBox_vipechka_FGS_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void textBox_sladosti_FGS_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void textBox_krypi_FGS_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void CalculateSum()
        {
            // Получаем значения из текстовых полей, предполагая, что они содержат числа
            if (int.TryParse(textBox_ovoshi_FGS.Text, out int value1) && int.TryParse(textBox_napitki_FGS.Text, out int value2) && int.TryParse(textBox_vipechka_FGS.Text, out int value3) && int.TryParse(textBox_sladosti_FGS.Text, out int value4) && int.TryParse(textBox_krypi_FGS.Text, out int value5))
            {
                int sum = value1 + value2 + value3 + value4 + value5; // Складываем значения
                textBox_money_FGS.Text = sum.ToString(); // Отображаем результат в другом текстовом поле
            }
            else
            {
                textBox_money_FGS.Text = "Ошибка"; // Если в текстовых полях не числовые значения, отображаем ошибку
            }
        }

        private void button_done_FGS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_shop_2_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string ovoshi = textBox_ovoshi_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            string sladosti = textBox_sladosti_FGS.Text;
            string krypi = textBox_krypi_FGS.Text;


            string DataToSave = $"{mounth},{ovoshi},{napitki},{vipechka},{sladosti},{krypi},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base2.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Месяц,Овощи,Напитки,Выпечка,Сладости,Крупы,Оборот";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(";", ","));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_shop_3_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string ovoshi = textBox_ovoshi_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            string sladosti = textBox_sladosti_FGS.Text;
            string krypi = textBox_krypi_FGS.Text;


            string DataToSave = $"{mounth},{ovoshi},{napitki},{vipechka},{sladosti},{krypi},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base3.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Месяц,Овощи,Напитки,Выпечка,Сладости,Крупы,Оборот";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(";", ","));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_shop_4_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string ovoshi = textBox_ovoshi_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            string sladosti = textBox_sladosti_FGS.Text;
            string krypi = textBox_krypi_FGS.Text;


            string DataToSave = $"{mounth},{ovoshi},{napitki},{vipechka},{sladosti},{krypi},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base4.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Месяц,Овощи,Напитки,Выпечка,Сладости,Крупы,Оборот";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(";", ","));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_shop_5_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string ovoshi = textBox_ovoshi_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            string sladosti = textBox_sladosti_FGS.Text;
            string krypi = textBox_krypi_FGS.Text;


            string DataToSave = $"{mounth},{ovoshi},{napitki},{vipechka},{sladosti},{krypi},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base5.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Месяц,Овощи,Напитки,Выпечка,Сладости,Крупы,Оборот";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(";", ","));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
    }
}
