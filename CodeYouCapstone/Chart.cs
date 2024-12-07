using System.ComponentModel.DataAnnotations.Schema;
namespace CodeYouCapstone
{
    public class Charts
    {
        
        public string PrimaryFirstName { get; set; } = string.Empty;
        public string PrimaryLastName { get; set; } = string.Empty;
        public string SecondaryFirstName { get; set; } = string.Empty;
        public string SecondaryLastName { get; set; } = string.Empty;
        public string SecondaryCustodian { get; set; } = string.Empty ;
        public int NumberOfChildren { get; set; }
        public decimal GrossIncomePrimary {  get; set; }
        public decimal GrossIncomeSecondary { get; set; }
        public decimal MonthlyMaintenancePrimary { get; set; }
        public decimal MonthlyMaintenanceSecondary { get; set; }
        public decimal MonthlyDeductionPriorChildrenPrimary { get; set; }
        public decimal MonthlyDeductionPriorChildrenSecondary { get; set; }
        //AGI primary can only be 0 if caring for child under 3
        
        public bool IsCaringForChildUnderThree { get; set; } = false;
       //cannot be 0 -minimum wage must be imputed
     
        public decimal ChildCarePrimary { get; set; }  
        public decimal ChildCareSecondary { get; set; }
        public decimal HealthInsurancePremiumPrimary { get; set; } 
        public decimal HealthInsurancePremiumSecondary {  get; set; }
        

        
    }
}
