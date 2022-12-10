using System;
using System.Drawing;
using System.Reactive.Subjects;
using System.Windows.Forms;
using Hazzik.Maybe;

namespace MainApp.PieChart
{
    [Serializable]
    public partial class PieChartControl : UserControl
    {
        private const int TOOLTIP_MARGIN = 10;
        private readonly ToolTip _toolTip = new ToolTip();

        private readonly PieChartDrawer _pieGraphDrawer;
        private readonly Subject<Maybe<IPieChartValue>> _valueSubject = new Subject<Maybe<IPieChartValue>>();
        private Point _mousePos;

        private readonly PieChartList _pieChart;
        private IDisposable _subscriber;

        public PieChartControl()
        {
            InitializeComponent();

            _pieChart = new PieChartList();
            _pieGraphDrawer = new PieChartDrawer(_pieChart);
        }

        public PieChartList Contents
        {
            get => _pieChart;
            set
            {
                _pieChart.Clear();
                _pieChart.AddContent(value);
            }
        }

        private Point CenterPoint => new Point(Width / 2, Height / 2);

        private void ActivateToolTip()
        {
            _toolTip.Active = false;
        }

        private int GetSmallerEdge()
        {
            return Math.Min(Height, Width);
        }

        private Maybe<IPieChartValue> GetHitContent(Point mousePos)
        {
            var edgeLength = GetSmallerEdge();
            var size = new Size(edgeLength, edgeLength);
            return _pieGraphDrawer.GetHitContent(mousePos, CenterPoint, size);
        }

        private void PieChartControl_Paint(object sender, PaintEventArgs e)
        {
            var valueOrDefault = GetHitContent(_mousePos).GetValueOrDefault(PieValueInfo.Empty);
            _pieGraphDrawer.Draw(e.Graphics, CenterPoint, GetSmallerEdge() / 2, valueOrDefault.Ratio * 100, ForeColor, Font);
        }

        private void ChangeToolTipVisual(Maybe<IPieChartValue> value)
        {
            if (value.HasValue)
            {
                ShowTooltip(value.GetValueOrDefault());
            }
            HideToolTip();
        }

        private void ShowTooltip(IPieChartValue contentValue)
        {
            var toolTipLocation = new Point(_mousePos.X + TOOLTIP_MARGIN, _mousePos.Y + TOOLTIP_MARGIN);
            _toolTip.Show(contentValue.ContentTitle, this, toolTipLocation);
        }

        private void HideToolTip()
        {
            _toolTip.Hide(this);
        }

        // リサイズ
        private void PieChartControl_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        // マウス移動
        private void PieChartControl_MouseMove(object sender, MouseEventArgs e)
        {
            _mousePos = e.Location;
            _valueSubject.OnNext(GetHitContent(e.Location));
            Invalidate();
        }

        private void DisposeInternal()
        {
            using (_subscriber)
            {
            }
        }
    }
}