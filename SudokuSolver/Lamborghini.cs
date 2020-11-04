using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Lamborghini : Car
    {
        public override void Drive()
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
