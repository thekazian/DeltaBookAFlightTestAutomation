using OpenQA.Selenium;

namespace DeltaBookAFlightTestAutomation.PageObjects
{
    internal class SearchResultsPage
    {
        public IWebElement FlightCard(IWebDriver driver)
        {
            return driver.FindElement(By.ClassName("flight-card"));
        }


    }
}
