using System;

namespace Consolc
{
    enum  Days
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wenesday = 4,
        Tharday = 5,
        Friday = 6,
        Satrday = 7,
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Name");
           string Name = Console.ReadLine();
            Console.WriteLine("Enter your days Sunday =1,Monday = 2,Tuesday = 3, Wenesday = 4,Tharday,Friday = 5,Friday = 6,Satrday =7  ");

            int value = int.Parse(Console.ReadLine());
            Days myDays = (Days)value;
            Console.WriteLine("My Name is :" + Name + " My Birthday ");


        }
    }
}
