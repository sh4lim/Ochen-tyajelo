using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForech
{
    internal class ChageLingua
    {
        private JsonController jsonController = new JsonController();
        private Json ObjectJson;

        public ChageLingua() 
        {
            ObjectJson = jsonController.JsonStart();
        }

        public void Chage(int i) 
        {
            switch(i)
            {
                case 1:
                    ru();
                    break;

                case 2:
                    ue();
                    break;
                default:
                    Chage(i);
                    break;
            }
        }

        public void ru()
        {
            ObjectJson.StarMessage = "Ввдетите № в диапозоне 1-9";
            ObjectJson.linguaChade = "Выберете язык\n1.RU/nEN";
            jsonController.JsonSave(ObjectJson);

        }

        public void ue()
        {
            ObjectJson.StarMessage = "Enter the number in the range 1-9";
            ObjectJson.linguaChade = "Select язык\n1.RU\n2.EN";
            jsonController.JsonSave(ObjectJson);

        }
    }
}
