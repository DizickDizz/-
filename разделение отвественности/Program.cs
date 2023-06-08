using System.Reflection.PortableExecutable;

namespace разделение_отвественности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Reader Reader = new();
            while(true)    
            { 
                Reader.Read();
            }
        }
    }
}