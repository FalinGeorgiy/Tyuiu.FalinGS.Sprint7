using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.FalinGS.Sprint7.Project.V2.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;


namespace Tyuiu.FalinGS.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridView_FGS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       
        string shop_1n = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base1.csv";
        string shop_2n = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base2.csv";
        string shop_3n = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base3.csv";
        string shop_4n = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base4.csv";
        string shop_5n = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base5.csv";
        string post_1 = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base6.csv";
        string post_2 = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base7.csv";
        string post_3 = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base8.csv";
        string post_4 = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base9.csv";
        string post_5 = @"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base10.csv";

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }





        //Кнопки
        private void button_shop1_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(shop_1n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_FGS.Rows[e.RowIndex];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShop1 FormShop1 = new FormShop1();
            FormShop1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base1.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(shop_3n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button3_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base3.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base2.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base4.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base5.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_info_FGS_Click(object sender, EventArgs e)
        {
            FormShop2 FormShop2 = new FormShop2();
            FormShop2.ShowDialog();
        }

        private void button3_info_FGS_Click(object sender, EventArgs e)
        {
            FormShop3 FormShop3 = new FormShop3();
            FormShop3.ShowDialog();
        }

        private void button4_info_FGS_Click(object sender, EventArgs e)
        {
            FormShop4 FormShop4 = new FormShop4();
            FormShop4.ShowDialog();
        }

        private void button5_info_FGS_Click(object sender, EventArgs e)
        {
            FormShop5 FormShop5 = new FormShop5();
            FormShop5.ShowDialog();
        }

        private void button_shop2_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(shop_2n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_shop4_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(shop_4n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_shop5_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(shop_5n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_update_FGS_Click(object sender, EventArgs e)
        {
            FormUpdateShop formUpdateShop = new FormUpdateShop();
            formUpdateShop.ShowDialog();
        }

        private void Search_FGS_TextChanged(object sender, EventArgs e)
        {
            string searchText = Search_FGS.Text; // Получаем введенный текст

            for (int i = 0; i <= dataGridView_FGS.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dataGridView_FGS.ColumnCount - 1; j++)
                {
                    if (dataGridView_FGS.Rows[i].Cells[j].Value != null && dataGridView_FGS.Rows[i].Cells[j].Value.ToString() == searchText)
                    {
                        dataGridView_FGS.Rows[i].Cells[j].Selected = true;
                    }
                    else
                    {
                        dataGridView_FGS.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
        }

        private void button6_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base6.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base7.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base8.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base9.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_save_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(@"C:\Users\User\source\repos\Tyuiu.FalinGS.Sprint7\Tyuiu.FalinGS.Sprint7\bin\Debug\Base10.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(",", dataGridView_FGS.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_FGS.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(",", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update2_FGS_Click(object sender, EventArgs e)
        {
            FormUpdatePost formUpdatePost = new FormUpdatePost();
            formUpdatePost.ShowDialog();
        }

        private void buttonShop1Graph_FGS_Click(object sender, EventArgs e)
        {
           

        }
    

        private void Diag_FGS_Click(object sender, EventArgs e)
        {

        }

        private void SortButton_FGS_Click(object sender, EventArgs e)
        {
            if (dataGridView_FGS.SelectedCells.Count > 0)
            {
                dataGridView_FGS.Sort(dataGridView_FGS.Columns[6], ListSortDirection.Ascending);
            }
        }

        private void button_post1_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(post_1, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        
    }

        private void button_post2_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(post_2, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private void button_post3_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(post_3, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private void button_post4_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(post_4, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private void button_post5_FGS_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(post_5, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_FGS.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_FGS.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private void button_info_FGS_Click(object sender, EventArgs e)
        {
            FormInfo FormInfo = new FormInfo();
            FormInfo.ShowDialog();
        }

        private void button_razrab_FGS_Click(object sender, EventArgs e)
        {
            FormMe FormMe = new FormMe();
            FormMe.ShowDialog();
        }

        private void SortButton2_FGS_Click(object sender, EventArgs e)
        {
            dataGridView_FGS.Sort(dataGridView_FGS.Columns[6], ListSortDirection.Descending);
        }
    }
}
