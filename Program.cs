using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            var selectedPeople = from p in people
                                 where p.Length == 3
                                 select p;
        }
    }
}
