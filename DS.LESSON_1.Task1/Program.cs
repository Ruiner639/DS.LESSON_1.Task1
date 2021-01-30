using System;

namespace DS.LESSON_1.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name;
            string[] Date;
            Name = new string[1];
            Name[0] = "John Smith";
            Date = new string[3];
            Date[0] = "begin";
            Date[1] = "mid";
            Date[2] = "end";
            Console.WriteLine("Name index is automatically selected 0");
            int idName = 0;
            Console.WriteLine("Enter date of birth index(0,1,2)");
            //John Smith’s birthday is in beginning [mid, end] of March
            int idBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Name[idName] + "’s birthday is in " + Date[idBirth] + " of March");
        }
    }
}
