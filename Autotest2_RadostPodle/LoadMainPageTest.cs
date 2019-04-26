
namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System;
    using OpenQA.Selenium.Chrome;


    [TestFixture, Order(1)]
    [Parallelizable]
    public class LoadMainPageTest
    {

        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get ; set ; }
        public OnasPage NOnasPage { get ; set ; }

        
        

        [OneTimeSetUp]
        public void Initial()
        {
            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Chrome);
            NHomePage = new HomePage(Driver);
            NOnasPage = new OnasPage(Driver);
        }

        [Test]
        public void LinkToOMnePage()
        {
            

            System.Threading.Thread.Sleep(1000);
            NHomePage.HlavaKarolina.Click();
            System.Threading.Thread.Sleep(1000);
            
            try
            {
                Assert.AreEqual(NOnasPage.OmneText.Text, TestConfig.oNasTitleText);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }

        [OneTimeTearDown]
        public void CleanEnd()
        {
            Driver.Quit();
        }
    }


    [TestFixture, Order(2)]
    [Parallelizable]
    [Category("QuickTests")]
    public class CheckSearchBar
    {
        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get; set; }
        public SearchPage NSeachPage { get; set; }



        [OneTimeSetUp]
        public void Initial()
        {
            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.IE);

            NHomePage = new HomePage(Driver);
            
            NSeachPage = new SearchPage(Driver);

        }


        [Test]
        public void SearchInSearchBar()
        {
            NHomePage.SearchBar.SendKeys(TestConfig.searchText);
            NHomePage.SearchBar.SendKeys(Keys.Enter);

            string result = NSeachPage.FirstResultHeadLine.Text;

            try
            {
                Assert.AreEqual(NSeachPage.FirstResultHeadLine.Text, TestConfig.searchResultTitle);
            }
            catch (Exception e)
            {
                Console.WriteLine("První vyhledaný nadpis: {0}", result);
                Console.WriteLine(e);

            }

        }

        [OneTimeTearDown]
        public void CleanEnd()
        {
            Driver.Quit();
        }



    }

    [TestFixture, Order(3)]
    [Parallelizable]
    [Category("QuickTests")]
    public class CheckMainMenu
    {
        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get; set; }





        [OneTimeSetUp]
        public void SetUpLoad3()
        {
            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Firefox);
            NHomePage = new HomePage(Driver);
        }


        [Test]
        public void CheckAllMenusTexts()
        {
            
            
            System.Threading.Thread.Sleep(1000);

            try
            {
                Assert.Multiple(() =>
               {
                   Assert.AreEqual(NHomePage.MenuHome.Text, TestConfig.menuHomeText);
                   Assert.AreEqual(NHomePage.MenuZapisky.Text, TestConfig.menuZapiskyText);
                   Assert.AreEqual(NHomePage.MenuRecepty.Text, TestConfig.menuReceptyText);
                   Assert.AreEqual(NHomePage.MenuRadosti.Text, TestConfig.menuRadostiText);
                   Assert.AreEqual(NHomePage.MenuOMne.Text, TestConfig.menuOmneText);
                   Assert.AreEqual(NHomePage.MenuMuzika.Text, TestConfig.menuMuzikaText);
                   Assert.AreEqual(NHomePage.MenuSpoluprace.Text, TestConfig.menuSpolupraceText);
                   Assert.AreEqual(NHomePage.MenuMedia.Text, TestConfig.menuMediaText);
                   Assert.AreEqual(NHomePage.MenuAkce.Text, TestConfig.menuAkceText);
               });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            NHomePage.MenuHome.Click();
            System.Threading.Thread.Sleep(1000);

            try
            {
                Assert.AreEqual(Driver.Url, TestConfig.urlHomePage);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }

        [OneTimeTearDown]
        public void CleanEnd()
        {
            Driver.Quit();
        }

        [TestFixture, Order(4)]
        [Parallelizable]
        [Category("QuickTests")]
        public class ClickOnAdd
        {
            IWebDriver Driver { get; set; }
            HomePage NHomePage { get; set; }

            [OneTimeSetUp]
            public void SetUpF()
            {
                Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Chrome);
                NHomePage = new HomePage(Driver);
            }

            [Test]
            public void ClickOnFirstAdd()
            {

                try
                {
                    NHomePage.BannerAdsFirst.Click();
                }
                catch (Exception e)
                {

                    Console.WriteLine("Banner Nenalezen");
                    Assert.Warn("Banner Nenalezen");
                }

                System.Threading.Thread.Sleep(2000);

            }

            [OneTimeTearDown]
            public void Clean()
            {
                Driver.Quit();
            }
        }


        }
}

   



