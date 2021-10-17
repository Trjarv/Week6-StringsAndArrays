using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panc" nulliga - 0
            //programm asendal kõik 'a' tähed samas lauses 4-ga

            string sentence = "Don't Panic!";

            sentence = sentence.Replace('o', '0');
            sentence = sentence.Replace('a', '4');

            Console.WriteLine(sentence);
        }
    }
}
