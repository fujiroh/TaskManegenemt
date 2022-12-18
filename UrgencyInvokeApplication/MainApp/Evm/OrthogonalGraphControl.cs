using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MainApp.Evm.Content;

namespace MainApp.Evm
{
    public partial class OrthogonalGraphControl : UserControl
    {
        private readonly EvmModel _evmModel;

        public OrthogonalGraphControl()
        {
            InitializeComponent();
            _evmModel = DummyEvmModel.CreateDummy();
            ClearInitialChart();
            SetInitialValue();
        }

        private void SetInitialValue()
        {
            _lineChartControl.ChartAreas.Add(new ChartArea("Evm_Area"));
            foreach (var kv in _evmModel.Map)
            {
                var chartLegend = kv.Value.ToString();
                _lineChartControl.Series.Add(chartLegend);
                _lineChartControl.Series[chartLegend].ChartType = SeriesChartType.Line;
                for (var idx = 0; idx < kv.Value.Count(); idx++)
                {
                    var yValue = kv.Value.GetAggregateValue(idx).ToHour();
                    _lineChartControl.Series[chartLegend].Points.AddY(yValue);
                }
            }
        }

        private void ClearInitialChart()
        {
            _lineChartControl.Series.Clear();
            _lineChartControl.ChartAreas.Clear();
        }

        private class DummyEvmModel : EvmModel
        {
            private const int POINT_COUNT = 200;
            private const int RANDOM_MAX_VALUE = 3600000;

            private static Random rand = new Random(DateTime.Now.Millisecond);

            public static EvmModel Instance { get; } = new DummyEvmModel();

            public static EvmModel CreateDummy()
            {
                return new EvmModel(
                    new EvPointList(CreateRandomEvmValues()),
                    new PvPointList(CreateRandomEvmValues()),
                    new AcPointList(CreateRandomEvmValues()));
            }

            private static IEnumerable<EvmValue> CreateRandomEvmValues()
            {
                for (var i = 0; i < rand.Next(2,POINT_COUNT); i++)
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