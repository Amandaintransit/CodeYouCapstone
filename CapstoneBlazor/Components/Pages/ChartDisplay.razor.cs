using CodeYouCapstone;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.HttpOverrides;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Forms;
namespace CapstoneBlazor.Components.Pages

{
    public partial class ChartDisplay
    {
        [SupplyParameterFromForm]


        public Charts Chart { get; set; }

        protected override void OnInitialized() => Chart ??= new();
        private void Submit()
        {

            decimal PrimaryAGI = Income.CalculateAGI(chart.GrossIncomePrimary, chart.MonthlyMaintenancePrimary, chart.MonthlyDeductionPriorChildrenPrimary);
            decimal SecondaryAGI = Income.CalculateAGI(chart.GrossIncomeSecondary, chart.MonthlyMaintenanceSecondary, chart.MonthlyDeductionPriorChildrenSecondary);

        }
        decimal PrimaryAGI { get; set; }
        decimal SecondaryAGI { get; set; }
    }

}