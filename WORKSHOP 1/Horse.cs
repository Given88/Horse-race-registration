using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1_MHLGIV006
{
    internal class Horse
    {
        private string name;
        private int age;
        private int height;
        private double[] times;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public double[] Times
        {
            get { return times; }
            set { times = value; }
        }

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
