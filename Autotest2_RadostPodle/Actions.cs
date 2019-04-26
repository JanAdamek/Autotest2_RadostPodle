using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;


namespace AutotestPage_RadostPodle
{

    public enum BrowserType
    {
        Chrome,
        IE,
        Firefox
    }

    class Actions
    {
        

        public static IWebDriver OpenPage( string pageUrl, BrowserType browser)
        {

            IWebDriver driver;

            
          

           
            // IWebDriver driver = new ChromeDriver(@"C:\Users\vMix\Downloads\chromedriver_win32_3");
            switch (browser)
            {
                case BrowserType.Chrome:
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                    
                case BrowserType.IE:
                    {
                        driver = new InternetExplorerDriver();
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        driver = new FirefoxDriver();
                        break;
                    }

                default:
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                    
            }
            


            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine("Opened Page: {0}", pageUrl);

            return driver;

        }



}
}
