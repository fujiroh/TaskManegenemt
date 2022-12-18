using System.Collections.Generic;

namespace MainApp.Evm.Content
{
    public class AcPointList : EvmValueList
    {
        private const string STR_AC = "AC";

        public AcPointList() : base()
        {
        }

        public AcPointList(IEnumerable<EvmValue> values) : base(values)
        {
        }
        
        public override string ToString()
        {
            return STR_AC;
        }
    }
}