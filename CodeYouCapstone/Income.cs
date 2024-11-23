using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYouCapstone
{
    public class Income
    {

        private decimal _grossIncome;

        public decimal GrossIncome
            {
                get { return _grossIncome; }
                set { _grossIncome = value; }
            }

            private decimal _maintenance;

            public decimal Maintenance
            {
                get { return _maintenance; }
                set { _maintenance = value; }
            }
            private decimal _priorChildDeduction;
            public decimal PriorChildDeduction
            {
                get { return _priorChildDeduction; }
                set { _priorChildDeduction = value; }
            }
            public static decimal CalculateAGI(decimal GrossIncome, decimal Maintenance, decimal PriorChildDeduction)
            {
                return GrossIncome - (Maintenance + PriorChildDeduction);
            }
        
    }
}
