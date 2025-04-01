using System;
using Reqnroll;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using DeltaBookAFlightTestAutomation.PageObjects;

namespace DeltaBookAFlightTestAutomation.StepDefinitions
{
    [Binding]
    public class Delta_BookAFlightStepDefinitions
    {

        WebDriver driver;
        BookAFlightSearchToolPage BAFSearchPage = new BookAFlightSearchToolPage();
        SearchResultsPage searchResultsPage = new SearchResultsPage();

        [Given("I have a browser navigated to the Delta homepage showing the book a flight tool")]
        public void GivenIHaveABrowserNavigatedToTheDeltaHomepageShowingTheBookAFlightTool()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.Profile = new FirefoxProfileManager().GetProfile("SeleniumUser");
            driver = new FirefoxDriver(options);

            driver.Navigate().GoToUrl("https://www.delta.com");
            Thread.Sleep(5000);
        }

        [When("I search for a flight defined by the cookie history loaded in the profile user")]
        public void WhenISearchForAFlightDefinedByTheCookieHistoryLoadedInTheProfileUser()
        {
            BAFSearchPage.SearchButton(driver).Click();
            Thread.Sleep(5000);
        }

        [Then("I should see a list of available flights")]
        public void ThenIShouldSeeAListOfAvailableFlights()
        {
            Assert.IsTrue(searchResultsPage.FlightCard(driver).Displayed, "First Flight number was not found.");
        }
    }
}
