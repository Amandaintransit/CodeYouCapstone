namespace CapstoneBlazor.Components.Pages
{
    public partial class ChartResults
    {
        public decimal AGIPrimary { get; set; }
        public decimal AGIPrimarySecondary { get; set; }
        public bool IsUnderSelfSupportReserveThreshold { get; set; } = false;
        public decimal CombinedAGI { get; set; }

        public decimal PercentageAGIPrimary { get; set; }
        public decimal PercentageAGIPrimarySecondary { get; set; }
        public decimal InitialObligation { get; set; }
        public decimal TotalGuidelineAmount { get; set; }
        public decimal PrimaryCustodianAllocation { get; set; }
        public decimal SecondaryCustodianAllocation { get; set; }
        public decimal FinalObligation { get; set; }
    }
}
