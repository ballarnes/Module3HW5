using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW5.BridgePattern.Abstractions;

namespace Module3HW5.BridgePattern
{
    public class AdditionalTeacher : Teacher
    {
        public AdditionalTeacher(ISubject subject)
            : base(subject)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine($"{(char)22} Получаем оплату после одного дополнительного занятия.");
        }
    }
}
