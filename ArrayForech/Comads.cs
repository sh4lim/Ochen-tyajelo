using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using RomanLib;

namespace ArrayForech
{
    internal class Comads
    {
        static Random rnd = new Random();
        static Proverka proverka = new Proverka();
        public void Number1()
        {
            int[] ar1 = new int[10];
            int[] ar2 = {0,-1,-2,-3,-4,-5,-6,-7,-8,-9};

            for (int i = 0; i < ar1.Length; i++)
            {
                ar1[i] = i;
            }
            
            for (int i = 0; i < ar1.Length;i++)
            {
                if (i % 2 == 1)
                {
                    ar1[i] = ar2[i];
                }
            }

            foreach (var item in ar1)
            {
                Console.WriteLine(item);
            }
        }

        public void Number2() 
        {
            int s = 0;
            int[] ar1 = new int[8];
            int[] ar2 = { 0, -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            int[] ar3 = new int[ar1.Length + ar2.Length];

            for (int i = 0;i < ar1.Length; i++)
            {
                ar1[i] = rnd.Next(1,100);
            }

            for (int i = 0; i < ar1.Length; i++)
            {
                ar3[i] = ar1[i];
            }

            for (int i = ar1.Length; i < ar1.Length + ar2.Length; i++)
            {
                ar3[i] = ar2[s];
                s++;
            }

            foreach (var item in ar3)
            {
                Console.WriteLine(item);
            }
        }
        public void Number3() 
        {
            int[] ar1 = new int[17];
            
            for (int i = 0;i < ar1.Length; i++)
            {
                ar1[i] = rnd.Next(1, 16);
            }

            for (int i = 0;i < ar1.Length - 2 ; i++)
            {
                int result = ar1[i] - ar1[i + 1];
                Console.WriteLine($"{ar1[i]} - {ar1[i + 1]} = {result}");
            }
        }

        public void Number4() 
        {
            int[] ar1 = new int[9];
            int[] ar2 = new int[7];
            int[] ar3 = new int[ar1.Length + ar2.Length];

            for (int i = 0; i < ar1.Length; i++)
            {
                ar1[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < ar2.Length; i++)
            {
                ar2[i] = rnd.Next(1, 200);
            }

            for (int i = 0; i < ar1.Length ; i++)
            {
                ar3[i] = ar1[i];
            }

            for (int i = 0; i < ar2.Length; i++)
            {
                ar3[ar2.Length + i] = ar1[i];
            }
            Array.Sort(ar3);

            foreach (var item in ar3)
            {
                Console.WriteLine(item);
            }


        }
        public void Number5()
        {
            int[] arX = new int[10];
            int[] arY = new int[10];
            int[,] arXY = new int[10, 10];

            for (int i = 0; i < arX.Length; i++)
            {
                arX[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < arY.Length; i++)
            {
                arY[i] = rnd.Next(1, 100);
            }





            for (int i = 0; i < arY.Length; i++)
            {
                for (int j = 0; j < arX.Length; j++)
                {
                    arXY[i, j] = arX[i];
                }
            }

            for(int i = 0;i < arX.Length; i++)
            {
                Console.WriteLine($"{arXY[i,0]} {arXY[i, 1]}\n");
            }
        }
        // не задано
        public void Number6()
        {
            int[,] ar = new int[10,2];
            for (int i = 0; i < ar.GetLength(0) ; i++) 
            {
                
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = proverka.Type<int>($"array[{i},{j}] =>");
                    //ar[i, j] = rnd.Next(1, 100);
                }
                Console.WriteLine($"{ar[i, 0]} {ar[i,1]}");
            }
        }
        //2 list
        public void Number7()
        {
            int[][] ar =
            {
                new int []{1,2,3,4},
                new int []{5,6,7,8},
                new int []{5,6,7,8}
            };
            Array.Sort(ar[ar.Length - 1]);

            for(int i = 0; i < ar.Length; i++)
            {
                for(int j= 0 ; j < ar[i].Length; j++)
                {
                    Console.WriteLine($"array[{i}][{j}] = {ar[i][j]}");
                }
            }
        }

        public void Number8()
        {
            int[,] ar = new int[7,7];

            int[] a = new int[ar.GetLength(1)];
            int[] b = new int[ar.Length];
            for (int i = 0; i < ar.GetLength(0); i++)
            {

                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    //ar[i, j] = proverka.Type<int>($"array[{i},{j}] =>");
                    ar[i, j] = rnd.Next(1, 100);
                }
                Console.WriteLine($"{ar[i, 0]} {ar[i, 1]}");
            }

            for (int i = 0; i < ar.GetLength(1); i++)
            {
                if (i % 2 == 1)
                {
                    a[i] = ar[i, 1];
                }
            }
            a = a.Where(x => x != 0).ToArray();

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine($"{a[i]} + {a[i + 1]} = {a[i] + a[i + 1]}");
            }
        }

        //средние арефметическое для аждого столбца
        public void Number9() 
        {
            int[,] ar = new int[5,6];
            for (int i = 0; i < ar.GetLength(0); i++)
            {

                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    //ar[i, j] = proverka.Type<int>($"array[{i},{j}] =>");
                    ar[i, j] = rnd.Next(1, 100);
                    
                    int s = 0;
                    s = ar[i, j] + s/ar.GetLength(1);
                    Console.WriteLine(s);
                }
            }
        }
    }
}
