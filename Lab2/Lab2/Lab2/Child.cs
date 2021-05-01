using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Child : Human
    {
        public string Hobby { get; set; }

        public override void actions()
        {
            Console.WriteLine("Идти в школу");
        }
        public override void leisure()
        {
            Console.WriteLine("Идти гулять");
        }
    }
}
