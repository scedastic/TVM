using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{
    public class FV : ITVMBase
    {
        /// <summary>
        /// Given the start value, interest rate and number ofcompounding periods
        /// Calculate the ending value.
        /// </summary>
        protected double _startValue;
        protected int _periods;
        protected double _rate;
        protected double _endValue;

        public double StartValue
        {
            get => _startValue;
            set
            {
                _startValue = value;
                Calculate();
            }
        }

        public double Rate 
        { 
            get => _rate;
            set => _rate = value;
        }
        public int Periods 
        {
            get => _periods;
            set
            {
                _periods = value;
                Calculate();
            }
        }
        public double EndValue 
        { 
            get => _endValue;
            set => throw new NotImplementedException();
        }

        public FV(double startValue, double rate, int periods)
        {
            _startValue = startValue;
            _rate = rate;
            _periods = periods;
            Calculate();
        }
        public virtual void Calculate() => _endValue = _startValue * Math.Pow(1 + _rate, _periods);
    }
}
