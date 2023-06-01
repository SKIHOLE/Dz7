using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Введіть інформацію про {i + 1}-й поїзд:");
                Console.Write("Назва пункту призначення: ");
                string destination = Console.ReadLine();
                trains[i].Destination = destination;
                Console.Write("Номер поїзда: ");
                int.TryParse(Console.ReadLine(), out int trainNumb);
                trains[i].TrainNumber = trainNumb;
                Console.Write("Час відправлення: ");
                trains[i].DepartureTime = Console.ReadLine();
            }
            int.TryParse(Console.ReadLine(), out int TrainNumb);
            bool trainFound = false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == TrainNumb)
                {
                    Console.WriteLine($"Назва пункту призначення: {trains[i].Destination}");
                    Console.WriteLine($"Час відправлення: {trains[i].DepartureTime}");
                    trainFound = true;
                    break;
                }
            }
            if (!trainFound)
            {
                Console.WriteLine("Поїзд з таким номером не знайдено.");
            }

            Console.ReadKey();
        }
    }
    }
    struct Train
    {
        public string Destination;
        public int TrainNumber;
        public string DepartureTime;
    }

