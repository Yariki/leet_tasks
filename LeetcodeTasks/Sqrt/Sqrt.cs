using System;

namespace LeetcodeTasks.Sqrt
{
    public class Sqrt
    {
        private readonly int _value;

        public Sqrt(int value)
        {
            _value = value;
        }
        
        // https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Babylonian_method
        public int SolutionOne()
        {
            if (_value == 0) return 0;
            float n,x;
            n = x = _value;
            float y = 1;

            double e = 0.00000000001;
            while (x - y > e)
            {
                x = (x + y) / 2;
                y = n / x;
            }

            return (int)Math.Floor(x);
        }

        // http://en.wikipedia.org/wiki/Newton's_method
        public int SolutionTwo()
        {
            if (_value == 0) return 0;
            double n = 0, p = 0, low, high;
            if( 2 > _value )
                return( _value );
            low  = 0;
            high = _value;
            while( high > low + 1 )
            {
                n = (high + low) / 2;
                p = n * n;
                if( _value < p )
                    high = n;
                else if( _value > p )
                    low = n;
                else
                    break;
            }
            return( _value == (int)p ? (int)Math.Floor(n) : (int)Math.Floor(low));
        }
        
        // https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Babylonian_method
        public int SolutionThree( )
        {
            if (_value == 0) return 0;
            
            // double a = (eventually the main method will plug values into a)
            double a = (double) _value;
            double x = 1;
 
            // For loop to get the square root value of the entered number.
            for( int i = 0; i < _value; i++)
            {
                x = 0.5 * ( x+a / x );
            }
 
            return (int)Math.Floor(x);
        }

        public int SolutionFourth()
        {
            if (_value == 0) return 0;

            return (int)Math.Sqrt((double)_value);
        }
        
        
    }
}