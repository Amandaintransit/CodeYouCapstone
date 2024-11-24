using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYouCapstone
{
    public class Chart
    {
        string primaryCustodian;
        string secondaryCustodian;
        decimal grossIncomePrimary;
        decimal grossIncomeSecondary;
        decimal monthlyMaintenancePrimary;
        decimal monthlyMaintenanceSecondary;
        decimal monthlyDeductionPriorChildrenPrimary;
        decimal monthlyDeductionPriorChildrenSecondary;
        decimal AGIPrimary;
        decimal AGIPrimarySecondary;
        decimal CombinedAGI;
        decimal PercentageAGIPrimary;
        decimal PercentageAGIPrimarySecondary;
        decimal InitialObligation;
        decimal childCarePrimary = 0;
        decimal childCareSecondary = 0;
        decimal healthInsurancePremiumPrimary = 0;
        decimal healthInsurancePremiumSecondary = 0;
        decimal totalGuidelineAmount = 0;
        decimal primaryCustodianAllocation = 0;
        decimal secondaryCustodianAllocation = 0;
    }
}
