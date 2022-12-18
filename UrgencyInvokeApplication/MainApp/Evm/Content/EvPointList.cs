namespace MainApp.Evm.Content
{
    public class EvPointList : EvmValueList, IEditable
    {
        private const string STR_EV = "EV";

        public void Set(int idx, EvmValue editValue)
        {
            this[idx] = editValue;
        }

        public override string ToString()
        {
            return STR_EV;
        }
    }
}