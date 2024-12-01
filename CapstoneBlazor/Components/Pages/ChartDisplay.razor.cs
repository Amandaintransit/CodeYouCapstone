using CodeYouCapstone;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace CapstoneBlazor.Components.Pages
{
    public partial class ChartDisplay
    {

       // public string PrimaryCustodianFirstName { get; set; } = string.Empty;
       // public string PrimaryCustodianLastName { get; set; } = string.Empty;
      //  public string SecondaryCustodianFirstName { get; set; } = string.Empty;
      //  public string SecondaryCustodianLastName { get; set; } = string.Empty;

        public int NumberOfChildren { get; set; }
        public decimal GrossIncomePrimary { get; set; }
        public decimal GrossIncomeSecondary { get; set; }
        public decimal? MonthlyMaintenancePrimary { get; set; }
        public decimal? MonthlyMaintenanceSecondary { get; set; }
        public decimal? MonthlyDeductionPriorChildrenPrimary { get; set; }
        public decimal? MonthlyDeductionPriorChildrenSecondary { get; set; }
        //AGI primary can only be 0 if caring for child under 3
        public decimal? AGIPrimary { get; set; }
        public bool IsCaringForChildUnderThree { get; set; } = false;
        //cannot be 0 -minimum wage must be imputed
        public decimal AGIPrimarySecondary { get; set; }
        public bool IsUnderSelfSupportReserveThreshold { get; set; } = false;
        public decimal CombinedAGI { get; set; }

        public decimal PercentageAGIPrimary { get; set; }
        public decimal PercentageAGIPrimarySecondary { get; set; }
        public decimal InitialObligation { get; set; }
        public decimal? ChildCarePrimary { get; set; }
        public decimal? ChildCareSecondary { get; set; }
        public decimal? HealthInsurancePremiumPrimary { get; set; }
        public decimal? HealthInsurancePremiumSecondary { get; set; }
        public decimal TotalGuidelineAmount { get; set; }
        public decimal PrimaryCustodianAllocation { get; set; }
        public decimal SecondaryCustodianAllocation { get; set; }
        public decimal FinalObligation { get; set; }   
    }    
}
