

namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using SeleniumExtras.PageObjects;

    public class OnasPage
    {
        
        public OnasPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-61 > div.post-entry > p:nth-child(2) > strong:nth-child(1)")]
        public IWebElement OmneText { get; set; }

    }
}
