using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1_MHLGIV006
{
    public partial class Form1 : Form
    {
        private July july;
        public Form1()
        {
            InitializeComponent();
            july = new July();
        }

        private void add_btn_Clicked(object sender, EventArgs e)
        {

            double[] times = new double[3] { double.Parse(time_1.Text), double.Parse(time_2.Text), double.Parse(time_3.Text) };
            Horse horse = new Horse(name_txt.Text.ToString(), Convert.ToInt32(age_txt.Text), int.Parse(height_txt.Text), times);
            july.AddHorse(horse);
            Display();
            
        }
        private void Display()
        {
            july.DisplayRoster(roster);
        }

        private void winner_btn_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("The next winner will probably be:\r\n" + july.Favourite().HorseDetails(), "Favourite", MessageBoxButtons.OK);
        }
    }
}
