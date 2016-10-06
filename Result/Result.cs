using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    class Result
    {
        public double Physics { set; get; }
        public double Chemistry { set; get; }
        public double Math { set; get; }
        private double avarage;

        public double GetAvarage()
        {
            avarage = (Physics + Chemistry + Math) / 3;
            return avarage;
        }

        public string GradeLetter()
        {
            string letter;

           
           
           
           
             if (avarage >= 40 && avarage < 50)
            {
                letter = "D";
            }
                 else if (avarage >= 50 && avarage < 60)
            {
                letter = "C";
            }
                 else if (avarage >= 60 && avarage < 70)
            {
                letter = "B";
            }
                 else if (avarage >= 70 && avarage < 80)
            {
                letter = "A";
            }
            else  if (avarage >= 80)
            {
                letter = "A+";
            }
            else
            {
                letter = "F";
            }

            return letter;
        }
    }
}
