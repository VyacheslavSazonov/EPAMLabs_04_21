using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Parent : Human
    {
        public string Job { get; set; }

        public override void actions()
        {
            Console.WriteLine("Идти на работу");
        }
        public override void leisure()
        {
            Console.WriteLine("Cмотреть фильм");
        }
    }
}