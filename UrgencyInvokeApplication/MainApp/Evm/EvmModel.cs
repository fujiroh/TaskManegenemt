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

        public Dictionary<EvmType, EvmValueList> Map { get; }

        public IObservable<Unit> ContentValueChangedObservable => _acPointList.ContentChangedObservable
            .Merge(_pvPointList.ContentChangedObservable)
            .Merge(_evPointList.ContentChangedObservable);

        public EvmModel() : this(new EvPointList(), new PvPointList(), new AcPointList())
        {
        }

        public EvmModel(EvPointList evPointList, PvPointList pvPointList, AcPointList acPointList)
        {
            _evPointList = evPointList;
            _pvPointList = pvPointList;
            _acPointList = acPointList;
            Map = CreateMap();
        }

        private Dictionary<EvmType, EvmValueList> CreateMap()
        {
            return new Dictionary<EvmType, EvmValueList>()
            {
                {EvmType.Ac, _acPointList},
                {EvmType.Pv, _pvPointList},
                {EvmType.Ev, _evPointList},
            };
        }

        public int GetMaxCount()
        {
            return Math.Max(_evPointList.Count(), Math.Max(_acPointList.Count(), _pvPointList.Count()));
        }

        public EvmValue GetMaxAggregate()
        {
            return Map.Values.Aggregate(EvmValue.Zero, (current, value) => EvmValue.Max(current, value.GetAggregate()));
        }

        public IEnumerable<EvmValue> CreatePointSet(int idx)
        {
            try
            {
                return Map.Select(kv => kv.Value[idx]);
            }
            catch (IndexOutOfRangeException e)
            {
                Debug.WriteLine(e);
                return CreateEmptySet();
            }
        }

        public IEnumerable<EvmValue> CreateEmptySet() => Enumerable.Repeat(EvmValue.Zero, Map.Count);
    }
}