

namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using SeleniumExtras.PageObjects;

    public class HomePage
    {
        
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#solopine_about_widget-2 > div > a > img")]
        public IWebElement HlavaKarolina { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-155 > a")]
        public IWebElement MenuHome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-166 > a")]
        public IWebElement MenuZapisky { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-232 > a")]
        public IWebElement MenuRecepty { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-115 > a")]
        public IWebElement MenuRadosti { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-77 > a")]
        public IWebElement MenuOMne { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-348 > a")]
        public IWebElement MenuMuzika { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-223 > a")]
        public IWebElement MenuSpoluprace { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-456 > a")]
        public IWebElement MenuMedia { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-808 > a")]
        public IWebElement MenuAkce { get; set; }

        [FindsBy(How = How.Name, Using = "s")]
        public IWebElement SearchBar { get; set; }

        [FindsBy(How = How.Name, Using = "google_ads_frame1")]
        public IWebElement BannerAdsFirst { get; set; }


    }
}
