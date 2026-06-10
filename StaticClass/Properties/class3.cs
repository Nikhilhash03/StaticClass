using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass.Properties
{
    abstract class razz
    {
        public abstract void noname();
        
    }
    partial class subjects:razz
    {
        public void english()
        {
            Console.WriteLine("English is easy Subject");
        }
        public override void noname()
        {
            Console.WriteLine("abstract class is used");
        }
    }
    internal class class3
    {
    }
}
