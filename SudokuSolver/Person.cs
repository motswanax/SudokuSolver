using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Person
    {
        private ICar car;

        public Person(ICar car)
        {
            this.car = car;
        }

        public void Drive()
        {
            car.TurnOnOff();
            car.Drive();
        }
    }
}
