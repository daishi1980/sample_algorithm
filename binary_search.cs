using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_search
{
    class Program
    {
        static void Main( string[] args )
        {
            var strarray = new string[] { "A", "B", "C", "D", "E" };
            Console.WriteLine( Search( "D", strarray ) );
            Console.WriteLine( Search( "A", strarray ) );
            Console.WriteLine( Search( "Z", strarray ) );
            Console.WriteLine( Search( "E", strarray ) );

            Console.ReadLine();
        }

        static private int Search( string word, string[] array )
        {
            int low, high, mid, cmp;
            low = 0;
            high = array.Length - 1;
            while ( low <= high )
            {
                mid = ( low + high ) / 2;
                cmp = word.CompareTo( array[mid] );
                if ( cmp < 0 )
                    high = mid - 1;
                else if ( cmp > 0 )
                    low = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
