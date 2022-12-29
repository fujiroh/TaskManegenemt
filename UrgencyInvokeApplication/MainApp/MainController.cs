using System.Collections.Generic;
using System.Windows.Forms;
using Hazzik.Maybe;
using MainApp.Evm;

namespace MainApp
{
    public class MainController
    {
        public MainController()
        {
        }

        public void CreateNewEvm()
        {
            var mayBeConfigure = Configure();
            if (!mayBeConfigure.HasValue)
            {
                return;
            }
            var configure = mayBeConfigure.GetValueOrDefault();
            var evmModel = EvmModel.Create(configure);
            
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