using System;
using System.Linq;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Hobby[] hobbies = { new Hobby(1, "Walking"), new Hobby(2, "Biking"), new Hobby(33, "Gaming") };

            var hobby = hobbies.Where(h => h.Name.Equals("Walking")).Select(h => h.Name);
            var anotherHobby = from h in hobbies where h.Name.Equals("Walking") select h;

            var everyHobbyExceptFirstOne = hobbies.Skip(1);
            var swimmingHobby = hobbies.Skip(1).Take(1);
        }
    }

    class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Hobby(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
    }
}
