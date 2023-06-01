using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7._5
{
    struct Notebook
    {
        public string model;
        public string manufacturer;
        public double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Модель: " + model);
            Console.WriteLine("Виробник: " + manufacturer);
            Console.WriteLine("Вартість: " + price);
        }
    }

    class Program
    {
        static void Main()
        {
            Notebook myNotebook = new Notebook("Asus ZenBook", "Asus", 1500.99);
            myNotebook.DisplayInfo();
        }
    }
}
