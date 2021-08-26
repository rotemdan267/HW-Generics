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
            #region Q1

            int[] arr1 = new int[4] { 4, 3, 8, 2 };
            int[] arr2 = new int[6] { 8, 3, 2, 4, 5, 6 };
            int[] arr3 = Combine<int>(arr1, arr2);

            #endregion

            #region Q2

            //string[] arrr = new string[100];
            //for (int i = 0; i < 10; i++)
            //{
            //    arrr[i] = i + " 1";
            //}
            //GenericArr<string> arr = new GenericArr<string>(arrr, 10);
            //arr.ActivateReadOnlyMode();
            //try
            //{
            //    arr.Add("84");
            //}
            //catch(InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //arr.CancelReadOnlyMode();
            //try
            //{
            //    arr.Add("84");
            //    arr.Delete("2 1");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Q3

            SortedLinkedList<char> arr = new SortedLinkedList<char>();
            arr.Add('e');
            arr.Add('c');
            arr.Add('D');
            arr.Add('B');

            #endregion

            #region Q4

            Student s = new Student()
            {
                ID = 123456789,
                Name = "Shmulik"
            };
            HandleID<Student> hid = new HandleID<Student>();
            hid.ResetID(s);

            #endregion

            #region Q7

            HandleNames<Student> hn = new HandleNames<Student>();
            hn.PrintNameAndType(s);

            #endregion

            Console.ReadLine();

        }
        static T[] Combine<T>(T[] arr1, T[] arr2)
        {
            T[] arr3 = new T[arr1.Length + arr2.Length];
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = arr1.Length; i < arr3.Length; i++)
            {
                arr3[i] = arr2[count];
                count++;
            }
            return arr3;
        }
    }
}
