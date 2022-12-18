using System;
using System.Drawing;
using MainApp.PieChart;
using MainApp.Extension;

namespace MainApp.RemainTimer
{
    public class TimeContentFactory
    {
        private readonly RemainingTimerModel _remainingTimerModel;
        private readonly IControlPropertyProvider _provider;
        private readonly Color _remainTimeColor;
        private readonly Color _passedTimeColor;
        private const string STR_REMAINING_TIME = "残り時間";
        private const string STR_PASSED_TIME = "経過時間";

        public TimeContentFactory(RemainingTimerModel remainingTimerModel,
            IControlPropertyProvider provider,
            Color remainTimeColor,
            Color passedTimeColor)
        {
            _remainingTimerModel = remainingTimerModel;
            _provider = provider;
            _passedTimeColor = passedTimeColor;
            _remainTimeColor = remainTimeColor;
        }

        public IPieChartContent CreateRemainingTimeContent()
        {
            return new TimeContent(_provider, STR_REMAINING_TIME, _remainTimeColor, _remainingTimerModel.GetRemainingTime);
        }

        public IPieChartContent CreatePassedTimeContent()
        {
            return new TimeContent(_provider, STR_PASSED_TIME, _passedTimeColor, _remainingTimerModel.GetPassedTime);
        }

        private class TimeContent : IPieChartContent
        {
            private readonly Func<TimeSpan> _timeGetterGetterFunction;
            private readonly IControlPropertyProvider _provider;

            public double Value => _timeGetterGetterFunction().TotalSeconds;
            public string ContentTitle { get; }
            public Color PieColor { get; }

            public TimeContent(IControlPropertyProvider provider,
                string contentTitle,
                Color pieColor,
                Func<TimeSpan> timeGetterFunction)
            {
                _provider = provider;
                ContentTitle = contentTitle;
                PieColor = pieColor;
                _timeGetterGetterFunction = timeGetterFunction;
            }

            public PieDrawInfo CreateDrawInfo(Point centerPoint, Size size, double startAngle, double sweepAngle)
            {
                return PieDrawInfo.Create(
                    _provider.ProvideCenterPoint(),
                    _provider.ProvideSize().RoundSquare(),
                    startAngle,
                    sweepAngle,
                    PieColor,
                    ContentTitle);
            }
        }
    }
}