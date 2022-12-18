using System.Windows.Forms;
using MainApp.Evm.Content;

namespace MainApp.Evm
{
    public partial class OrthogonalGraphControl : UserControl
    {
        private readonly EvmModel _evmModel = new EvmModel();
        private OrthogonalGraphModel<EvmValue> _orthogonalGraphModel;

        public OrthogonalGraphControl()
        {
            InitializeComponent();
            SetInitialValue();
        }

        private void SetInitialValue()
        {
            _orthogonalGraphModel = new OrthogonalGraphModel<EvmValue>(
                _evmModel.GetMaxCount(), _evmModel.GetMaxAggregate().Second);
        }

        private void SetModel()
        {
            
        }
    }
}