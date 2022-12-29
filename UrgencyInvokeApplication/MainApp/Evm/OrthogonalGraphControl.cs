using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MainApp.Evm.Content;

namespace MainApp.Evm
{
    public partial class OrthogonalGraphControl : UserControl
    {
        private EvmModel _evmModel = new EvmModel();
        private readonly IDisposable _subscribe;

        public OrthogonalGraphControl()
        {
            InitializeComponent();
            _subscribe = CreateSubscriber();
        }

        public void SetModelAndInitialize(EvmModel evmModel)
        {
            _evmModel = evmModel;
            SetInitialValue();  
        }

        private void SetInitialValue()
        {
            // 初めに設定されているグラフを削除する
            ClearInitialChart();
            _lineChartControl.ChartAreas.Add(new ChartArea("Evm_Area"));
            foreach (var kv in _evmModel.Map)
            {
                InitializeSeries(kv.Value);
            }
        }

        private void InitializeSeries(EvmValueList valueList)
        {
            // Seriesパラメータの設定
            var chartLegend = valueList.ToString();
            _lineChartControl.Series.Add(chartLegend);
            _lineChartControl.Series[chartLegend].ChartType = SeriesChartType.Line;
            _lineChartControl.Series[chartLegend].Color = valueList.LegendColor;
            _lineChartControl.Series[chartLegend].BorderWidth = 3;
            _lineChartControl.Series[chartLegend].XValueType = ChartValueType.Date;
            var startDate = Math.Floor(_evmModel.Configure.Start.ToOADate());
            // 値を追加
            for (var idx = 0; idx < valueList.Count(); idx++)
            {
                var yValue = valueList.GetAggregateValue(idx).ToHour();
                _lineChartControl.Series[chartLegend].Points.AddXY(startDate + idx, yValue);
            }
        }

        private void ClearInitialChart()
        {
            _lineChartControl.Series.Clear();
            _lineChartControl.ChartAreas.Clear();
        }

        private IDisposable CreateSubscriber()
        {
            return new CompositeDisposable(_evmModel.ContentValueChangedObservable.Subscribe(_ => Invalidate()));
        }

        private void DisposeInternal()
        {
            using (_subscribe)
            {
            }
        }

        private class DummyEvmModel : EvmModel
        {
            private const int POINT_COUNT = 300;
            private const int RANDOM_MAX_VALUE = 36000;

            private static Random rand = new Random(DateTime.Now.Millisecond);

            public static EvmModel CreateDummy()
            {
                return new EvmModel(
                    new EvPointList(CreateRandomEvmValues()),
                    new PvPointList(CreateRandomEvmValues()),
                    new AcPointList(CreateRandomEvmValues()));
            }

            private static IEnumerable<EvmValue> CreateRandomEvmValues()
            {
                for (var i = 0; i < rand.Next(2, POINT_COUNT); i++)
                {
                    yield return CreateRandomValue();
                }
            }

            private static EvmValue CreateRandomValue()
            {
                return EvmValue.CreateFromSecond(rand.Next(0, RANDOM_MAX_VALUE));
            }
        }
    }
}