using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Repository
    {
        private readonly Writer _writer;
        public string answer;

        public Repository()
        {
            _writer = new();
        }
        public void Comparssion(string message)
        {

            if (message == "Сколько времени?")
                answer = "20:40";
            else if (message == "Какая погода в Москве?")
                answer = "Хорошая";
            else if (message == "Какой курс доллара?")
                answer = "30";
            else answer =  "";

            _writer.Write(answer);
        }
    }
}
