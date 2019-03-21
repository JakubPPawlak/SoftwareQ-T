using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace KatalonSeleniumTests
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
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
        public void TestCase1()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("23");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("6", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        [Test]
        public void TestCase2()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("36");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("5", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        [Test]
        public void TestCase3()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("21");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("5", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        [Test]
        public void TestCase4()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("16");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            Assert.AreEqual("0", driver.FindElement(By.Id("MainContent_Label1")).Text);
        }
        [Test]
        public void TestCase5()
        {
            driver.Navigate().GoToUrl("http://localhost:62089/CalculatePremium");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("male");
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
