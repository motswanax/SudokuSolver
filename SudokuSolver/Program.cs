using System;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Ferrari();
            Person person = new Person(ferrari);
            person.Drive();
        }
    }
}
