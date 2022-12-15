using System;
using System.Drawing;
using System.Windows.Forms;
using Main.Extension;
using Main.PieChart;

namespace Main.RemainTimer
{
    public class TimeContentFactory
    {
        private readonly RemainingTimerModel _remainingTimerModel;
        private readonly IControlPropertyProvider _provider;

        public TimeContentFactory(RemainingTimerModel remainingTimerModel, IControlPropertyProvider provider)
        {
            _remainingTimerModel = remainingTimerModel;
            _provider = provider;
        }

        public IPieChartContent CreateRemainingTimeContent()
        {
            return new TimeContent("残り", Color.Cyan, _provider, _remainingTimerModel.GetRemainingTime);
        }

        public IPieChartContent CreatePassedTimeContent()
        {
            return new TimeContent("経過時間", Color.Gray, _provider, _remainingTimerModel.GetPassedTime);
        }

        private class TimeContent : IPieChartContent
        {
            private readonly IControlPropertyProvider _provider;
            private readonly Func<TimeSpan> _timeGetAction;

            public double Value => _timeGetAction().TotalSeconds;
            public string ContentTitle { get; }
            public Color PieColor { get; }

            public TimeContent(
                string contentTitle,
                Color pieColor,
                IControlPropertyProvider provider,
                Func<TimeSpan> timeGetAction)
            {
                _timeGetAction = timeGetAction;
                _provider = provider;
                ContentTitle = contentTitle;
                PieColor = pieColor;
            }

            public PieDrawInfo CreateDrawInfo(
                Point centerPoint,
                Size size,
                double startAngle,
                double sweepAngle)
            {
                return PieDrawInfo.Create(
                    _provider.ProvideCenterPoint(),
                    RoundSquare(_provider.ProvideSize()),
                    startAngle,
                    sweepAngle,
                    PieColor,
                    ContentTitle);
            }
            
            private static Size RoundSquare(Size size)
            {
                var minEdge = Math.Min(size.Height, size.Width);
                return new Size(minEdge, minEdge);
            }
        }
    }
}