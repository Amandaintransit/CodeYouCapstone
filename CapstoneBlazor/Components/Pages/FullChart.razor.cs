using CodeYouCapstone;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace CapstoneBlazor.Components.Pages
{
    public partial class FullChart
    {
       


        [SupplyParameterFromForm]
        public string PrimaryFirstName { get; set; } = string.Empty;
        [SupplyParameterFromForm]
        public string PrimaryLastName { get; set; } = string.Empty;
        [SupplyParameterFromForm]
        public string SecondaryFirstName { get; set; } = string.Empty;
        [SupplyParameterFromForm]
        public string SecondaryLastName { get; set; } = string.Empty;
        [SupplyParameterFromForm]

        public int NumberOfChildren { get; set; }
        [SupplyParameterFromForm]
        public decimal GrossIncomePrimary { get; set; }
        [SupplyParameterFromForm]
        public decimal GrossIncomeSecondary { get; set; }
        [SupplyParameterFromForm]
        public decimal MonthlyMaintenancePrimary { get; set; }
        [SupplyParameterFromForm]
        public decimal MonthlyMaintenanceSecondary { get; set; }
        [SupplyParameterFromForm]
        public decimal MonthlyDeductionPriorChildrenPrimary { get; set; }
        [SupplyParameterFromForm]
        public decimal MonthlyDeductionPriorChildrenSecondary { get; set; }
        [SupplyParameterFromForm]
        //AGI primary can only be 0 if caring for child under 3

        
        public bool IsCaringForChildUnderThree { get; set; } = false;
        //cannot be 0 -minimum wage must be imputed
        [SupplyParameterFromForm]
        public decimal ChildCarePrimary { get; set; }
        [SupplyParameterFromForm]
        public decimal ChildCareSecondary { get; set; }
        [SupplyParameterFromForm]
        public decimal HealthInsurancePremiumPrimary { get; set; }
        [SupplyParameterFromForm]
        public decimal HealthInsurancePremiumSecondary { get; set; }
        public bool IsUnderSelfSupportReserveThreshold { get; set; } = false;
        [Parameter]
        public decimal CombinedAGI { get; set; }
        [Parameter]
        public decimal PercentageAGIPrimary { get; set; }
        [Parameter]
        public decimal PercentageAGIPrimarySecondary { get; set; }
        [Parameter]
        public decimal InitialObligation { get; set; }
        [Parameter]
        public decimal TotalGuidelineAmount { get; set; }
        [Parameter]
        public decimal PrimaryCustodianAllocation { get; set; }
        [Parameter]
        public decimal SecondaryCustodianAllocation { get; set; }
        [Parameter]
        public decimal FinalObligation { get; set; }

      

     //      Income.CalculateAGI(((Chart)context.Model).GrossIncomePrimary, ((Chart)context.Model).MonthlyMaintenancePrimary, ((Chart)context.Model).MonthlyDeductionPriorChildrenPrimary);

      //     Income.CalculateAGI(((Chart)context.Model).GrossIncomeSecondary, ((Chart)context.Model).MonthlyMaintenanceSecondary, ((Chart)context.Model).MonthlyDeductionPriorChildrenSecondary);
/*public Charts Chart { get; set; }

protected override void OnInitialized()
{
 base.OnInitialized();
}

private void HandleFormSubmission(EditContext context)
{


 Income.CalculateAGI(((Charts)context.Model).GrossIncomePrimary, ((Charts)context.Model).MonthlyMaintenancePrimary, ((Charts)context.Model).MonthlyDeductionPriorChildrenPrimary);

 Income.CalculateAGI(((Charts)context.Model).GrossIncomeSecondary, ((Charts)context.Model).MonthlyMaintenanceSecondary, ((Charts)context.Model).MonthlyDeductionPriorChildrenSecondary);

}
}
*/

    }
}
