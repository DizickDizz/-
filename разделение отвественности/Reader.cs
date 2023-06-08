using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Reader
    {
        private readonly Repository _repository;
        public Reader()
        {
            _repository = new();
        }
        public void Read()
        {
            Console.WriteLine("Введите сообщение");
            _repository.Comparssion(Console.ReadLine());
        }
    }
}
