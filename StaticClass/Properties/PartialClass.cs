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
        public virtual void bike(string name)
        {
            Console.WriteLine("This is S1000RR");
        }
    }
    class ply:subjects
    {
        public override void bike(string name)
        {
            Console.WriteLine("This is a Ducati Panigale V4s");
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
            obj.bike("BMW");
            ply x = new ply();
            x.bike("DUCATI");
        }
    }
}
