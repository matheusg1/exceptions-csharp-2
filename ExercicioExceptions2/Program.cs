using System;

namespace ExercicioExceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data2 = DateTime.Parse("24/11/1997");
            DateTime data = DateTime.Parse("27/11/1997");
            try
            {
            var r1 = new Reservation(2, data, data2);

            r1.Duration();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}