using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Lamborghini : ICar
    {
        private bool on;

        public void TurnOnOff()
        {
            on = !on;
            Console.WriteLine(on ? "The Lamborghini is on!" : "The Lamborghini is off!");
        }

        public void Drive()
        {
            if (on)
            {
                Console.WriteLine("Drive Lamborghini");
            }
            else
            {
                Console.WriteLine("Have to start Lamborghini first!");
            }
        }
    }
}
