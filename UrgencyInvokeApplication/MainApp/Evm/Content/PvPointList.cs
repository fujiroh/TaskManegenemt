namespace MainApp.Evm.Content
{
    public class PvPointList : EvmValueList, IEditable
    {
        private const string STR_PV = "PV";

        public void Set(int idx, EvmValue editValue)
        {
            this[idx] = editValue;
        }

        public override string ToString()
        {
            return STR_PV;
        }
    }
}