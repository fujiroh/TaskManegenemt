using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MainApp.Extension;

namespace MainApp.PieChart
{
    /// <summary>
    ///　円グラの要素リスト
    /// </summary>
    public class PieChartList : IEnumerable<IPieChartContent>
    {
        private List<IPieChartContent> _pieChartContents;

        public IPieChartContent this[int index] => _pieChartContents[index];

        public PieChartList()
        {
            _pieChartContents = new List<IPieChartContent>();
        }

        public PieChartList(IEnumerable<IPieChartContent> pieChartValues)
        {
            _pieChartContents = new List<IPieChartContent>();
            _pieChartContents.AddRange(pieChartValues);
        }

        public IEnumerable<MainApp.PieChart.PieDrawInfo> CratePieShapeInfos(Point centerPoint, Size size)
        {
            var angle = 0D;
            foreach (var content in _pieChartContents)
            {
                var sweepAngle = GetSweepAngle(content.Value);
                yield return content.CreateDrawInfo(centerPoint, size, angle, sweepAngle);
                angle += sweepAngle;
            }
        }

        private double GetSweepAngle(double value)
        {
            var totalValue = GetTotalValue();
            return value.Convert(totalValue);
        }

        public void AddContent(IEnumerable<IPieChartContent> values)
        {
            _pieChartContents.AddRange(values);
        }

        public void Clear()
        {
            _pieChartContents.Clear();
        }

        private double GetTotalValue()
        {
            return _pieChartContents.Sum(x => x.Value);
        }

        public IEnumerator<IPieChartContent> GetEnumerator()
        {
            foreach (var value in _pieChartContents)
            {
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}