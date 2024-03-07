using OpenQA.Selenium.Chrome;
using SpecFlowTurnUpPortalQA.Pages;
using System;
using TechTalk.SpecFlow;
using SpecFlowTurnUpPortalQA.Utilities;
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

        [When(@"user enters valid credentials")]
        public void WhenUserEntersValidCredentials()
        {
            loginPageObj.LoginActions(driver);
        }

        [Then(@"user is logged in successfully and lands on homepage with correct user name")]
        public void ThenUserIsLoggedInSuccessfully()
        {
            homePageObj.VerifyLoggedInUser(driver);
          //  homePageObj.NavigateToTMPage(driver);
        }

        [Given(@"user login to turnup portal")]
        public void GivenUserLoginToTurnupPortal()
        {
            loginPageObj.launchPortal(driver);  
            loginPageObj.LoginActions(driver);
            homePageObj.VerifyLoggedInUser(driver);
        }

        [When(@"user creates a new TM record")]
        public void WhenUserCreatesANewTMRecord()
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.CreateTimeMaterialRecord(driver);
        }

        [Then(@"system should save the new record")]
        public void ThenSystemShouldSaveTheNewRecord()
        {
            timeMaterialPageObj.VerifyNewTMRecord(driver,"DTU65");
        }

        [When(@"user edits last created TM record")]
        public void WhenUserEditsLastCreatedTMRecord()
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.EditTimeMaterialRecord(driver, "DTU65");           
        }

        [Then(@"system should save changes to the last record")]
        public void ThenSystemShouldSaveChangesToTheLastRecord()
        {
            timeMaterialPageObj.VerifyNewTMRecord(driver, "DTU65");
        }

        [When(@"user deletes last created TM record")]
        public void WhenUserDeletesLastCreatedTMRecord()
        {
            homePageObj.NavigateToTMPage(driver);
            timeMaterialPageObj.DeleteTimeMaterialRecord(driver);
        }

        [Then(@"system should delete last record")]
        public void ThenSystemShouldDeleteLastRecord()
        {
            timeMaterialPageObj.VerifyDeletedTMRecord(driver, "DTU65");
        }

    }
}
