using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Reader
    {

        public string Read()
        {
            Console.WriteLine("Введите сообщение");
            return Console.ReadLine();
        }
    }
}
