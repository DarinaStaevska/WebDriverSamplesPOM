using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_Pom_Example.Pages;

namespace WebDriver_Pom_Example.Tests
{
    public class AddStudentTest : BaseTests
    {

        [Test]
        public void Test_AddStudent_Url_Heading_Title()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));
            Assert.That(add_student.GetPageHeading(), Is.EqualTo("Register New Student"));
            Assert.That(add_student.GetPageTitle(), Is.EqualTo("Add Student"));
        }

            [Test]
            public void Test_HomePage_HomeLink()
            {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            add_student.HomeLink.Click();
            var home_page = new HomePage(driver);
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
    }
}
