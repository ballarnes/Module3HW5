using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW5.BridgePattern.Abstractions;

namespace Module3HW5.BridgePattern
{
    public class EnglishSubject : ISubject
    {
        public void Teach()
        {
            Console.WriteLine($"{(char)16} Рассказываем правила грамматики.");
        }

        public void Examine()
        {
            Console.WriteLine($"{(char)16} Проверяем сочинение.");
        }
    }
}
