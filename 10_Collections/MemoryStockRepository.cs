using System.Collections.Generic;
using System.Collections;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private long _id = 1;
        Dictionary<long, Stock> adictionary = new Dictionary<long, Stock>();

        public MemoryStockRepository()
        {

        }
        public MemoryStockRepository(long id)
        {
            this._id = id;
        }

        public long NextId()
        {
            return _id++;
        }

        

        public void SaveStock(Stock astock)
        {
            if (adictionary.ContainsValue(astock) == false && astock != null)
            {

                astock.Id = _id;
                adictionary.Add(_id, astock);
                NextId();
            }
            
            
        }

        public Stock LoadStock(long anid)
        {
            
                return adictionary[anid];
  
        }

        public ICollection FindAllStocks()
        {
            return adictionary;
        }

        public void Clear()
        {
            adictionary.Clear();
        }


    }
}