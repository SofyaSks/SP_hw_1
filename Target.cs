using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    internal class Target
    {
        Random rand = new Random();
        

        public int Strength { get; set; }

        public void setStrength()
        {
            Strength = rand.Next(50, 250);
        }

        public void showStrength()
        {
           Console.WriteLine($"Target strength: {Strength}");
        }
    }
}
