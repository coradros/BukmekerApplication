using BukmekerLibrary;
using System;
using System.Threading;

namespace BukmekerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bukmeker bukmeker = new Bukmeker();

                bukmeker.SetNewRate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                Thread.Sleep(3000);
            }
        }
    }

    
}
