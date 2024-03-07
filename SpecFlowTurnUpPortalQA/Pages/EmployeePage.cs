using OpenQA.Selenium;
using SpecFlowTurnUpPortalQA.Utilities;

namespace SpecFlowTurnUpPortalQA.Pages
{
    public class EmployeePage : HomePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            //Create a new Employee record

            //Click on Create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Name

            IWebElement name = driver.FindElement(By.Id("Name"));
            name.SendKeys("Samuel");


            //UserName
            IWebElement username = driver.FindElement(By.Id("Username"));
            username.SendKeys("Samuel");


            //Contact
            IWebElement contact = driver.FindElement(By.Id("ContactDisplay"));
            contact.SendKeys("99887766");

            //Password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Qwe!@#123");

            //RetypePassword
            IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            retypePassword.SendKeys("Qwe!@#123");

            //IsAdmin checkbox

            //Vehicle dropdown
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicle.SendKeys("WER123");


            //Groups dropdown
            IWebElement groups = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groups.Click();
            IWebElement groupsDropdown = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[4]"));
            groupsDropdown.Click();
            Thread.Sleep(5000);

            //Save button            
            //Click on the Save Button
            WaitUtils.WaitToBeVisible(driver, "Id", "SaveButton", 2);

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);

            //Check if a new employee record has been created successfully

          /*  HomePage homePageObj = new HomePage();*/
            NavigateToEmployeePage(driver);
            IWebElement goToEmpLastpageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            goToEmpLastpageButton.Click();

            IWebElement newEmpRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]"));
/*
            if (newEmpRecord.Text == "Samuel")
            {
                Assert.Pass("New Employee Record has been created successfully");
            }
            else
            {
                Assert.Fail("New Employee Record has not been created :( :( :(");
            }*/
        }

      /*  public void EditEmployeeRecord(IWebDriver driver)
        {
            //Code for Edit Time Record
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);

            //Click on Edit Button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            //Edit Code in Code Textbox
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("DTU65");

            //Edit Description in Description Textbox
            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("IC2023Edited");

            //Edit Price in Price Textbox
            WaitUtils.WaitToBeVisible(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]", 3);
            IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceTextBox = driver.FindElement(By.Id("Price"));
            editPriceOverlappingTag.Click();
            editPriceTextBox.Clear();
            editPriceOverlappingTag.Click();
            editPriceTextBox.SendKeys("500");

            //Click on save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(4000);

            // Clock on goToLastPage Button
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPageButton.Click();

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            //if (editedCode.Text == "IC2023Edited" && EditedDescription.Text == "IC2023Edited")
            //{
            //    Console.WriteLine("Time Record has been updated successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Time Record has not been updated");
            //}
            Assert.That((editedCode.Text == "DTU65"), "Time Record has not been updated");
        }
*/
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            NavigateToEmployeePage(driver);
            IWebElement goToEmpLastpageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            goToEmpLastpageButton.Click();
            Thread.Sleep(1000);
            //Click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();

            //*[@id="usersGrid"]/div[3]/table/tbody/tr[8]/td[3]/a[2]
            Thread.Sleep(1000);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

 //           IWebElement lastEmpInTable = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
//            Assert.That((lastEmpInTable.Text.Equals("Samuel")), "Employee Record has not been deleted");
        }

    }
}
