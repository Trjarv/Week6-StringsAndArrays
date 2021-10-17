using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed laused "Hello World!" tärniga (*)

            string helloW = "Hello World!";

            /* for(int i = 0; i < helloWorld.Length; i++) 
             {
                 helloW[i] = '*'; //sõnad on muutumatud
             }*/

            helloW = helloW.Replace('o', '*');
            //helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }
    }
}
