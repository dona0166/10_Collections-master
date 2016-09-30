using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> _assets;

        public Portfolio(List<IAsset> assets) {
            this._assets = assets;
        }
        public Portfolio() : this(new List<IAsset>()) { }

        internal double GetTotalValue() {
            double result = 0.0;
            foreach(IAsset asset in _assets) {
                result = result + asset.GetValue();
            }
            return result;
        }

        internal void AddAsset(IAsset asset) {
            _assets.Add(asset);
        }

        internal IAsset GetAssetByName(string name) {
            IAsset element = null;
            foreach(IAsset asset in _assets) {
                if (asset.GetName().Equals(name)) {
                    element = asset;
                }
            }
            return element;
        }

        internal IList<IAsset> GetAssets() {
            return _assets;
        }

        internal IList<IAsset> GetAssetsSortedByName() {
            _assets.Sort(new StockNameComparator());
            return _assets;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            _assets.Sort(new StockValueComparator());
            return _assets;
        }
    }
}