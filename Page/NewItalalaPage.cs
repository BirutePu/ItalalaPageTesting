using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Page
{
    public class NewItalalaPage : BasePage
    {
        private const string PageAddress = ("https://www.italala.lt/");
        private IWebElement cookie => Driver.FindElement(By.CssSelector("#cookies-submit > a"));
        private IWebElement popUpnItalalaPage => Driver.FindElement(By.XPath("/html/body/div[5]/section/a"));
        private IWebElement popUpnItalalaPageSelenium => Driver.FindElement(By.CssSelector(".close-modal"));
        private IWebElement shopButton => Driver.FindElement(By.CssSelector("#header > div > div > div > div > nav > nav > li:nth-child(2)"));
        private IWebElement shopButtonSelenium => Driver.FindElement(By.LinkText("Parduotuvė"));
        private IWebElement nitkavosPupeles => Driver.FindElement(By.LinkText("Kavos pupelės"));
        

        public NewItalalaPage(IWebDriver webdriver) : base(webdriver)
        { }


        public NewItalalaPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public NewItalalaPage CloseKukis()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            cookie.Click();
            return this;
        }
        
        public NewItalalaPage ClosePopUp() //1 būdas pagal Css selectoriu is selenium
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpnItalalaPageSelenium.Displayed);
            popUpnItalalaPageSelenium.Click();
            return this;
        }

        public NewItalalaPage ClosePopUpAtsarginis() // 2 būdas pagal rasta XPath
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpnItalalaPage.Displayed);
            popUpnItalalaPage.Click();
            return this;
        }
       
        public NewItalalaPage ClickParduotuveButton()
        {
            shopButton.Click();
            return this;
        }

        public NewItalalaPage ClickParduotuveSeleniumButton()
        {
            shopButtonSelenium.Click();
            return this;
        }

        public NewItalalaPage SelectKavosPupelesPage()
        {
            nitkavosPupeles.Click();
            return this;
        }



    }
}
