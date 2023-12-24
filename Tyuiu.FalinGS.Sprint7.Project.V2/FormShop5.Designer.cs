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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonShop1Graph_FGS = new System.Windows.Forms.Button();
            this.Diag_FGS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
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
            chartArea3.Name = "ChartArea1";
            this.Diag_FGS.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Diag_FGS.Legends.Add(legend3);
            this.Diag_FGS.Location = new System.Drawing.Point(307, 32);
            this.Diag_FGS.Name = "Diag_FGS";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Оборот тыс.руб";
            this.Diag_FGS.Series.Add(series3);
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
            // FormShop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.buttonShop1Graph_FGS);
            this.Controls.Add(this.Diag_FGS);
            this.Controls.Add(this.groupBox_Info);
            this.Name = "FormShop5";
            this.Text = "FormShop5";
            ((System.ComponentModel.ISupportInitialize)(this.Diag_FGS)).EndInit();
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShop1Graph_FGS;
        private System.Windows.Forms.DataVisualization.Charting.Chart Diag_FGS;
        private System.Windows.Forms.GroupBox groupBox_Info;
    }
}