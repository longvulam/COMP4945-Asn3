using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Assignment3Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CreateBookTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Books")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Title")).SendKeys("The Alchemist");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();

        }

        [TestMethod]
        public void CreateCustomerTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Name")).SendKeys("Potato 2");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }


        [TestMethod]
        public void CreateRentalTest()
        {
            var startDate = DateTime.Now;
            var returnDate = startDate.AddDays(10);
        
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Rentals")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("StartDate")).SendKeys(startDate.ToString());
            driver.FindElement(By.Id("ReturnDate")).SendKeys(returnDate.ToString());

            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void UpdateBookTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Books")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.FindElement(By.Id("Title")).Clear();
            driver.FindElement(By.Id("Title")).SendKeys("The Edited Alchemist");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Customers")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.FindElement(By.Id("Name")).Clear();
            driver.FindElement(By.Id("Name")).SendKeys("The Edited Potato");
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void UpdateRentalTest()
        {
            var startDate = DateTime.Now.AddDays(20);
            var returnDate = startDate.AddDays(30);

            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Rentals")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Edit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("StartDate")).Clear();
            driver.FindElement(By.Id("ReturnDate")).Clear();
            driver.FindElement(By.Id("StartDate")).SendKeys(startDate.ToString());
            driver.FindElement(By.Id("ReturnDate")).SendKeys(returnDate.ToString());
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }





        [TestMethod]
        public void DeleteBookTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Books")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }

        [TestMethod]
        public void DeleteCustomerTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Books")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }



        [TestMethod]
        public void DeleteRentalTest()
        {
            string url = "http://localhost:36045";
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Rentals")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.LinkText("Delete")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//Input[@type='submit']")).Click();
            driver.Close();
        }





    }
}
