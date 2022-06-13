using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userFat_TextChanged(object sender, EventArgs e)
        {

        }

        private void userCarbs_TextChanged(object sender, EventArgs e)
        {

        }

        

        public static int FatFromCalories(int fat)
        {
            return fat * 9;
        }
        public static int FatFromCarbs(int carbs)
        {
            return carbs * 4; 
        }

        private void fatButton_Click(object sender, EventArgs e)
        {
            fatLabel.Text = "Calories From Fat: " + FatFromCalories(int.Parse(userFat.Text));
        }

        private void carbButton_Click(object sender, EventArgs e)
        {
            carbsLabel.Text = "Calories From Carbs: " + FatFromCarbs(int.Parse(userCarbs.Text));
        }
    }
}
