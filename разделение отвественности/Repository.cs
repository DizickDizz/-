using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Repository
    {

        public string Comparssion(string message)
        {
            if (message == "Сколько времени?")
                return "20:40";
            if (message == "Какая погода в Москве?")
                return "Хорошая";
            if (message == "Какой курс доллара?")
                return "30";
            return "";
        }
    }
}
