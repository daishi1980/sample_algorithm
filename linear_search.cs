using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linear_search
{
    class Program
    {
        static void Main( string[] args )
        {
            var strarray = new string[]{ "A", "B", "C", "D", "E" };
            Console.WriteLine( Search( "D", strarray ) );

            Console.ReadLine();
        }

        static private int Search( string word, string[] array )
        {
            for ( int ii = 0; ii < array.Length; ii++ )
                if ( array[ii] == word )
                    return ii;

            return -1;
        }
    }
}
