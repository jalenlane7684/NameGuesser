using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NameGuesser
{
    class Program
    {
        static void Main ( string[] args )
        {
            string hello = "Hello World!";
            DateTime dt = new DateTime(2022, 2, 28);
            Methods.TypingAnimation(hello);
            Console.ReadLine();

            

        }
    }
}
