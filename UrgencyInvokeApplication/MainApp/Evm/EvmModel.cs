using System;
using System.Collections.Generic;
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

        public EvmModelConfigureResult Configure { get; }
        public Dictionary<EvmType, EvmValueList> Map { get; }

        public IObservable<Unit> ContentValueChangedObservable => _acPointList.ContentChangedObservable
            .Merge(_pvPointList.ContentChangedObservable)
            .Merge(_evPointList.ContentChangedObservable);

        public static EvmModel Create(EvmModelConfigureResult result)
        {
            return new EvmModel(result);
        }

        private EvmModel(EvmModelConfigureResult result)
            :this(new EvPointList(),result.PvValueList,new AcPointList())
        {
            Configure = result;
        }

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
    }
}