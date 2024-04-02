namespace LaundrySimulation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimulateStopButton = new System.Windows.Forms.Button();
            this.NumberOfWashingMachineAndDryer = new System.Windows.Forms.TextBox();
            this.SpeedOfService = new System.Windows.Forms.TextBox();
            this.QualityOfService = new System.Windows.Forms.TextBox();
            this.NumberOfEnemy = new System.Windows.Forms.TextBox();
            this.PriceOfService = new System.Windows.Forms.TextBox();
            this.CurrentIncome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberOfClients = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberOfCleaners = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 187);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Прибыль";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(775, 286);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // SimulateStopButton
            // 
            this.SimulateStopButton.Location = new System.Drawing.Point(677, 139);
            this.SimulateStopButton.Name = "SimulateStopButton";
            this.SimulateStopButton.Size = new System.Drawing.Size(79, 24);
            this.SimulateStopButton.TabIndex = 1;
            this.SimulateStopButton.Text = "Старт";
            this.SimulateStopButton.UseVisualStyleBackColor = true;
            this.SimulateStopButton.Click += new System.EventHandler(this.SimulateStopButton_Click);
            // 
            // NumberOfWashingMachineAndDryer
            // 
            this.NumberOfWashingMachineAndDryer.Location = new System.Drawing.Point(28, 25);
            this.NumberOfWashingMachineAndDryer.Name = "NumberOfWashingMachineAndDryer";
            this.NumberOfWashingMachineAndDryer.ReadOnly = true;
            this.NumberOfWashingMachineAndDryer.Size = new System.Drawing.Size(102, 20);
            this.NumberOfWashingMachineAndDryer.TabIndex = 2;
            // 
            // SpeedOfService
            // 
            this.SpeedOfService.Location = new System.Drawing.Point(28, 66);
            this.SpeedOfService.Name = "SpeedOfService";
            this.SpeedOfService.ReadOnly = true;
            this.SpeedOfService.Size = new System.Drawing.Size(102, 20);
            this.SpeedOfService.TabIndex = 3;
            // 
            // QualityOfService
            // 
            this.QualityOfService.Location = new System.Drawing.Point(28, 106);
            this.QualityOfService.Name = "QualityOfService";
            this.QualityOfService.ReadOnly = true;
            this.QualityOfService.Size = new System.Drawing.Size(102, 20);
            this.QualityOfService.TabIndex = 4;
            // 
            // NumberOfEnemy
            // 
            this.NumberOfEnemy.Location = new System.Drawing.Point(258, 73);
            this.NumberOfEnemy.Name = "NumberOfEnemy";
            this.NumberOfEnemy.ReadOnly = true;
            this.NumberOfEnemy.Size = new System.Drawing.Size(102, 20);
            this.NumberOfEnemy.TabIndex = 5;
            // 
            // PriceOfService
            // 
            this.PriceOfService.Location = new System.Drawing.Point(399, 25);
            this.PriceOfService.Name = "PriceOfService";
            this.PriceOfService.ReadOnly = true;
            this.PriceOfService.Size = new System.Drawing.Size(102, 20);
            this.PriceOfService.TabIndex = 6;
            // 
            // CurrentIncome
            // 
            this.CurrentIncome.Location = new System.Drawing.Point(526, 27);
            this.CurrentIncome.Name = "CurrentIncome";
            this.CurrentIncome.ReadOnly = true;
            this.CurrentIncome.Size = new System.Drawing.Size(102, 20);
            this.CurrentIncome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Стоимость услуги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Текущая прибыль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество стиральных машин и сушилок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Скорость обслуживания:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Качество обслуживания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Количество конкурентов:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество клиентов:";
            // 
            // NumberOfClients
            // 
            this.NumberOfClients.Location = new System.Drawing.Point(258, 25);
            this.NumberOfClients.Name = "NumberOfClients";
            this.NumberOfClients.ReadOnly = true;
            this.NumberOfClients.Size = new System.Drawing.Size(102, 20);
            this.NumberOfClients.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество моющих средств:";
            // 
            // NumberOfCleaners
            // 
            this.NumberOfCleaners.Location = new System.Drawing.Point(28, 161);
            this.NumberOfCleaners.Name = "NumberOfCleaners";
            this.NumberOfCleaners.ReadOnly = true;
            this.NumberOfCleaners.Size = new System.Drawing.Size(102, 20);
            this.NumberOfCleaners.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Число заказов:";
            // 
            // NumberOfOrder
            // 
            this.NumberOfOrder.Location = new System.Drawing.Point(258, 123);
            this.NumberOfOrder.Name = "NumberOfOrder";
            this.NumberOfOrder.ReadOnly = true;
            this.NumberOfOrder.Size = new System.Drawing.Size(102, 20);
            this.NumberOfOrder.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumberOfOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberOfCleaners);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfClients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentIncome);
            this.Controls.Add(this.PriceOfService);
            this.Controls.Add(this.NumberOfEnemy);
            this.Controls.Add(this.QualityOfService);
            this.Controls.Add(this.SpeedOfService);
            this.Controls.Add(this.NumberOfWashingMachineAndDryer);
            this.Controls.Add(this.SimulateStopButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button SimulateStopButton;
        private System.Windows.Forms.TextBox NumberOfWashingMachineAndDryer;
        private System.Windows.Forms.TextBox SpeedOfService;
        private System.Windows.Forms.TextBox QualityOfService;
        private System.Windows.Forms.TextBox NumberOfEnemy;
        private System.Windows.Forms.TextBox PriceOfService;
        private System.Windows.Forms.TextBox CurrentIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumberOfClients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumberOfCleaners;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberOfOrder;
    }
}

