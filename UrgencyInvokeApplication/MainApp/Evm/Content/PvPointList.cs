using System.Collections.Generic;

namespace MainApp.Evm.Content
{
    public class PvPointList : EvmValueList, IEditable
    {
        private const string STR_PV = "PV";

        public PvPointList() : base()
        {
        }

        public PvPointList(IEnumerable<EvmValue> values) : base(values)
        {
        }

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