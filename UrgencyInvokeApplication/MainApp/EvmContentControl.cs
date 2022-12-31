using System;
using System.Drawing;
using System.Reactive;
using System.Reactive.Disposables;
using System.Windows.Forms;
using MainApp.Evm;

namespace MainApp
{
    public partial class EvmContentControl : UserControl
    {
        private readonly IDisposable _subscribe;
        private Size _lastSize;
        public EvmModel EvmModel { get; set; } = EvmModel.Empty;
        public IObservable<Unit> TitleClickObservable => _titleLabel.TitleClickObservable;

        public EvmContentControl()
        {
            InitializeComponent();
            _lastSize = Size;
            _subscribe = new CompositeDisposable(_titleLabel.ExpandChangedObservable.Subscribe(VisualizeInfo));
            InitializeControl();
        }

        private void EvmContentControl_Load(object sender, EventArgs e)
        {
            // ロード時は閉じた状態で固定
            ResizeControl(false);
        }

        private void InitializeControl()
        {
            _titleLabel.Text = EvmModel.Title;
            _infoText.Text = GetInfoStr();
            _titleLabel.InitializeControl(EvmModel.Title);
        }

        public void SetModel(EvmModel evmModel)
        {
            EvmModel = evmModel;
            InitializeControl();
        }

        private void VisualizeInfo(bool expand)
        {
            var index = tableLayoutPanel1.Controls.GetChildIndex(_infoText);
            tableLayoutPanel1.Controls[index].Visible = expand;
            ResizeControl(expand);
        }

        private void ResizeControl(bool expand)
        {
            if (expand)
            {
                Size = _lastSize;
                return;
            }
            _lastSize = new Size(Size.Width, Size.Height);
            Size = _titleLabel.Size;
        }

        private string GetInfoStr()
        {
            return EvmModel.ToString();
        }

        private void DisposeInternal()
        {
            using (_subscribe)
            {
            }
        }
    }
}