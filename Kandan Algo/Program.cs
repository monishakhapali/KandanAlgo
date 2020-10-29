using System;

namespace Kandan_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
        static void FindSubArray(int[] arr)
        {
            int max_end_here = 0;
            int max_so_far = 0;
           
            for(int i=0; i< arr.Length; i++)
            {
                max_end_here = max_end_here + arr[i];
                
                if (max_end_here < 0)
                {
                    max_end_here = 0;
                    
                }
                if(max_end_here > max_so_far)
                {
                    max_so_far = max_end_here;
                }
            }
        }
    }
}
