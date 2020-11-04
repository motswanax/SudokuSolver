using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Ferrari : ICar
    {
        private bool on;

        public void TurnOnOff()
        {
            on = !on;
            Console.WriteLine(on ? "The Ferrari is on!" : "The Ferrari is off!");
        }

        public void Drive()
        {
            if (on)
            {
                Console.WriteLine("Drive Ferrari");
            }
            else
            {
                Console.WriteLine("Have to start Ferrari first!");
            }
        }
    }
}
