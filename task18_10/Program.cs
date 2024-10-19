namespace task18_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int n;

            //do
            //{
            //    Console.WriteLine("tam eded daxil edin : ");
            //    n = int.Parse(Console.ReadLine());
            //    bool iscomposite = false;

            //    if (n < 2)
            //    {
            //        Console.WriteLine($"{n} sade ve ya murekkeb eded deyil.");
            //    }
            //    else
            //    {
            //        for (int i = 2; i < n; i++)
            //        {
            //            if (n % i == 0)
            //            {
            //                iscomposite = true;
            //                break;
            //            }
            //        }

            //        if (iscomposite)
            //        {
            //            Console.WriteLine($"{n} murekkeb ededdir.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{n} sade ededdir.");
            //        }
            //    }

            //} while (true);
            #endregion


            #region Task 2
            int n;
            do
            {
                Console.Write("Ededi daxil edin: ");
                n = int.Parse(Console.ReadLine());
                int digitCount = 0;
                int temp = n;

                while (temp > 0)
                {
                    temp /= 10;
                    digitCount++;
                }
                Console.WriteLine($"{n} ededinin mertebe sayi: {digitCount}");

            } while (n != 0);
            #endregion

        }
    }
}