using System.Collections.Generic;
using System.Drawing;

namespace MainApp.Evm.Content
{
    public sealed class EvPointList : EvmValueList, IEditable
    {
        private const string STR_EV = "EV";

        public EvPointList() : base()
        {
            LegendColor = Color.Green;
        }

        public EvPointList(IEnumerable<EvmValue> values) : base(values)
        {
            LegendColor = Color.Green;
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