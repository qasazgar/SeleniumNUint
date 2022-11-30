using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchGoogle
{
    public class Tests
    {
         public IWebDriver driver;  
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.CssSelector("[name='q']")).SendKeys("selenium");
            driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']")).Click();
        }
    }
}