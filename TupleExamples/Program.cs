using System;

namespace TupleExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //use a tuple to create values on the fly
            var (retString, retDouble, retInt) = DemoClass.TupleMethod("World", 17.94);
            Console.WriteLine(retString + " " + retDouble);

            //use existing values
            string myString;
            double myDouble;
            int myInt;

            (myString, myDouble, myInt) = DemoClass.TupleMethod("World", 17.94);
            Console.WriteLine(myString + " " + myDouble + " " + myInt);
        }
    }
}
