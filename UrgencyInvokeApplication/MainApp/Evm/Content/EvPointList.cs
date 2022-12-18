namespace MainApp.Evm.Content
{
    public class EvPointList : EvmValueList, IEditable
    {
        public void Set(int idx, EvmValue editValue)
        {
            this[idx] = editValue;
        }
    }
}