using System;
using System.Drawing;
using System.Windows.Forms;
using Hazzik.Maybe;

namespace MainApp.PieChart
{
    [Serializable]
    public partial class PieChartControl : UserControl
    {
        private readonly ToolTipVisualizer _toolTipVisualizer;
        private readonly PieChartDrawer _pieGraphDrawer;
        private readonly PieChartList _pieChart;
        private Point _mousePos;

        public PieChartControl()
        {
            InitializeComponent();

            _pieChart = new PieChartList();
            _pieGraphDrawer = new PieChartDrawer(_pieChart);
            _toolTipVisualizer = new ToolTipVisualizer(this);
        }

        // 参照は残しておきたいので中身のみ更新するようにする
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

        private int GetSmallerEdge()
        {
            return Math.Min(Height, Width);
        }

        private Maybe<IPieChartValue> GetHitContent(Point mousePos)
        {
            var edgeLength = GetSmallerEdge();
            return _pieGraphDrawer.GetHitContent(mousePos, CenterPoint, new Size(edgeLength, edgeLength));
        }

        private void PieChartControl_Paint(object sender, PaintEventArgs e)
        {
            var valueOrDefault = GetHitContent(_mousePos).GetValueOrDefault(PieValueInfo.Empty);
            _pieGraphDrawer.Draw(e.Graphics, CenterPoint, GetSmallerEdge() / 2, valueOrDefault.Ratio * 100, ForeColor, Font);
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
            
            ChangeToolTipVisual(GetHitContent(e.Location));
            Invalidate();
        }

        private void ChangeToolTipVisual(Maybe<IPieChartValue> value)
        {
            _toolTipVisualizer.Show(value, _mousePos);
        }

        private void DisposeInternal()
        {
        }

        private class ToolTipVisualizer
        {
            private const int TOOLTIP_MARGIN = 10;

            private readonly UserControl _control;
            private readonly ToolTip _toolTip = new ToolTip();

            public ToolTipVisualizer(UserControl control)
            {
                _control = control;
                _toolTip.Active = true;
            }

            public void Show(Maybe<IPieChartValue> value, Point viewPoint)
            {
                if (value.HasValue)
                {
                    var toolTipPoint = new Point(viewPoint.X + TOOLTIP_MARGIN, viewPoint.Y + TOOLTIP_MARGIN);
                    ShowToolTip(value.GetValueOrDefault().ContentTitle, toolTipPoint);
                    return;
                }
                Hide();
            }

            private void ShowToolTip(string title, Point viewPoint)
            {
                _toolTip.Show(title, _control, viewPoint);
            }

            private void Hide()
            {
                _toolTip.Hide(_control);
            }
        }
    }
}