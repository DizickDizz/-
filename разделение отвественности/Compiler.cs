using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разделение_отвественности
{
    public class Compiler
    {
        private readonly Reader _reader;
        private readonly Repository _repository;
        private readonly Writer _writer;

        public string input;
        public string output;
        public Compiler(Reader reader, Repository repository, Writer writer)
        {
            _reader = reader;
            _repository = repository;
            _writer = writer;
        }

        public void Compile()
        {
            input = _reader.Read();

            output = _repository.Comparssion(input);

            _writer.Write(output);
        }
    }
}
