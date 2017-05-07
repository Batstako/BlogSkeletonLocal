using System;
using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITests
    {
        
        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));


            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");
            var logo = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='navbar-brand']")));
            //var Logo1 = wait.Until(w => w.FindElement(By.XPath(".//a[@class = 'navbar - brand']")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}
