using System.Drawing;
using MainApp.PieChart;
using MainApp.Extension;

namespace MainApp.RemainTimer
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
            return new RemainingTimeContent(_remainingTimerModel, _provider);
        }

        public IPieChartContent CreatePassedTimeContent()
        {
            return new PassedTimeContent(_remainingTimerModel, _provider);
        }

        private class RemainingTimeContent : IPieChartContent
        {
            private readonly RemainingTimerModel _remainingTimerModel;
            private readonly IControlPropertyProvider _provider;

            public double Value => _remainingTimerModel.GetRemainingTime().TotalSeconds;
            public string ContentTitle => "残り時間";
            public Color PieColor => Color.LimeGreen;

            public RemainingTimeContent(RemainingTimerModel remainingTimerModel, IControlPropertyProvider provider)
            {
                _remainingTimerModel = remainingTimerModel;
                _provider = provider;
            }

            public PieDrawInfo CreateDrawInfo(
                Point centerPoint,
                Size size,
                double startAngle,
                double sweepAngle)
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

        private class PassedTimeContent : IPieChartContent
        {
            private readonly RemainingTimerModel _remainingTimerModel;
            private readonly IControlPropertyProvider _provider;
            public double Value => _remainingTimerModel.GetPassedTime().TotalSeconds;
            public string ContentTitle => "経過時間";
            public Color PieColor => Color.Black;

            public PassedTimeContent(RemainingTimerModel remainingTimerModel, IControlPropertyProvider provider)
            {
                _remainingTimerModel = remainingTimerModel;
                _provider = provider;
            }

            public PieDrawInfo CreateDrawInfo(
                Point centerPoint,
                Size size,
                double startAngle,
                double sweepAngle)
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