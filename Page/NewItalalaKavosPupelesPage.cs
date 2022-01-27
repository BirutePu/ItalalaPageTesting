using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Page
{
    public class NewItalalaKavosPupelesPage : BasePage
    {
        private const string PageAddress = ("https://www.italala.lt/collections/kavos-pupeles/");

        private IWebElement cookie => Driver.FindElement(By.CssSelector("#cookies-submit > a"));
        private IWebElement npopUpKavosPupeles => Driver.FindElement(By.XPath("/html/body/div[5]/section/a"));
        private IWebElement popUpKPSelenium => Driver.FindElement(By.CssSelector(".close-modal"));
        private IWebElement elsalvador => Driver.FindElement(By.CssSelector(".collectionBlock:nth-child(4) > .collectionBlock-info a"));
        private IWebElement tirtira => Driver.FindElement(By.CssSelector(".collectionBlock:nth-child(4) > .collectionBlock-info a"));
        private IWebElement elsalvadorSelenium => Driver.FindElement(By.LinkText("Finca El Salvador Kombucha, 250g"));
        private IWebElement tirtiraSelenium => Driver.FindElement(By.LinkText("Ethiopia Tirtira, 250g"));


        public NewItalalaKavosPupelesPage(IWebDriver webdriver) : base(webdriver)
        { }


        public NewItalalaKavosPupelesPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }


        public NewItalalaKavosPupelesPage CloseKukis()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            cookie.Click();
            return this;
        }

        public NewItalalaKavosPupelesPage ClosePopUp() // 1 būdas pagal Css selectoriu is selenium
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpKPSelenium.Displayed);
            popUpKPSelenium.Click();
            return this;
        }

        public NewItalalaKavosPupelesPage ClosePopUpAtsarginis()//2 būdas pagal rasta XPath
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => npopUpKavosPupeles.Displayed);
            npopUpKavosPupeles.Click();
            return this;
        }

        

        public NewItalalaKavosPupelesPage SelectElSalvador()
        {
            elsalvador.Click();
            return this;
        }

        public NewItalalaKavosPupelesPage SelectTirtira()
        {
            tirtira.Click();
            return this;
        }

        public NewItalalaKavosPupelesPage SelectElSalvadorSelenium()
        {
            elsalvadorSelenium.Click();
            return this;
        }

        public NewItalalaKavosPupelesPage SelectTirtiraSelenium()
        {
            tirtiraSelenium.Click();
            return this;
        }


    }
}
    

