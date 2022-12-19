using System.Collections.Generic;
using System.Drawing;

namespace MainApp.Evm.Content
{
    public sealed class AcPointList : EvmValueList
    {
        private const string STR_AC = "AC";

        public AcPointList() : base()
        {
            LegendColor = Color.Red;
        }

        public AcPointList(IEnumerable<EvmValue> values) : base(values)
        {
            LegendColor = Color.Red;
        }
        
        public override string ToString()
        {
            return STR_AC;
        }
    }
}