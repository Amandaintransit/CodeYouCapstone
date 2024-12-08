using System.Security;
using System.Transactions;

namespace CodeYouCapstone
{
    public class Obligation
    {
        public static void Main(string[] args)
        {
            //Need to Add Validation Logic
            //Need to Add Currency

            string userInput = string.Empty;
           
            decimal childCarePrimary = 0;
            decimal childCareSecondary = 0;
            decimal healthInsurancePremiumPrimary = 0;
            decimal healthInsurancePremiumSecondary = 0;
            decimal totalGuidelineAmount = 0;
            decimal primaryCustodianAllocation = 0;
            decimal secondaryCustodianAllocation = 0;

            decimal finalObligation = 60;

            
            
           

           /* Income primaryIncome = new Income();
            Console.WriteLine("Monthly Income: ");
            primaryIncome.GrossIncome = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Maintenance Obligation, if any:  ");
            primaryIncome.Maintenance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Obligation for prior born children:  ");
            primaryIncome.PriorChildDeduction = decimal.Parse(Console.ReadLine());

            
            Console.WriteLine("Provide the following information for the other parent/custodian\nFirst Name: ");
            string firstNameSecondaryCustodian = Console.ReadLine();
            Console.WriteLine("Last Name:  ");
            string lastNameSecondaryCustodian = Console.ReadLine();

            Income secondaryIncome = new Income();
            Console.WriteLine("Monthly Income: ");
            secondaryIncome.GrossIncome = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Maintenance Obligation, if any:  ");
            secondaryIncome.Maintenance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Obligation for prior born children:  ");
            secondaryIncome.PriorChildDeduction = decimal.Parse(Console.ReadLine());
           

           
           // decimal combinedAGI = AGIPrimary + AGISecondary
           // decimal primaryPercentage = PrimaryAGI / combinedAGI;
           // decimal secondaryPercentage = SecondaryAGI / combinedAGI;

            //Will need to read data from chart to extract the amount and assign it to a variable.
            Console.WriteLine($"The primary residential parent's Adjusted Gross Income is:  {PrimaryAGI}, {primaryPercentage} percent of the combined income.\nThe other parent/custodian's Adjusted Gross Income is:  {SecondaryAGI}, {secondaryPercentage} percent of the combined income. \nWith a combined income of {combinedAGI}, the total support amount for {numberOfChildren} children is CHART AMOUNT HERE");
            decimal guidelineAmountOfSupport = 0;

            totalGuidelineAmount = childCarePrimary + childCareSecondary + healthInsurancePremiumPrimary + healthInsurancePremiumSecondary;

           

            primaryCustodianAllocation = totalGuidelineAmount / primaryPercentage - (childCarePrimary + healthInsurancePremiumPrimary);
            secondaryCustodianAllocation = totalGuidelineAmount / secondaryPercentage - (childCareSecondary + healthInsurancePremiumSecondary);

            Console.WriteLine("How many days (a \"day\" is 12 or more hours) per year does the other parent/custodian (not the primary residential parent) have physical possession of the child/ren?\nIf timesharing is 50/50 equal, enter \"182\"");
            int sharedParentingDays = int.Parse(Console.ReadLine());

            if (sharedParentingDays >= 88 && sharedParentingDays <= 115)
            {
                finalObligation = secondaryCustodianAllocation * .15m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 116 && sharedParentingDays <= 129)
            {
                finalObligation = secondaryCustodianAllocation * .205m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 130 && sharedParentingDays <= 142)
            {
                finalObligation = secondaryCustodianAllocation * .25m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 143 && sharedParentingDays <= 152)
            {
                finalObligation = secondaryCustodianAllocation * .305m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 153 && sharedParentingDays <= 162)
            {
                finalObligation = secondaryCustodianAllocation * .36m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 163 && sharedParentingDays <= 172)
            {
                finalObligation = secondaryCustodianAllocation * .42m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 173 && sharedParentingDays <= 181)
            {
                finalObligation = secondaryCustodianAllocation * .485m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 182)
            {
                finalObligation = secondaryCustodianAllocation * .50m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays < 88)
            {
                finalObligation = secondaryCustodianAllocation;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }

*/
        }
    }
}




