//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StaticClass.Properties
//{
//    sealed class student
//    {
//        int sid;
//        string sname;
//        string college;
//        public student(int sid, string sname, string college)
//        {
//            this.sid = sid;
//            this.sname = sname;
//            this.college = college;
//        }
//        public void display1()
//        {
//            Console.WriteLine("Student id = " + sid);
//            Console.WriteLine("Student name = " + sname);
//            Console.WriteLine("Student college = " + college);
//        }
//    }
//    class college
//    {
//        int cid;
//        string cname;
//        string address;
//        public college(int cid,string cname,string address)
//        {
//            this.cid = cid;
//            this.cname = cname;
//            this.address = address;
//        }
//        public void display2()
//        {
//            Console.WriteLine("College id = " + cid);
//            Console.WriteLine("College name = " + cname);
//            Console.WriteLine("College address = " + address);

//        }
//    }
//    internal class SealedClass
//    {
//        static void Main(string[] args)
//        {
//            student obj = new student(1, "Nikhil", "VIT");
//            obj.display1();

//            college ob = new college(123, "VIT", "Bnglr");
//            ob.display2();
//        }
//    }
//}
