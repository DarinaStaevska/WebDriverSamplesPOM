
using OpenQA.Selenium;

namespace WebDriver_Pom_Example.Pages
{
    public class HomePage : BasePage
    { 
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";
        public IWebElement StudentCount => driver.FindElement(By.CssSelector("body > p"));

        public int GetStudentCount()
        {
            string studentCountText = this.StudentCount.Text;
            return int.Parse(StudentCount.Text);
        }
    }
}
