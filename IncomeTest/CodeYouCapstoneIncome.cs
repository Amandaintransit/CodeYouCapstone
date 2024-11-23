using CodeYouCapstone;
using CodeYouCapstoneIncomeTest;
namespace CodeYouCapstoneIncomeTest
{
    [TestClass]
    public class IncomeTest
    {
        [TestMethod]
        public void CalculateAGITestValid()
        {

            {
                //arrange
                Income myClass = new Income();
                myClass.PriorChildDeduction = 550.50m;
                myClass.Maintenance = 400;
                myClass.GrossIncome = 2500;


                decimal expected = 1549.50m;

                //Act
                decimal actual = Income.CalculateAGI(myClass.GrossIncome, myClass.Maintenance, myClass.PriorChildDeduction);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}