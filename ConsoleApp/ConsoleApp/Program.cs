using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region try,catch,finally
            //string[] student = { "Memmed","Rafiq","Shems"};
            //int[] num = { 12, 14, 15};
            //Console.WriteLine("Eded daxil edin:");
            //string num = Console.ReadLine();
            //try
            //{
            //    int x = int.Parse(num);
            //    Console.WriteLine(x);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Daxil olunmush deyer edede chevrile bilmir");
            //}
            //finally
            //{
            //    Console.WriteLine("Finnaly ishledi");
            //}
            #endregion

            //Console.WriteLine(Sum(n2:6,n1:3));
            //Student("Memmed", "Rafiq", "Elgiz");
            //PersonInfo("Memmed", "Necefov");
            int x1 = 10;
            int x2 = x1;
            x2 = 20;

            int[] arr1 = { 10, 20, 30 };
            int[] arr2 = arr1;
            arr2[0] = 100;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);
        }

        #region method
        /// <summary>
        /// This method return sum
        /// </summary>
        /// <param name="n1">first parametr</param>
        /// <param name="n2">second parametr</param>
        /// <returns></returns>
        //static int Sum(int n1, int n2)
        //{
        //    return n1 + n2;
        //}

        //static void PersonInfo(string name, string surname)
        //{
        //    //Console.WriteLine(name+" "+surname);
        //    //Console.WriteLine($"Adi:{name}, Soyadi:{surname}");
        //    Console.WriteLine("Adi:{0}, Soyadi:{1}",name,surname);
        //    Student("Ibrahim", "Huseyn", "Nesib");
        //}

        //static void PersonInfo(string name,int age)
        //{
        //    Console.WriteLine(name+" "+age);
        //}
        /*static void Student(params string[] names)
        {
            foreach(string name in names)
            {
                Console.Write(name+" ");
            }
        }*/
        #endregion
    }
}
