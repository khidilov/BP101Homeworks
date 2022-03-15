using System;

namespace _14ofMarch_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region // 1. Verilmiş ədədin sadə ədəd olub olmamasını print edən console app yazın.
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool isComposite = false;
            //if (num == 0 || num == 1)
            //{
            //    Console.WriteLine("Neither prime nor composite");
            //}
            //else
            //{
            //    for (int i = 2; i * i < num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isComposite = true;
            //            break;
            //        }
            //    }
            //    if (isComposite == true) Console.WriteLine("Number is Composite");
            //    else Console.WriteLine("Number is Prime");
            //}
            #endregion

            #region // 2.Verilmiş ədədin neçə mərtəbəli olduğunu print edən  console app yazın. (məsələn: 321 ədədi 3 mərtəbəlidir, 23125 ədədi 5 mərtəbəlidir.)
            //int count = 1, num = Convert.ToInt32(Console.ReadLine());
            //while (num > 9)
            //{
            //    num /= 10;
            //    count++;
            //}
            //Console.WriteLine("Consists of" + " "+ count +" "+ "digit(s)");
            #endregion

            #region //3.Verilmiş ədədin palindrom olub olmadığını print edən  console app yazın.
            //int lstDig = 0, N = Convert.ToInt32(Console.ReadLine()), copN = N, revN = 0;
            //if (N <= 9) Console.WriteLine("The number must have at least two digits");
            //else
            //{
            //    while (copN != 0)
            //    {
            //        lstDig = copN % 10;
            //        copN /= 10;
            //        revN = revN * 10 + lstDig;
            //    }
            //    if (N == revN) Console.WriteLine("Number is Palindromic");
            //    else Console.WriteLine("Number is NOT Palindromic");
            //}
            #endregion
        }
    }
}
