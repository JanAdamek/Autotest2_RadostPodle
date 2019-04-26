

namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using SeleniumExtras.PageObjects;

    public class SearchPage
    {
        
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "article > div.post-header > h2 > a")]
        public IWebElement FirstResultHeadLine { get; set; }


    }
}
