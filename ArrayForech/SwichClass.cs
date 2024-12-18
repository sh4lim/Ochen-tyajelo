using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForech
{
    internal class SwichClass
    {
        static Comads comads = new Comads();
        public void Swich(int i)
        {
            Comads comads = new Comads();
            switch (i)
            {
                case 1:
                    comads.Number1();
                    break;
                case 2:
                    comads.Number2();
                    break;
                case 3:
                    comads.Number3();
                    break;
                case 4:
                    comads.Number4();
                    break;
                case 5:
                    comads.Number5();
                    break;
                case 6:
                    comads.Number6();
                    break;
                case 7:
                    comads.Number7();
                    break;
                case 8:
                    comads.Number8();
                    break;
                case 9:
                    comads.Number9();
                    break;
                default:
                    Console.WriteLine("Ввдетите № в диапозоне 1-6");
                    break;
            }
        }
    }
}
