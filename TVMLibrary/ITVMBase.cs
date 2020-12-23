using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{
    public interface ITVMBase
    {
        public double StartValue { get; set; }
        public double Rate { get; set; }
        public int Periods { get; set; }
        public double EndValue { get; set; }

        public void Calculate();
    }
}
