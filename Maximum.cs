using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Maximum
    {
        public static int MaximumIntegerNumber(int firstvalue, int secondvalue, int thirdvalue)
        {
            if(firstvalue.CompareTo (secondvalue)>0 && firstvalue.CompareTo(thirdvalue)>0 ||
                firstvalue.CompareTo(firstvalue)>=0 && secondvalue.CompareTo(thirdvalue)>0 ||
                secondvalue.CompareTo(firstvalue)>0 && firstvalue.CompareTo(thirdvalue)>=0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            
                {
                    return secondvalue;
                }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)


        }
    }
}
