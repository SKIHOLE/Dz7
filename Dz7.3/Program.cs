using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7._3
{
    public class MyClass
    {
        public string change;
    }

    public struct MyStruct
    {
        public string change;
    }

    public class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
        }

        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "змінено";
        }

        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.change = "не змінено";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "не змінено";

            Console.WriteLine("Початкові значення:");
            Console.WriteLine("MyClass: " + myClass.change);
            Console.WriteLine("MyStruct: " + myStruct.change);

            ClassTaker(myClass);
            StructTaker(ref myStruct);

            Console.WriteLine("\nЗначення після виклику методів:");
            Console.WriteLine("MyClass: " + myClass.change);
            Console.WriteLine("MyStruct: " + myStruct.change);
            Console.ReadKey();
        }
    }
}
