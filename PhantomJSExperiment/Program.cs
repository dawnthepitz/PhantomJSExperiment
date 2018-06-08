using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
namespace PhantomJSExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            PhantomJSDriver driver = new PhantomJSDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/");
            driver.GetScreenshot().SaveAsFile("screenshot1.png", ScreenshotImageFormat.Png);
            IWebElement btnTruck = driver.FindElementById("nav_truck");
            btnTruck.Click();
            driver.GetScreenshot().SaveAsFile("screenshot2.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }
    }
}
