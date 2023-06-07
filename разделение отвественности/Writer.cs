using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Writer
    {

        public void Write(string message) 
        {
            if (message != String.Empty)
                Console.WriteLine(message);
            else return;
        }
    }
}
