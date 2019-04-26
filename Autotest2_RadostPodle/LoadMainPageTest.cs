
namespace AutotestPage_RadostPodle
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System;
    using OpenQA.Selenium.Chrome;


    [TestFixture, Order(1)]
    public class LoadMainPageTest
    {


        HomePage nHomePage = new HomePage();
        OnasPage nOnasPage = new OnasPage();



        [Test]
        public void LinkToOMnePage()
        {
            
            Actions.OpenPage(TestConfig.urlHomePage);
            System.Threading.Thread.Sleep(1000);
            nHomePage.HlavaKarolina.Click();
            System.Threading.Thread.Sleep(1000);
            
            try
            {
                Assert.AreEqual(nOnasPage.OmneText.Text, TestConfig.oNasTitleText);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
    }


    [TestFixture, Order(2)]
    [Category("QuickTests")]
    public class CheckSearchBar
    {


        HomePage nHomePage = new HomePage();
        OnasPage nOnasPage = new OnasPage();
        SearchPage nSeachPage = new SearchPage();

        [SetUp]
        public void SetUpLoad2()
        {




        }


        [Test]
        public void SearchInSearchBar()
        {

           
            Actions.OpenPage(TestConfig.urlHomePage);

            nHomePage.SearchBar.SendKeys(TestConfig.searchText);
            nHomePage.SearchBar.SendKeys(Keys.Enter);

            string result = nSeachPage.FirstResultHeadLine.Text;

            try
            {
                Assert.AreEqual(nSeachPage.FirstResultHeadLine.Text, TestConfig.searchResultTitle);
            }
            catch (Exception e)
            {
                Console.WriteLine("První vyhledaný nadpis: {0}", result);
                Console.WriteLine(e);

            }

        }



    }

    [TestFixture, Order(3)]
    [Category("QuickTests")]
    public class CheckMainMenu
    {

        HomePage nHomePage = new HomePage();

        [SetUp]
        public void SetUpLoad3()
        {

        }


        [Test]
        public void CheckAllMenusTexts()
        {
            
            Actions.OpenPage(TestConfig.urlHomePage);
            System.Threading.Thread.Sleep(1000);

            try
            {
                Assert.Multiple(() =>
               {
                   Assert.AreEqual(nHomePage.MenuHome.Text, TestConfig.menuHomeText);
                   Assert.AreEqual(nHomePage.MenuZapisky.Text, TestConfig.menuZapiskyText);
                   Assert.AreEqual(nHomePage.MenuRecepty.Text, TestConfig.menuReceptyText);
                   Assert.AreEqual(nHomePage.MenuRadosti.Text, TestConfig.menuRadostiText);
                   Assert.AreEqual(nHomePage.MenuOMne.Text, TestConfig.menuOmneText);
                   Assert.AreEqual(nHomePage.MenuMuzika.Text, TestConfig.menuMuzikaText);
                   Assert.AreEqual(nHomePage.MenuSpoluprace.Text, TestConfig.menuSpolupraceText);
                   Assert.AreEqual(nHomePage.MenuMedia.Text, TestConfig.menuMediaText);
                   Assert.AreEqual(nHomePage.MenuAkce.Text, TestConfig.menuAkceText);
               });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            nHomePage.MenuHome.Click();
            System.Threading.Thread.Sleep(1000);

            try
            {
                Assert.AreEqual(Driver.driver.Url, TestConfig.urlHomePage);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }




    }
}

   



