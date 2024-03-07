using OpenQA.Selenium.Chrome;
using SpecFlowTurnUpPortalQA.Pages;
using System;
using TechTalk.SpecFlow;
using SpecFlowTurnUpPortalQA.Utilities;
using OpenQA.Selenium;
using System.Diagnostics;
namespace SpecFlowTurnUpPortalQA.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions : CommonDriver
    {

        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();

        [BeforeScenario]
        public void SetUpTimeAndMaterial()
        {
            //Open Chrome/Firefox browser
            driver = new ChromeDriver();
            Thread.Sleep(1000);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }

        [Given(@"user navigate to turnup portal")]
        public void GivenUserNavigateToTurnupPortal()
        {
            loginPageObj.launchPortal(driver);
        }

        [When(@"user enters valid credentials '([^']*)' '([^']*)'")]
        public void WhenUserEntersValidCredentials(String username, String password)
        {
            loginPageObj.LoginActions(driver, username, password);
        }

        [Then(@"user is logged in successfully and lands on homepage with correct user name")]
        public void ThenUserIsLoggedInSuccessfullyAndLandsOnHomepageWithCorrectUserName()
        {
            homePageObj.VerifyLoggedInUser(driver);
        }

        [Given(@"user login to turnup portal '([^']*)' '([^']*)'")]
        public void GivenUserLoginToTurnupPortal(string username, string password)
        {
            loginPageObj.launchPortal(driver);
            loginPageObj.LoginActions(driver, username, password);
            homePageObj.VerifyLoggedInUser(driver);
        }

        [When(@"user creates a new TM record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserCreatesANewTMRecord(string code, string description, string price)
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.CreateTimeMaterialRecord(driver, code, description, price);
        }

        [Then(@"system should save the new record '([^']*)'")]
        public void ThenSystemShouldSaveTheNewRecord(string code)
        {
            timeMaterialPageObj.VerifyNewTMRecord(driver, code);
        }

        [When(@"user edits last created TM record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditsLastCreatedTMRecord(string code, string description, string price)
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.EditTimeMaterialRecord(driver, code, description, price);
        }

        [Then(@"system should save changes to the last record '([^']*)'")]
        public void ThenSystemShouldSaveChangesToTheLastRecord(string code)
        {
            timeMaterialPageObj.VerifyNewTMRecord(driver, code);
        }

        [When(@"user deletes last created TM record '([^']*)'")]
        public void WhenUserDeletesLastCreatedTMRecord(string code)
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.DeleteTimeMaterialRecord(driver, code);
        }

        [Then(@"system should delete last record '([^']*)'")]
        public void ThenSystemShouldDeleteLastRecord(string code)
        {
            timeMaterialPageObj.VerifyDeletedTMRecord(driver, code);
        }

    }
}


