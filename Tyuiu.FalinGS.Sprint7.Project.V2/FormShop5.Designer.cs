namespace Tyuiu.FalinGS.Sprint7.Project.V2
{
    partial class FormShop5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonShop1Graph_FGS = new System.Windows.Forms.Button();
            this.Diag_FGS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.Button_Sum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diag_FGS)).BeginInit();
            this.groupBox_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 119);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Шестерочка Мыс\r\nАдрес: Полярная 18/2\r\nТелефон: 45-43-88\r\nИНН: 434225684843\r\n\r\nВла" +
    "делец: Краснов Валентин Васильевич\r\nНомер телефона: 79827568392\r\nКапитал: 1993 т" +
    "ыс.руб\r\n\r\n";
            // 
            // buttonShop1Graph_FGS
            // 
            this.buttonShop1Graph_FGS.Location = new System.Drawing.Point(307, 368);
            this.buttonShop1Graph_FGS.Name = "buttonShop1Graph_FGS";
            this.buttonShop1Graph_FGS.Size = new System.Drawing.Size(118, 23);
            this.buttonShop1Graph_FGS.TabIndex = 5;
            this.buttonShop1Graph_FGS.Text = "Анализ оборота";
            this.buttonShop1Graph_FGS.UseVisualStyleBackColor = true;
            this.buttonShop1Graph_FGS.Click += new System.EventHandler(this.buttonShop1Graph_FGS_Click);
            // 
            // Diag_FGS
            // 
            chartArea2.Name = "ChartArea1";
            this.Diag_FGS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Diag_FGS.Legends.Add(legend2);
            this.Diag_FGS.Location = new System.Drawing.Point(307, 32);
            this.Diag_FGS.Name = "Diag_FGS";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Оборот тыс.руб";
            this.Diag_FGS.Series.Add(series2);
            this.Diag_FGS.Size = new System.Drawing.Size(546, 330);
            this.Diag_FGS.TabIndex = 4;
            this.Diag_FGS.Text = "chart1";
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.textBox1);
            this.groupBox_Info.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(289, 395);
            this.groupBox_Info.TabIndex = 3;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Информаци";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(587, 370);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(124, 20);
            this.textBoxSum.TabIndex = 7;
            // 
            // Button_Sum
            // 
            this.Button_Sum.Location = new System.Drawing.Point(431, 368);
            this.Button_Sum.Name = "Button_Sum";
            this.Button_Sum.Size = new System.Drawing.Size(149, 23);
            this.Button_Sum.TabIndex = 6;
            this.Button_Sum.Text = "Общая сумма оборота";
            this.Button_Sum.UseVisualStyleBackColor = true;
            this.Button_Sum.Click += new System.EventHandler(this.Button_Sum_Click);
            // 
            // FormShop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.Button_Sum);
            this.Controls.Add(this.buttonShop1Graph_FGS);
            this.Controls.Add(this.Diag_FGS);
            this.Controls.Add(this.groupBox_Info);
            this.Name = "FormShop5";
            this.Text = "FormShop5";
            ((System.ComponentModel.ISupportInitialize)(this.Diag_FGS)).EndInit();
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShop1Graph_FGS;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diag_FGS;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button Button_Sum;
    }
}