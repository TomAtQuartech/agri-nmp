﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERVERAPI.Utility
{
    public class ChemicalBalances
    {
        public long balance_AgrN { get; set; }        
        public long balance_AgrP2O5 { get; set; }
        public long balance_AgrK2O { get; set; }
        public long balance_CropN { get; set; }
        public long balance_CropP2O5 { get; set; }
        public long balance_CropK2O { get; set; }
    }
}
