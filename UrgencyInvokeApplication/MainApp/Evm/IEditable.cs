using MainApp.Evm.Content;

namespace MainApp.Evm
{
    public interface IEditable
    {
        void Set(int idx, EvmValue editValue);
    }
}