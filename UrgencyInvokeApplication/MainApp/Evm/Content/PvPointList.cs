using System.Collections.Generic;
using System.Drawing;

namespace MainApp.Evm.Content
{
    public sealed class PvPointList : EvmValueList, IEditable
    {
        private const string STR_PV = "PV";

        public PvPointList() : base()
        {
            LegendColor = Color.Blue;
        }

        public PvPointList(IEnumerable<EvmValue> values) : base(values)
        {
            LegendColor = Color.Blue;
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