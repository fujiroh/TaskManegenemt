using System.Collections.Generic;

namespace MainApp.Evm.Content
{
    public class EvPointList : EvmValueList, IEditable
    {
        private const string STR_EV = "EV";

        public EvPointList() : base()
        {
        }

        public EvPointList(IEnumerable<EvmValue> values) : base(values)
        {
        }
        
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