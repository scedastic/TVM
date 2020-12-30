using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{
    public interface ITVMAnnuity:ITVMBase
    {
        public double CashFlow { get; set; }
    }
}
