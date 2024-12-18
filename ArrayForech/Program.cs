using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using RomanLib;
using static System.Net.Mime.MediaTypeNames;

namespace ArrayForech
{
    internal class Program
    {
        static Proverka proverka = new Proverka();

        static SwichClass swichClass = new SwichClass();

        static ChageLingua chagelingua = new ChageLingua();

        static private JsonController jsonController = new JsonController();
        static private Json ObjectJson;

        static void Main(string[] args)
        {
            start:
            ObjectJson = jsonController.JsonStart();

            Console.WriteLine(ObjectJson.linguaChade);
            chagelingua.Chage(proverka.Type<int>("=>"));

            ObjectJson = jsonController.JsonStart();


            while (true)
            {
                Console.WriteLine(ObjectJson.StarMessage);
                swichClass.Swich(proverka.Type<int>("=>"));
                if (Console.ReadKey(true).Key == ConsoleKey.F1)
                    goto start;
                else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
