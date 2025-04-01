using OpenQA.Selenium;

namespace DeltaBookAFlightTestAutomation.PageObjects
{
    internal class BookAFlightSearchToolPage
    {
        public IWebElement SearchButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("btn-book-submit"));
        }
        

    }
}
