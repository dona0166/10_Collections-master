using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator : IComparer <IAsset>
    {
        public int Compare(IAsset first, IAsset second) {
            int result = 0;
            //Remember when you compare objects by their state (values of instance-fields) you should NEVER
            //use the "==" operator (it compares the references and is true if, and only if they refer to
            //the same object). Always use Equals(), Compare() or CompareTo
            if ( first.GetName().CompareTo( second.GetName() ) > 0) {
                result = 1;
            }
            else if (first.GetName().CompareTo(second.GetName()) < 0) {
                result = -1;
            }
            return result;

            //Easy solution: return first.GetName().CompareTo(second.GetName())
        }
    }
}