namespace MainApp.Evm.Content
{
    public class PvPointList : EvmValueList, IEditable
    {
        public void Set(int idx, EvmValue editValue)
        {
            this[idx] = editValue;
        }
    }
}