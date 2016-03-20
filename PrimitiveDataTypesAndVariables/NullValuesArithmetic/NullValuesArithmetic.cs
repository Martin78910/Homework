using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? num = null;
            double? num2 = null;
            Console.WriteLine("{0} \n{1}", num,num2);
            Console.WriteLine("{0}+300 \n{1} +50", num, num2);
        }
    }
}
