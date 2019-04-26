

namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using SeleniumExtras.PageObjects;

    public class SearchPage
    {
        
        public SearchPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "article > div.post-header > h2 > a")]
        public IWebElement FirstResultHeadLine { get; set; }


    }
}
