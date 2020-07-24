using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using NUnit.Framework;
using System.Threading;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using ConsoleAppDemoApp.Utils;

namespace ConsoleAppDemoApp.StepDefs
{
    [Binding]
    public sealed class LoginPageStepDefs
    { 
        protected static WindowsDriver<WindowsElement> driver = null;

        [Given(@"I have launched the application")]
        public void GivenIHaveLaunchedTheApplication()
        {
            driver = TestBase.initialization();
        }

        [Given(@"I have entered username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveEnteredUsernameAndPassword(string username, string password)
        {
            driver.FindElementByAccessibilityId("txtLogin").SendKeys(username);
            driver.FindElementByAccessibilityId("txtPassword").SendKeys(password);
        }

        [Given(@"i click to login button")]
        public void GivenIClickToLoginButton()
        {
            driver.FindElementByAccessibilityId("btnLogin").Click();
            Thread.Sleep(3000);
            Assert.That("Start Process", Is.EqualTo("Start Process"),"text does not match");
        }

    }
}
