using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutotestPage_RadostPodle
{
    class Actions
    {
        public static void OpenPage( string pageUrl )
        {

            Driver.driver.Navigate().GoToUrl(pageUrl);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Console.WriteLine("Opened Page: {0}", pageUrl);
        }

        public static void Inicialize()
        {
            Driver.driver = new ChromeDriver(@"C:\Users\vMix\Downloads\chromedriver_win32_3");

        }

}
}
