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
            driver.Navigate ().GoToUrl ("https://bing.com");

            IWebElement searchField = driver.FindElementById("sb_form_q");
            searchField.SendKeys ("Noodles");
            IWebElement btnSearch = driver.FindElementById("sb_form_go");
            btnSearch.Click ();
            driver.GetScreenshot().SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }
    }
}
