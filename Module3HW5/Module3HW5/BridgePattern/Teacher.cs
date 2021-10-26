using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW5.BridgePattern.Abstractions;

namespace Module3HW5.BridgePattern
{
    public abstract class Teacher
    {
        private ISubject _subject;
        public Teacher(ISubject subject)
        {
            _subject = subject;
        }

        public ISubject Subject
        {
            set { _subject = value; }
        }

        public virtual void DoWork()
        {
            _subject.Teach();
            _subject.Examine();
        }

        public abstract void EarnMoney();
    }
}
