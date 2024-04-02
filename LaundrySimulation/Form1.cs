using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace LaundrySimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            chart1.Series[0].Points.AddXY(0, 0);
        }

        //константы
        int numberOfWashingMachineAndDryer = 30;
        int CountOfCleaner = 22; // одна стирка
        // 96900 rub.  / 114(штук) - Полная закупка
        

        //Параметры под рандомом
        int numberOfClients = 0;
        int numberOfCompetitors = 0;
        int qualityService = 0;

        //Просчитываемые параметры
        int count = 0;
        int serviceCost = 0;
        double income = 0d;
        int speedService = 0; //число заказов в час
        int numberOfOrders = 0;
        Random random = new Random();
        private void setNumbers()
        {
            numberOfOrders = 0;
            NumberOfWashingMachineAndDryer.Text = numberOfWashingMachineAndDryer.ToString();
            NumberOfCleaners.Text = CountOfCleaner.ToString();
            qualityService = random.Next(3, 10); //качество обслуживания
            QualityOfService.Text = qualityService.ToString();

            numberOfCompetitors = random.Next(1, 7); //число конкурентов
            NumberOfEnemy.Text = numberOfCompetitors.ToString();

            if (qualityService > 5 && numberOfCompetitors < 3) 
            {
                numberOfClients = random.Next(1000, 1500);
            } else
            {
                numberOfClients = random.Next(500, 1000);
            }
            NumberOfClients.Text = numberOfClients.ToString();
            //число заказов
            for (int i = 0; i < numberOfClients; i++) 
            {
                if (Convert.ToBoolean(random.Next(0, 2)))
                {
                    numberOfOrders += random.Next(1, 5);
                }
            }
            NumberOfOrder.Text = numberOfOrders.ToString();

            //1700 рублей = 80 стирок
            speedService = numberOfOrders / (numberOfWashingMachineAndDryer * 12); //скорость обслуживания
            SpeedOfService.Text = speedService.ToString();

            serviceCost = CountOfCleaner + random.Next(160, 200);
            PriceOfService.Text = serviceCost.ToString();
            if (speedService == 1)
            {
                income = serviceCost * numberOfOrders;
            } else
            {
                income = ((serviceCost * numberOfOrders) * (100-(speedService*2)))/100;
            }
            
            CurrentIncome.Text = income.ToString();
        }




        bool started = false;
        private void SimulateStopButton_Click(object sender, EventArgs e)
        {
            count++;
            setNumbers(); // Вызываем метод setNumbers() для обновления значений

            // Добавляем текущее значение прибыли на график
            chart1.Series[0].Points.AddXY(count, income);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
