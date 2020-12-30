using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{
    /// <summary>
    /// Future Value of an Ordinary Annuity 
    /// where payments are made at the end of the period
    /// 
    /// FV = CashFlow * ( Math.Power(1 + rate, periods) - 1 ) / rate
    /// 
    /// </summary>
    public class FVAnnuity : FV, ITVMAnnuity
    {
        private double _cashFlow;
        public double CashFlow 
        { 
            get => _cashFlow; 
            set
            {
                _cashFlow = value;
                Calculate();
            }
        }

        public FVAnnuity(double cashFlow, double rate, int periods):base(0, rate, periods)
        {
            _cashFlow = cashFlow;
            Calculate();
        }

        public override void Calculate()
        {
            var multiplier = (Math.Pow(1 + Rate, Periods) - 1) / Rate;
            _endValue = CashFlow * multiplier;
        }
    }
}
