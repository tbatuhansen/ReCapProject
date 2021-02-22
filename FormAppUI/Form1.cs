using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLoad();

        }

        private void DataLoad()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var list = carManager.GetAll();
            dataGridView1.DataSource = list;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                Id = Convert.ToInt32(textBox1.Text),
                BrandId = comboBox1.SelectedIndex,
                ColorId = comboBox2.SelectedIndex,
                ModelYear = textBox2.Text,
                DailyPrice = Convert.ToDecimal(textBox3.Text),
                Description = textBox4.Text
            };
            carManager.Add(car);

            MessageBox.Show("Car Added !");
        }
    }
}
