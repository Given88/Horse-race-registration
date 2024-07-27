using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WORKSHOP_1
{
    internal class Horse
    {
        private string Name;
        private int Age;
        private int Height;
        private double[] Times;

        public Horse() { }
        public Horse(string name, int age, int height, double[] times)
        {
            Name = name;
            Age = age;
            Height = height;
            Times = times;
        }
        public double AverageTime()
        {
            double average = (Times[0] + Times[1] + Times[2]) / 3;
            return Math.Round(average,2); 
        }

        public string HorseDetails()
        {
            string results = $"Name: {Name}\tAge: {Age} years\tHeight: {Height} hands\t Average run: {AverageTime().ToString()} seconds";
            return results ;
        }
    }
}
