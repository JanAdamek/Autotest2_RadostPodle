using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace AutotestPage_RadostPodle
{
    class Actions
    {
        public static IWebDriver OpenPage( string pageUrl  )
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\vMix\Downloads\chromedriver_win32_3");

            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Console.WriteLine("Opened Page: {0}", pageUrl);

            return driver;

        }

        public static IWebDriver Inicialize()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\vMix\Downloads\chromedriver_win32_3");

            return driver;
        }

}
}
