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

namespace Prakt1ka
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();
        private List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
        private string fileName = "parking.txt";

        public Form1()
        {
            InitializeComponent();

            // Инициализация парковочных мест
            for (int i = 1; i <= 10; i++)
            {
                parkingSpots.Add(new ParkingSpot { Number = i, IsAvailable = true });
            }

            // Создание нужных столбцов в DataGridView
            ParkingSpotsView.AutoGenerateColumns = false;
            ParkingSpotsView.Columns.Add("Номер", "Номер");
            ParkingSpotsView.Columns.Add("Марка", "Марка");
            ParkingSpotsView.Columns.Add("Модель", "Модель");
            ParkingSpotsView.Columns.Add("Цвет", "Цвет");
            ParkingSpotsView.Columns.Add("Время прибытия", "Время прибытия");
            ParkingSpotsView.Columns.Add("Время выезда", "Время выезда");
            ParkingSpotsView.Columns.Add("Парковочное место", "Парковочное место");
            ParkingSpotsView.Columns.Add("Стоимость", "Стоимость");

            UpdateCarsDataGridView();
        }

        private void NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверка на наличие свободного места
            int freeSpot = FindFreeSpot();
            if (freeSpot == -1)
            {
                MessageBox.Show("Все места заняты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового объекта Car
            Car newCar = new Car
            {
                Number = Numbertxt.Text,
                Brand = Brandtxt.Text,
                Model = Modeltxt.Text,
                Color = Colourtxt.Text,
                ArrivalTime = ArriveTimepicker.Value,
                DepartureTime = DepartureTimepicker.Value,
                ParkingSpot = freeSpot
            };

            // Добавление машины в список
            cars.Add(newCar);

            // Обновление DataGridView
            UpdateCarsDataGridView();

            // Очистка текстовых полей
            ClearInputFields();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли машина в DataGridView
            if (ParkingSpotsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите машину для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получение номера выбранной машины
            string carNumber = ParkingSpotsView.SelectedRows[0].Cells["Номер"].Value.ToString();

            // Поиск машины в списке
            Car carToRemove = cars.FirstOrDefault(c => c.Number == carNumber);

            if (carToRemove != null)
            {
                parkingSpots[carToRemove.ParkingSpot - 1].IsAvailable = true;

                cars.Remove(carToRemove);

                UpdateCarsDataGridView();
            }
            else
            {
                MessageBox.Show("Машина с таким номером не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCostBtn_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли машина в DataGridView
            if (ParkingSpotsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите машину для расчета стоимости.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получение номера выбранной машины
            string carNumber = ParkingSpotsView.SelectedRows[0].Cells["Номер"].Value.ToString();

            // Поиск машины в списке
            Car carToCalculate = cars.FirstOrDefault(c => c.Number == carNumber);

            if (carToCalculate != null)
            {
                carToCalculate.TotalCost = CalculateCost(carToCalculate.ArrivalTime, carToCalculate.DepartureTime);

                UpdateCarsDataGridView();
            }
            else
            {
                MessageBox.Show("Машина с таким номером не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // класс Машины
        public class Car
        {
            public string Number { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public DateTime ArrivalTime { get; set; }
            public DateTime DepartureTime { get; set; } 
            public int ParkingSpot { get; set; } 
            public decimal TotalCost { get; set; }
        }

        // класс Парковочного места
        public class ParkingSpot
        {
            public int Number { get; set; }
            public bool IsAvailable { get; set; }
        }

        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Сохранение в файл
            SaveToFile();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // Загрузка из файла
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Текстовый файл|*.txt";
            openFileDialog1.Title = "Открыть данные об активностях";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');
                        ParkingSpotsView.Rows.Add(data);
                    }
                }
            }
        }

        private int FindFreeSpot()
        {
            // Поиск свободного места
            for (int i = 0; i < parkingSpots.Count; i++)
            {
                if (parkingSpots[i].IsAvailable)
                {
                    return parkingSpots[i].Number;
                }
            }
            return -1; 
        }

        private void UpdateCarsDataGridView()
        {
            // Обновление DataGridView
            ParkingSpotsView.Rows.Clear();

            foreach (Car car in cars)
            {
                ParkingSpotsView.Rows.Add(car.Number, car.Brand, car.Model, car.Color,
                                car.ArrivalTime.ToString(), car.DepartureTime.ToString(),
                                car.ParkingSpot, car.TotalCost);
            }
        }

        private void ClearInputFields()
        {
            // Очистка полей
            Numbertxt.Clear();
            Brandtxt.Clear();
            Modeltxt.Clear();
            Colourtxt.Clear();
            ArriveTimepicker.Value = DateTime.Now;
            DepartureTimepicker.Value = DateTime.Now;
            ParkingSpottxt.Clear();
            Costtxt.Clear();
        }

        private void SaveToFile()
        {
            // Метод сохранение в файл
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовый файл|*.txt";
            saveFileDialog1.Title = "Сохранить данные о ТС";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Car car in cars)
                    {
                        file.WriteLine($"{car.Number};{car.Brand};{car.Model};{car.Color};{car.ArrivalTime:yyyy-MM-dd HH:mm:ss};{car.DepartureTime:yyyy-MM-dd HH:mm:ss};{car.ParkingSpot};{car.TotalCost}");
                    }
                }
            }
        }
        
        //Метод для поиска стоимости 
        private decimal CalculateCost(DateTime arrivalTime, DateTime departureTime)
        {
            // Рассчитываем стоимость (например, 10 рублей в час)
            TimeSpan duration = departureTime - arrivalTime;
            return (decimal)duration.TotalHours * 15;
        }
    }
}