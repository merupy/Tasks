using System;

namespace FunctionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of your array:");
            int arraysize = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("Enter your numbers:");
            int[] newArray = new int[arraysize];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool checkZero()
            {
                foreach (var items in newArray)
                {
                    if (items <= 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool checkEven()
            {
                foreach (var items in newArray)
                {
                    if (items % 2 == 0)
                    {

                        return true;
                    }
                }
                return false;
            }
            if (checkZero() && checkEven())
            {
                Console.WriteLine("function array");
            }
            else
            {
                Console.WriteLine("not function array");
            }
        }
    }
}
