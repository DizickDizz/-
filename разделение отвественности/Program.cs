namespace разделение_отвественности
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Reader reader = new();
            Repository repository = new();
            Writer writer = new();
            
            Compiler compiler = new(reader,repository,writer);

            while (true)
            {
                compiler.Compile();
            }
        }
    }
}