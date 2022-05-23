using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_Pom_Example.Pages;

namespace WebDriver_Pom_Example.Tests
{
    public class HomePageTests : BaseTests
    {
       
        [Test]
        public void Test_HomePage_Url_Heading_Title()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));
            Assert.That(home_page.GetPageHeading(), Is.EqualTo("Students Registry"));
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

            [Test]
            public void Test_HomePage_HomeLink()
            {
                var home_page = new HomePage(driver);
                home_page.Open();
                home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("MVC Example"));
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));

        }
        [Test]
        public void Test_HomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.ViewStudentsLink.Click();
            var view_students = new ViewStudentsPage(driver);
            Assert.That(view_students.GetPageTitle, Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(view_students.GetPageUrl()));

        }
        [Test]
        public void Test_HomePage_AddStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.AddStudentsLink.Click();
            var add_students = new AddStudentPage(driver);
            Assert.That(add_students.GetPageTitle, Is.EqualTo("Add Student"));
            Assert.That(driver.Url, Is.EqualTo(add_students.GetPageUrl()));

        }
        [Test]
        public void Test_HomePage_StudentsCount()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.Greater(home_page.GetStudentCount(), 1);

        }
    }
}
