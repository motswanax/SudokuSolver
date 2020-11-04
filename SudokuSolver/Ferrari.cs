using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Ferrari : Car
    {

        public override void Drive()
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
