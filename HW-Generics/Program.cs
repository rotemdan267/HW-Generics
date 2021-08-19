using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrr = new int[100];
            for (int i = 0; i < 10; i++)
            {
                arrr[i] = i + 1;
            }
            GenericArr<int> arr = new GenericArr<int>(arrr, 10);
            arr.ActivateReadOnlyMode();
            try
            {
                arr.Add(84);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            arr.CancelReadOnlyMode();
            try
            {
                arr.Add(84);
                arr.Delete(5);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();

        }
    }
}
