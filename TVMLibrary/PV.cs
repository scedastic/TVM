using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{
    public class PV : ITVMBase
    {
        /// <summary>
        /// Find the present value of a given amount in the future
        /// after a number of compounding periods at a particular
        /// interest rate.
        /// </summary>
        private double _startValue;
        private int _periods;
        private double _rate;
        private double _endValue;

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
            set
            {
                _rate = value;
                Calculate();
            }
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
            set
            {
                _endValue = value;
                Calculate();
            }
        }

        public PV(double endValue, double rate, int periods)
        {
            _endValue = endValue;
            _rate = rate;
            _periods = periods;
            Calculate();
        }
        public void Calculate()
        {
            _startValue = _endValue / Math.Pow(1 + _rate, _periods);
        }
    }
}
