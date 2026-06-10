using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass.Properties
{
    partial class subjects
    {
        public void science()
        {
            Console.WriteLine("Science Subject");
        }
    }
    class nikhil : subjects
    {
        public void display()
        {
            Console.WriteLine("INhertiance is acheived");
            base.english();
        }
    }
    internal class class2
    {
    }
}
