using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramLog programLog = new ProgramLog();

            //programLog.WriteLog();

            int[] myIntArray = new int[]
            {
                0,1,2,3,4,5,6,7,8,9
            };

            int index = 22;
            Console.WriteLine( $"Return value of {nameof(GetValueFromArray)} is: {GetValueFromArray(myIntArray, index)} ");

        }

        static int GetValueFromArray( int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException e)
            {
                throw new ArgumentException("index is out of range", nameof(index), e);
            }
        }
    }
}
