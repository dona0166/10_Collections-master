using System;
using System.Collections.Generic;



namespace _10_Collections 
{
    internal class StockValueComparator : IComparer <IAsset>
    {
        
        public int Compare(IAsset asset1, IAsset asset2)
        {
            int result = 0;

            if (asset1.GetValue().CompareTo(asset2.GetValue()) > 0)
            {
                result = -1;
            }
            else if (asset1.GetValue().CompareTo(asset2.GetValue()) < 0)
            {
                result = 1;
            }
            return result;

            //if (asset1.GetValue() != asset2.GetValue())
            //{
            //    if (asset1.GetValue() < asset2.GetValue())
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            //}
            //else
            //{
            //    return 0;
            //}

        }


    }
}