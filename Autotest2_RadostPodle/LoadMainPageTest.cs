
namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;

    using System;
    using OpenQA.Selenium.Chrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]

    public class LoadMainPageTest
    {

        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get ; set ; }
        public OnasPage NOnasPage { get ; set ; }

        
        


        [TestMethod]
        
        public void LinkToOMnePage()
        {

            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Chrome);
            NHomePage = new HomePage(Driver);
            NOnasPage = new OnasPage(Driver);

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

            Driver.Quit();

        }

        
    }


    [TestClass]
    public class CheckSearchBar
    {
        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get; set; }
        public SearchPage NSeachPage { get; set; }





        [TestMethod]
        public void SearchInSearchBar()
        {
            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Chrome);

            NHomePage = new HomePage(Driver);

            NSeachPage = new SearchPage(Driver);

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

            Driver.Quit();

        }

       



    }

    [TestClass]
    public class CheckMainMenu
    {
        public IWebDriver Driver { get; set; }
        public HomePage NHomePage { get; set; }





        
        [TestMethod]
        public void CheckAllMenusTexts()
        {
            Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Firefox);
            NHomePage = new HomePage(Driver);

            System.Threading.Thread.Sleep(1000);

            try
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

            Driver.Quit();
        }


        [TestClass]
        public class ClickOnAdd
        {
            IWebDriver Driver { get; set; }
            HomePage NHomePage { get; set; }


            [TestMethod]
            public void ClickOnFirstAdd()
            {
                Driver = Actions.OpenPage(TestConfig.urlHomePage, BrowserType.Firefox);

                System.Threading.Thread.Sleep(10000);

                NHomePage = new HomePage(Driver);

                
                    Console.WriteLine("Link :{0}", NHomePage.LinkAdsFirst.Displayed );
                    Console.WriteLine("Product :{0}", NHomePage.ProductAdsFirst.Displayed  );
                    Console.WriteLine("Banner :{0}:", NHomePage.BannerAdsFirst.Displayed);
                /*
            }
                catch (Exception e)
                {

                    Console.WriteLine("Banner Nenalezen: {0}", e);
                    Assert.Warn("Banner Nenalezen: {0}", e);
                }
                */
                System.Threading.Thread.Sleep(2000);
                Driver.Quit();
            }

            
        }


        }
}

   



