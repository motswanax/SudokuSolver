using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    abstract class Car : ICar
    {
        protected bool on;
        public void TurnOnOff()
        {
            on = !on;
            Console.WriteLine(on ? "The car is on!" : "The car is off!");
        }

        public abstract void Drive();
    }
}
