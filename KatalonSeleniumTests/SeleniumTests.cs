using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalonSeleniumTests
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL = "http://localhost:62089/CalculatePremium";
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:62089/CalculatePremium";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void The1Test()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("31");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("6", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        public void The2Test()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("51");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("0.375", driver.FindElement(By.Id("MainContent_Label1")).Text);
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=MainContent_TextBox2 | ]]
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=MainContent_TextBox1 | ]]
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("23");
        
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("5", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        public void The3Test()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("19");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("6", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        public void The4Test()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("51");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Calculate your premium below'])[1]/following::div[2]")).Click();
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("0.75", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        public void The5Test()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("16");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("0", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
