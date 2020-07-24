using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;


namespace ConsoleAppDemoApp.Utils
{
    public class TestBase
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/";
        private const string LaunchApp = @"C:\Users\MOD\source\repos\AutomationProject\AutomationProject\bin\Debug\AutomationProject.exe";

        protected static WindowsDriver<WindowsElement> driver = null;
        public static WindowsDriver<WindowsElement> initialization()
        {
            AppiumOptions opt = new AppiumOptions();
            opt.AddAdditionalCapability("app", LaunchApp);
            opt.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opt);
            return driver;
        }
    }
}
