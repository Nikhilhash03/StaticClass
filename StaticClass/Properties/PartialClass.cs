using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass.Properties
{
    partial class subjects
    {
        public void maths()
        {
            Console.WriteLine("Maths is a Easy Subject");
        }
    }
    internal class PartialClass
    {
        static void Main(string[] args)
        {
            nikhil obj = new nikhil();
            obj.display();
            obj.maths();
            obj.science();
            obj.english();
            obj.noname();
            
        }
    }
}
