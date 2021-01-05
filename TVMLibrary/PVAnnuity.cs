using System;
using System.Collections.Generic;
using System.Text;

namespace TVMLibrary
{ 
    /// <summary>
    /// Future Value of an Ordinary Annuity 
    /// where payments are made at the end of the period
    /// 
    /// PV = CashFlow * ( 1 - Math.Power(1 + rate, -1 * periods) / rate)
    /// 
    /// </summary>
public class PVAnnuity:PV, ITVMAnnuity
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

        public PVAnnuity(double cashFlow, double rate, int periods) : base(0, rate, periods)
        {
            _cashFlow = cashFlow;
            Calculate();
        }

        public override void Calculate()
        {
            var multiplier = (1 - Math.Pow(1 + Rate, -1 * Periods)) / Rate;
            _startValue = CashFlow * multiplier;
        }


    }
}
