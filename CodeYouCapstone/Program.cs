namespace CodeYouCapstone
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Need to Add Validation Logic

            string userInput = string.Empty;
            decimal childCareMother = 0;
            decimal childCareFather = 0;
            decimal healthInsurancePremiumMother = 0;
            decimal healthInsurancePremiumFather = 0;
            decimal totalGuidelineAmount = 0;
            decimal momAllocation = 0;
            decimal dadAllocation = 0;

            decimal finalObligation = 60;

            Console.WriteLine("How many children under 18 years of age do you and the other parent/custodian have in common?");
            int numberOfChildren = int.Parse(Console.ReadLine());

            Income motherIncome = new Income();
            Console.WriteLine("Please enter your monthly gross income");
            motherIncome.GrossIncome = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the monthly amount you pay in maintenance to your current or former spouse.\n  If you have no maintenance obligations, enter 0 ");
            motherIncome.Maintenance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the monthly amount you already pay in child support for children born prior to the child/ren who are the subject(s) of this calculation.\n If you have none, enter 0");
            motherIncome.PriorChildDeduction = decimal.Parse(Console.ReadLine());



            Income fatherIncome = new Income();
            Console.WriteLine("Please enter the other parent/custodian's monthly gross income");
            fatherIncome.GrossIncome = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the monthly amount the other parent/custodian pays in maintenance to you or a former spouse.\n  If the other parent/custodian has no maintenance obligations, enter 0 ");
            fatherIncome.Maintenance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the monthly amount thenother parent/custodian already pays in child support for children born prior to the child/ren who are the subject(s) of this calculation.\n If the other parent/custodian has none, enter 0");
            fatherIncome.PriorChildDeduction = decimal.Parse(Console.ReadLine());

            decimal MotherAGI = Income.CalculateAGI(motherIncome.GrossIncome, motherIncome.Maintenance, motherIncome.PriorChildDeduction);
            decimal FatherAGI = Income.CalculateAGI(fatherIncome.GrossIncome, fatherIncome.Maintenance, fatherIncome.PriorChildDeduction);
            decimal combinedAGI = MotherAGI + FatherAGI;
            decimal fatherPercentage = MotherAGI / combinedAGI;
            decimal motherPercentage = FatherAGI / combinedAGI;

            //Will need to read data from chart to extract the amount and assign it to a variable.
            Console.WriteLine($"Your Adjusted Gross Income is:  {MotherAGI}, {motherPercentage} percent of the combined income.\nThe other parent/custodian's Adjusted Gross Income is:  {FatherAGI}, {fatherPercentage} percent of the combined income. \nWith a combined income of {combinedAGI}, the total support amount for {numberOfChildren} children is CHART AMOUNT HERE");
            decimal guidelineAmountOfSupport = 0;

            totalGuidelineAmount = childCareMother + childCareFather + healthInsurancePremiumMother + healthInsurancePremiumFather;

            Console.WriteLine("Please enter the amount you pay each month for childcare.\nIf the answer is none, please enter 0.");
            childCareMother = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount the other parent/custodian pays each month for childcare.\nIf the answer is none, please enter 0.");
            childCareFather = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount of health care premiums you incur each month for the child.\nIf the answer is none, please enter 0.");
            healthInsurancePremiumMother = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount of health care premiums the other parent/custodian incurs each month for childcare.\nIf the answer is none, please enter 0.");
            healthInsurancePremiumFather = decimal.Parse(Console.ReadLine());

            momAllocation = totalGuidelineAmount / motherPercentage - (childCareMother + healthInsurancePremiumMother);
            dadAllocation = totalGuidelineAmount / fatherPercentage - (childCareFather + healthInsurancePremiumFather);

            Console.WriteLine("How many days (a \"day\" is 12 or more hours) per year does the other parent/custodian have physical possession of the child/ren?\nIf you have 50/50 timesharing, enter \"182\"");
            int sharedParentingDays = int.Parse(Console.ReadLine());

            if (sharedParentingDays >= 88 && sharedParentingDays <= 115)
            {
                finalObligation = dadAllocation * .15m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 116 && sharedParentingDays <= 129)
            {
                finalObligation = dadAllocation * .205m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 130 && sharedParentingDays <= 142)
            {
                finalObligation = dadAllocation * .25m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 143 && sharedParentingDays <= 152)
            {
                finalObligation = dadAllocation * .305m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 153 && sharedParentingDays <= 162)
            {
                finalObligation = dadAllocation * .36m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 163 && sharedParentingDays <= 172)
            {
                finalObligation = dadAllocation * .42m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 173 && sharedParentingDays <= 181)
            {
                finalObligation = dadAllocation * .485m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays >= 182)
            {
                finalObligation = dadAllocation * .50m;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }
            else if (sharedParentingDays < 88)
            {
                finalObligation = dadAllocation;
                Console.WriteLine($"Parent B's Child Support Obligation is {finalObligation}");
            }


        }
    }
}




