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

namespace Tyuiu.FalinGS.Sprint7.Project.V2
{
    public partial class FormUpdatePost : Form
    {
        public FormUpdatePost()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_shop_1_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;
            


            string DataToSave = $"{mounth},{napitki},{vipechka},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base6.csv";

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

        private void textBox_vipechka_FGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_napitki_FGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_shop_2_FGS_Click(object sender, EventArgs e)
        {
            string mounth = textBox_mounth_FGS.Text;
            string money = textBox_money_FGS.Text;
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;



            string DataToSave = $"{mounth},{napitki},{vipechka},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base7.csv";

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
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;



            string DataToSave = $"{mounth},{napitki},{vipechka},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base8.csv";

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
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;



            string DataToSave = $"{mounth},{napitki},{vipechka},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base9.csv";

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
            string napitki = textBox_napitki_FGS.Text;
            string vipechka = textBox_vipechka_FGS.Text;



            string DataToSave = $"{mounth},{napitki},{vipechka},{money}";

            try
            {
                string filePath = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base10.csv";

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

        private void button_done_FGS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
