using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using MainApp.Evm.Content;

namespace MainApp.Evm
{
    public class EvmModel
    {
        private readonly AcPointList _acPointList;
        private readonly PvPointList _pvPointList;
        private readonly EvPointList _evPointList;

        public IObservable<Unit> ContentValueChangedObservable => _acPointList.ContentChangedObservable
            .Merge(_pvPointList.ContentChangedObservable)
            .Merge(_evPointList.ContentChangedObservable);

        public EvmModel()
        {
            _acPointList = new AcPointList();
            _pvPointList = new PvPointList();
            _evPointList = new EvPointList();
        }

        public EvmModel(EvPointList evPointList, PvPointList pvPointList, AcPointList acPointList)
        {
            _evPointList = evPointList;
            _pvPointList = pvPointList;
            _acPointList = acPointList;
        }

        public int GetMaxCount()
        {
            return Math.Max(_evPointList.Count(), Math.Max(_acPointList.Count(), _pvPointList.Count()));
        }

        public EvmValue GetMaxAggregate()
        {
            var acValue = _acPointList.GetAggregate();
            var evValue = _evPointList.GetAggregate();
            var pvValue = _pvPointList.GetAggregate();

            return EvmValue.Max(acValue, evValue, pvValue);
        }

        public IEnumerable<EvmValue> CreatePointSet(int idx)
        {
            try
            {
                return new[] {_acPointList[idx], _evPointList[idx], _pvPointList[idx]};
            }
            catch (IndexOutOfRangeException e)
            {
                Debug.WriteLine(e);
                return Enumerable.Empty<EvmValue>();
            }
        }
    }
}