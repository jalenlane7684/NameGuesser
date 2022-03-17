using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NameGuesser
{
    static class Methods
    {

        public static void TypingAnimation(string phrase)
        {
            foreach ( char c in phrase )
            {
                Console.Write(c);
                if (c.Equals('!') || c.Equals('?'))
                {
                    Thread.Sleep(1000);
                }
                else if ( c.Equals('.') )
                {
                    Thread.Sleep(500);
                } else if ( c.Equals(',') || c.Equals(';') || c.Equals(':'))
                {
                    Thread.Sleep(250);
                } else
                {
                    Thread.Sleep(25);
                }
                

            }
        }
    }
}
