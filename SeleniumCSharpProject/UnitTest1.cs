using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpProject
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver(@"D:\ChromeDriver\");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            Driver.FindElement(By.Id("btnCookie")).Click();
            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");    
            Driver.FindElement(By.XPath("//input[@name='ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.ComboBox("AllMealsCombo", "Almond");

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}   