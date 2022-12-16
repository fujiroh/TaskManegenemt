using System;
using System.Drawing;
using Main.PieChart;

namespace Main.RemainTimer
{
    public class TimeContentFactory
    {
        private readonly RemainingTimerModel _remainingTimerModel;
        private readonly IControlPropertyProvider _controlPropertyProvider;
        private readonly Color _remainPieColor;
        private readonly Color _passedPieColor;

        private const string STR_PASSED_TIME = "経過時間";
        private const string STR_REMAIN_TIME = "残り時間";

        public TimeContentFactory(
            RemainingTimerModel remainingTimerModel,
            IControlPropertyProvider controlPropertyProvider,
            Color remainPieColor,
            Color passedPieColor)
        {
            _controlPropertyProvider = controlPropertyProvider;
            _remainingTimerModel = remainingTimerModel;
            _remainPieColor = remainPieColor;
            _passedPieColor = passedPieColor;
        }

        public IPieChartContent CreateRemainingTimeContent()
        {
            return new TimeContent(STR_REMAIN_TIME, _remainPieColor, _controlPropertyProvider, _remainingTimerModel.GetRemainingTime);
        }

        public IPieChartContent CreatePassedTimeContent()
        {
            return new TimeContent(STR_PASSED_TIME, _passedPieColor, _controlPropertyProvider, _remainingTimerModel.GetPassedTime);
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