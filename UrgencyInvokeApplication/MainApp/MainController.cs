using System.Collections.Generic;
using System.Windows.Forms;
using Hazzik.Maybe;
using MainApp.Evm;
using MainApp.Evm.Content;

namespace MainApp
{
    public class MainController
    {
        private readonly List<EvmModel> _evmModelStore;

        public MainController()
        {
            _evmModelStore = new List<EvmModel>();
        }

        public void CreateNewEvm()
        {
            var mayBeConfigure = Configure();
            if (!mayBeConfigure.HasValue)
            {
                return;
            }
            var configure = mayBeConfigure.GetValueOrDefault();
            var evmModel = new EvmModel(new EvPointList(), configure.PvValueList, new AcPointList());
            _evmModelStore.Add(evmModel);
            using (ControlWindowBase dlg = new ControlWindowBase())
            {
                var orthogonalGraphControl = new OrthogonalGraphControl();
                orthogonalGraphControl.SetModelAndInitialize(evmModel);
                dlg.SetControl(orthogonalGraphControl);
                dlg.ShowDialog();
            }
        }

        public Maybe<EvmModelConfigureResult> Configure()
        {
            using (var dlg = new EvmModelConfigurationDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return new Maybe<EvmModelConfigureResult>(dlg.CreateResult());
                }

                return Maybe<EvmModelConfigureResult>.Nothing;
            }
        }
    }
}