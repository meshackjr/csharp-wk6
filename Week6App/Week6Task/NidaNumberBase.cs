using System;
using System.Collections.Generic;
using System.Text;

namespace NidaCloneApp
{
    public class NidaNumberBase:NidaNumberGenerator
    {
        public string NidaIdentityNo { get; set; }

        public NidaNumberBase() {
            this.NidaIdentityNo = GeneratedNumber;
        }
    }
}
