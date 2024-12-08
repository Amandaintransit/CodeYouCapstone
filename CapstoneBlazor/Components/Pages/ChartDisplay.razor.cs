using CodeYouCapstone;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.HttpOverrides;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace CapstoneBlazor.Components.Pages

{
    public partial class ChartDisplay
    {
        decimal PrimaryAGI { get; set; }
        decimal SecondaryAGI { get; set; }

        [SupplyParameterFromForm]


        public Charts Chart { get; set; }

        protected override void OnInitialized() => Chart ??= new();
        private void HandleFormSubmission(EditContext context)
        {

            PrimaryAGI = Income.CalculateAGI(((Charts)context.Model).GrossIncomePrimary, ((Charts)context.Model).MonthlyMaintenancePrimary, ((Charts)context.Model).MonthlyDeductionPriorChildrenPrimary);
                
           SecondaryAGI = Income.CalculateAGI(((Charts)context.Model).GrossIncomeSecondary, ((Charts)context.Model).MonthlyMaintenanceSecondary, ((Charts)context.Model).MonthlyDeductionPriorChildrenSecondary);

        }

        
        
    }

}