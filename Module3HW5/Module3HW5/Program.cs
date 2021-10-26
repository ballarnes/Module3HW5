using System;
using Module3HW5.CompositePattern;
using Module3HW5.BridgePattern;

namespace Module3HW5
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var start = new Program();
            Console.WriteLine("=====COMPOSITE_PATTERN=====");
            start.CompositeRun();
            Console.WriteLine("=====BRIDGE_PATTERN=====");
            start.BridgeRun();
        }

        private void CompositeRun()
        {
            Component europe = new Composite("Europe");
            Component ukraine = new Composite("Ukraine");
            Component kyiv = new Leaf("Kyiv");
            Component kharkiv = new Leaf("Kharkiv");
            ukraine.Add(kyiv);
            ukraine.Add(kharkiv);
            europe.Add(ukraine);

            europe.Print();
            Console.WriteLine();

            Component northAmerica = new Composite("North America");
            Component usa = new Composite("USA");
            Component arizona = new Composite("Arizona");
            Component illinois = new Composite("Illinois");
            Component phoenix = new Leaf("Phoenix");
            Component tucson = new Leaf("Tucson");
            Component chicago = new Leaf("Chicago");
            Component springfield = new Leaf("Springfield");
            Component peoria = new Leaf("Peoria");
            arizona.Add(phoenix);
            arizona.Add(tucson);
            illinois.Add(chicago);
            illinois.Add(springfield);
            illinois.Add(peoria);
            usa.Add(arizona);
            usa.Add(illinois);
            northAmerica.Add(usa);

            illinois.Remove(peoria);
            northAmerica.Print();
            Console.WriteLine();
        }

        private void BridgeRun()
        {
            Console.WriteLine("Teacher 1:");
            Teacher teacher1 = new SchoolTeacher(new MathSubject());
            teacher1.DoWork();
            teacher1.EarnMoney();

            teacher1 = new AdditionalTeacher(new EnglishSubject());
            teacher1.DoWork();
            teacher1.EarnMoney();

            Console.WriteLine("Teacher 2:");
            Teacher teacher2 = new AdditionalTeacher(new MathSubject());
            teacher2.DoWork();
            teacher2.EarnMoney();
        }
    }
}