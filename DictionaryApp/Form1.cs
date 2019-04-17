using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        Dictionary<int, FastestCars> carsRank = new Dictionary<int, FastestCars>()
            {
                {1, new FastestCars("Nissan", "GTR") },
                {2, new FastestCars("BMW", "M4") },
                {3, new FastestCars("Audi", "RS6") },
                {4, new FastestCars("BMW", "760M") }
            };
        public Form1()
        {
            InitializeComponent();
            foreach(int key in carsRank.Keys)
            {
                number.Items.Add(key);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            FastestCars fastestCars = carsRank[(int)number.SelectedItem];

            markLabel.Text = fastestCars.Marka;
            modelName.Text = fastestCars.Model;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
