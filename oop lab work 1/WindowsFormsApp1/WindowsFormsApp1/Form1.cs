using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // список, у якому зберігатимуться всі планети
        private List<Planet> planets = new List<Planet>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double mass, diameter;
            int satellites;

            // Перевірка введених чисел
            if (!double.TryParse(txtMass.Text, out mass))
            {
                MessageBox.Show("Некоректне значення для маси!");
                return;
            }

            if (!double.TryParse(txtDiameter.Text, out diameter))
            {
                MessageBox.Show("Некоректне значення для діаметра!");
                return;
            }

            if (!int.TryParse(txtSatellites.Text, out satellites))
            {
                MessageBox.Show("Некоректне значення для кількості супутників!");
                return;
            }

            // Створення планети
            Planet p = new Planet(name, mass, diameter, satellites);

            planets.Add(p);
            listBox1.Items.Add(p.ToString());

            // Очищення полів
            txtName.Clear();
            txtMass.Clear();
            txtDiameter.Clear();
            txtSatellites.Clear();
        }
    }
    // Клас Planet з властивостями
    public class Planet
    {
        public string Name { get; set; }      // назва планети
        public double Mass { get; set; }      // маса (кг)
        public double Diameter { get; set; }  // діаметр (км)
        public int Satellites { get; set; }   // кількість супутників

        // Конструктор (задає значення при створенні об’єкта)
        public Planet(string name, double mass, double diameter, int satellites)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Satellites = satellites;
        }

        // Перевизначений метод ToString() – як планета буде відображатися у списку
        public override string ToString()
        {
            return $"{Name} | Маса: {Mass} кг | Діаметр: {Diameter} км | Супутники: {Satellites}";
        }
    }
}
