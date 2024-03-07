using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowTurnUpPortalQA.Pages
{
    public class LoginPage
    {
        private readonly By usernameTextboxLocator = By.Id("UserName");
        IWebElement usernameTextbox;
        private readonly By passwordTextboxLocator = By.Id("Password");
        IWebElement passwordTextbox;
        private readonly By loginButtonLocator = By.XPath("//*[@id='loginForm']/form/div[3]/input[1]");
        IWebElement loginButton;

        public void launchPortal(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Launch TurnUp portal and navigate to website login page
            string baseURL = "http://horse.industryconnect.io/";
            driver.Navigate().GoToUrl(baseURL);
        }
        public void LoginActions(IWebDriver driver, String username, String password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Identify username textbox and enter valid username
            usernameTextbox = driver.FindElement(usernameTextboxLocator);
            usernameTextbox.SendKeys(username);

            //Identify password textbox and enter password
            passwordTextbox = driver.FindElement(passwordTextboxLocator);
            passwordTextbox.SendKeys(password);

            //Just to wait for 5 seconds doing nothing
            Thread.Sleep(2000);

            //Identify login button and click on Login Button
            loginButton = driver.FindElement(loginButtonLocator);
            loginButton.Click();
        }

        public void VerifyLoggedInUser(IWebDriver driver)
        {
            //Just to wait for 5 seconds doing nothing
            Thread.Sleep(2000);

            //Identify login button and click on Login Button
            loginButton = driver.FindElement(loginButtonLocator);
            loginButton.Click();
        }
    }
}
