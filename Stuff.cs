using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    // 2nd class: Stuff
    internal class Stuff
    {
         // constructor is only run once, the first time class is instantiated

        private Random random = new Random();

        // SimulateDiceRolls to run through and assign a random number from 1-6 for the die 
        public int[] SimulateDiceRolls(int numThrows)
        {
            int[] results = new int[13]; 

            for (int i = 0; i < numThrows; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;
                results[sum]++;
            }

            return results;
        }

    }
}
