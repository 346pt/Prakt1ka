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

            // ������������� ����������� ����
            for (int i = 1; i <= 10; i++)
            {
                parkingSpots.Add(new ParkingSpot { Number = i, IsAvailable = true });
            }

            // �������� ������ �������� � DataGridView
            ParkingSpotsView.AutoGenerateColumns = false;
            ParkingSpotsView.Columns.Add("�����", "�����");
            ParkingSpotsView.Columns.Add("�����", "�����");
            ParkingSpotsView.Columns.Add("������", "������");
            ParkingSpotsView.Columns.Add("����", "����");
            ParkingSpotsView.Columns.Add("����� ��������", "����� ��������");
            ParkingSpotsView.Columns.Add("����� ������", "����� ������");
            ParkingSpotsView.Columns.Add("����������� �����", "����������� �����");
            ParkingSpotsView.Columns.Add("���������", "���������");

            UpdateCarsDataGridView();
        }

        private void NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // �������� �� ������� ���������� �����
            int freeSpot = FindFreeSpot();
            if (freeSpot == -1)
            {
                MessageBox.Show("��� ����� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // �������� ������ ������� Car
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

            // ���������� ������ � ������
            cars.Add(newCar);

            // ���������� DataGridView
            UpdateCarsDataGridView();

            // ������� ��������� �����
            ClearInputFields();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // ��������, ������� �� ������ � DataGridView
            if (ParkingSpotsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ��������� ������ ��������� ������
            string carNumber = ParkingSpotsView.SelectedRows[0].Cells["�����"].Value.ToString();

            // ����� ������ � ������
            Car carToRemove = cars.FirstOrDefault(c => c.Number == carNumber);

            if (carToRemove != null)
            {
                parkingSpots[carToRemove.ParkingSpot - 1].IsAvailable = true;

                cars.Remove(carToRemove);

                UpdateCarsDataGridView();
            }
            else
            {
                MessageBox.Show("������ � ����� ������� �� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCostBtn_Click(object sender, EventArgs e)
        {
            // ��������, ������� �� ������ � DataGridView
            if (ParkingSpotsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ ��� ������� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ��������� ������ ��������� ������
            string carNumber = ParkingSpotsView.SelectedRows[0].Cells["�����"].Value.ToString();

            // ����� ������ � ������
            Car carToCalculate = cars.FirstOrDefault(c => c.Number == carNumber);

            if (carToCalculate != null)
            {
                carToCalculate.TotalCost = CalculateCost(carToCalculate.ArrivalTime, carToCalculate.DepartureTime);

                UpdateCarsDataGridView();
            }
            else
            {
                MessageBox.Show("������ � ����� ������� �� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ����� ������
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

        // ����� ������������ �����
        public class ParkingSpot
        {
            public int Number { get; set; }
            public bool IsAvailable { get; set; }
        }

        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // ���������� � ����
            SaveToFile();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // �������� �� �����
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "��������� ����|*.txt";
            openFileDialog1.Title = "������� ������ �� �����������";

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
            // ����� ���������� �����
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
            // ���������� DataGridView
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
            // ������� �����
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
            // ����� ���������� � ����
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "��������� ����|*.txt";
            saveFileDialog1.Title = "��������� ������ � ��";

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
        
        //����� ��� ������ ��������� 
        private decimal CalculateCost(DateTime arrivalTime, DateTime departureTime)
        {
            // ������������ ��������� (��������, 10 ������ � ���)
            TimeSpan duration = departureTime - arrivalTime;
            return (decimal)duration.TotalHours * 15;
        }
    }
}