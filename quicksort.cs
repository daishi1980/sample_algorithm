using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quicksort
{
    class Program
    {
        static void Main( string[] args )
        {
            //var intarray = new int[] { 2, 3, 1, 4, 6, 10, 2 };
            //var intarray = new int[] { 5, 3, 1, 4, 6, 10, 2 };
            var intarray = new int[] { 2, 8, 5, 3, 1, 4, 9, 6, 10, 2 };
            foreach ( var value in intarray )
                Console.WriteLine( value );

            Console.WriteLine();

            Quicksort( intarray, 0, intarray.Length - 1 );
            foreach ( var value in intarray )
                Console.WriteLine( value );

            Console.ReadLine();
        }

        private static void Swap( int[] array, int index1, int index2 )
        {
            var tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }

        private static void Quicksort( int[] array, int first, int last )
        {
            if ( last - first < 1 )
                return;

            int pibot = new System.Random().Next( first, last );
            //int pibot = ( first + last ) / 2;
            Swap( array, first, pibot );
            int ipos = first;
            for ( int i = first; i <= last; i++ )
            {
                if ( i != first && array[i] < array[first] )
                    Swap( array, ++ipos, i );
            }
            Swap( array, first, ipos );
            Quicksort( array, first, ipos );
            Quicksort( array, ipos + 1, last );
        }
    }
}
