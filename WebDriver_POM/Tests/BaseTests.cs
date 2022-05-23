using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace WebDriver_Pom_Example.Tests
{
     public class BaseTests
    {
        protected ChromeDriver driver { get; private set; }

        [OneTimeSetUp]
        public void SetUp()
        {
            this.driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void ShutDownBrowser()
        {
            driver.Quit();
        }
    }
}
