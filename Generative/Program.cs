using System;

  namespace test
  {
    public class Program
    {
        static void Main()
        {
            FindType<int>(5);
            SwapTypes<int>(5, 4);
        }

        public static void FindType<T>(T Type)
            {
            Console.WriteLine(Type);

            }
        

        public static void SwapTypes<T>(T Type1, T Type2)
        {
            T Type3 =  default;
            T temporary = Type3;
            Type3 = Type1;
            Type1 = Type2;
            Type2 = Type3;
            Console.WriteLine($"{Type1} {Type2}");



        }



    }



  }








