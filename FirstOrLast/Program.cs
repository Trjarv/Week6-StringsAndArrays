using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust 
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            int firstNameLenght = firstName.Length;

            Console.WriteLine("Sisesta perekonnanimi:");
            string LastName = Console.ReadLine();
            int LastNameLenght = LastName.Length;

            if (firstNameLenght > LastNameLenght)
            {
                Console.WriteLine("Eesnimi on pikem, kui perekonnanimi.");
            }
            else
            {
                Console.WriteLine("Perekonnanimi on pikem, kui eesnimi.");
            }
        }
    }
}
