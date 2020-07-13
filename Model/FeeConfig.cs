using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TransFeeCalc.Model
{
    public class FeeConfig
    {
        public FeeConfig()
        {
            fees = new Collection<FeeConfigParams>();
        }
        public ICollection<FeeConfigParams> fees { get; set; }
        
    }
}