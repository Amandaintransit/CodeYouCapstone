namespace CapstoneBlazor.Components.Pages
{
    public partial class IncomePrimary
    {

        public decimal GrossIncomePrimary { get; set; }

        public decimal MaintenancePrimary { get; set; }

        public decimal PriorChildDeductionsPrimary { get; set; }


        public static decimal CalculateAGI(decimal GrossIncome, decimal Maintenance, decimal PriorChildDeduction)
        {
            return GrossIncome - (Maintenance + PriorChildDeduction);
        }

    }
}