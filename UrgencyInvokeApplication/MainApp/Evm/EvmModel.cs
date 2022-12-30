using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string Title { get; }
        public DateTime StartDate { get; }
        public DateTime LimitDate { get; }
        public Dictionary<EvmType, EvmValueList> Map { get; }

        public IObservable<Unit> ContentValueChangedObservable => _acPointList.ContentChangedObservable
            .Merge(_pvPointList.ContentChangedObservable)
            .Merge(_evPointList.ContentChangedObservable);

        public static EvmModel Create(EvmModelConfigureResult result)
        {
            return new EvmModel(result);
        }

        public static EvmModel Empty => new EvmModel(EvmModelConfigureResult.Default);

        private EvmModel(EvmModelConfigureResult result)
            : this(new EvPointList(), result.PvValueList, new AcPointList())
        {
            Title = result.Title;
            StartDate = result.Start;
            LimitDate = result.End;
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

        private int GetDayCountFromStart()
        {
            return (DateTime.Today - StartDate).Days + 1;
        }

        public override string ToString()
        {
            var limitDate = "期限日：" + LimitDate.ToString(CultureInfo.InvariantCulture) + "\n";
            var dayCount = "経過：" + GetDayCountFromStart() + "日" + "\n";
            var evmInfo = Map.Values.Aggregate("", (current, value) => current + value.GetInfo() + "\n");
            return limitDate + dayCount + evmInfo;
        }
    }
}