using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowTurnUpPortalQA.Utilities;

namespace SpecFlowTurnUpPortalQA.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time and Material module (Click on the Administration Dropdown Menu link)
                IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
                administrationDropdown.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

                WaitUtils.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

                IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                timeAndMaterialOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal dashboard panel is not clickable");
            }
        }

        public void NavigateToEmployeePage(IWebDriver driver)
        {
            try
            {
                //Navigate to Time and Material module (Click on the Administration Dropdown Menu link)
                IWebElement administrationDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
                administrationDropdown.Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));

                WaitUtils.WaitToBeVisible(driver, "XPath", "//div[3]/div/div/ul/li[5]/ul/li[2]/a", 3);

                IWebElement employeeOption = driver.FindElement(By.XPath("//div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                employeeOption.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal dashboard panel is not clickable");
            }
        }

        public void VerifyLoggedInUser(IWebDriver driver)
        {
            //Check if the user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in :( :( :(");
            }
        }
    }
}
