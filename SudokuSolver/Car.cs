using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Car
    {
        private bool on;

        public void TurnOnOff()
        {
            on = !on;
            Console.WriteLine(on ? "The car is on!" : "The car is off!");
        }

        public void Drive()
        {
            if (on)
            {
                Console.WriteLine("Drive car");
            }
            else
            {
                Console.WriteLine("Have to start car first!");
            }
        }
    }
}
