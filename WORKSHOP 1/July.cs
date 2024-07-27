using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1_MHLGIV006
{
    internal class July
    {
        private List<Horse> horses;

        public July()
        {
            horses = new List<Horse>();
        }

        public void AddHorse(Horse horse)
        {
            horses.Add(horse);
        }
        public void DisplayRoster(TextBox text)
        {
           
           string results = $"===================================================================================\r\n";
            results += "                                                         Roster for next race\r\n";
            results += "===================================================================================\r\n";
            for (int i = 0; i < horses.Count; i++)
            {
                results += horses[i].HorseDetails() + "\r\n";
            }
            text.Text = results;
        }
        public Horse Favourite()
        {
            double best_time = horses[0].AverageTime();
            int horse_value = 0;
            for (int i = 1; i < horses.Count; i++)
            {
                if (best_time < horses[i].AverageTime())
                {
                    continue;
                }else if(best_time > horses[i].AverageTime())
                {
                    best_time = horses[i].AverageTime();
                    horse_value = i;
                }
            }
            return horses[horse_value];
        }
    }
}
