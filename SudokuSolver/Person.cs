using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Person
    {
        private Car car;

        public Person(Car car)
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
