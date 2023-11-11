using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAb5
{
    public partial class Form1 : Form
    {
        private SeriesCalculator seriesCalculator = new SeriesCalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double start = Convert.ToDouble(textBox1.Text);
                double end = Convert.ToDouble(textBox2.Text);
                double step = Convert.ToDouble(textBox3.Text);

                listBox1.Items.Clear();

                for (double x = start; x <= end; x += step)
                {
                    listBox1.Items.Add($"Цикл: x = {x}, значення ряду: {seriesCalculator.CalculateWithLoop(start, end)}");
                    listBox1.Items.Add($"Рекурсія: x = {x}, значення ряду: {seriesCalculator.CalculateWithRecursion(start, end)}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані");
            }
        }
    }
}
