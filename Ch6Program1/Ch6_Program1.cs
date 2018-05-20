using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;
using System.Windows.Forms;

namespace Ch6_Program1
{
    class Ch6_Program1
    {
        static void Main(string[] args)
        {
            CT.Header(out CT.LengthOfTopLine, "Ch6_Program1",
                "to use random numbers and looping");

            int minValue = 1000;
            int maxValue = 0;
            int numOfEvens = 0;
            string display = "";
            Random numb = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randNum = numb.Next(0, 1001);
                if (randNum % 2 == 0)
                {
                    numOfEvens++;
                }
                if (randNum >= maxValue)
                {
                    maxValue = randNum;
                }
                if (randNum <= minValue)
                {
                    minValue = randNum;
                }
                display += (i+1) + ". " + randNum + "\t\t";
            }

            string displayInfo = "\n\nThere are " + numOfEvens + " even numbers listed above.\n"
            + "The smallest number is " + minValue + ".\nThe largest number is " + maxValue
            + ".\nThe range of values is " + (maxValue - minValue) + ".";

            display += displayInfo;
            MessageBox.Show(display, "Random Number's:");

            CT.Footer();
        }
    }
}
