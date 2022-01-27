using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Page
{
    public class NewItalalaTirtiraPage : BasePage
    {
        private const string PageAddress = ("https://italala.lt/collections/kavos-pupeles/products/ethiopia-tirtira-250g");

        private IWebElement cookie => Driver.FindElement(By.CssSelector("#cookies-submit > a"));
        //private IWebElement cookieSelenium => Driver.FindElement(By.CssSelector(".ot-cookie"));
       // private IWebElement cookieSelenium2 => Driver.FindElement(By.LinkText("Sutinku"));
        private IWebElement cookieSelenium3 => Driver.FindElement(By.XPath("//div[@id='cookies-submit']/a"));
        private IWebElement popUpKPTirtira => Driver.FindElement(By.XPath("/html/body/div[5]/section/a"));
        private IWebElement popUpKPTirtiraSelenium => Driver.FindElement(By.XPath("//section[@id='popup']/a"));
        private IWebElement tirtiraamount => Driver.FindElement(By.Id("product-select-option-0"));
        private IWebElement tirtiraAmountSelenium => Driver.FindElement(By.XPath("//form[@id='product_form_6851119317037']/div[2]/div/div/a[2]"));
        private SelectElement DropDownSort => new SelectElement(Driver.FindElement(By.Id("product-select-option-0")));
        private IWebElement dropDownValueSelenium => Driver.FindElement(By.XPath("//option[. = 'Aeropress']"));
        private IWebElement buttonCartSelenium => Driver.FindElement(By.CssSelector("div:nth-child(6) > .productForm-submit"));
        private IWebElement cartsignSelenium => Driver.FindElement(By.XPath("//div[@id='CartPopoverCont']/div/div[3]/span[3]"));
        private IWebElement cartsignSelenium2 => Driver.FindElement(By.CssSelector(".popover-inner"));
        private IWebElement firmInputField => Driver.FindElement(By.Id("order-notes"));
        private IWebElement terminalField => Driver.FindElement(By.Id("pristatymo-terminalas"));
        private IWebElement selectedTerminal => Driver.FindElement(By.XPath("//option[. = 'Vilnius 124 Ozas Ozo g. 18 08243']"));
        private IWebElement checkboxAgree => Driver.FindElement(By.Id("agree"));
        private IWebElement buttonPay => Driver.FindElement(By.CssSelector("#Cart > form > div.checkout-buttons > button"));

        

        public NewItalalaTirtiraPage(IWebDriver webdriver) : base(webdriver)
        { }


        public NewItalalaTirtiraPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public NewItalalaTirtiraPage CloseKukis() // 1 budas
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            cookie.Click();
            return this;
        }

        public NewItalalaTirtiraPage CloseKukisSelenium() // 2 budas XPath is selenium, kai pradejo strigti Css selektorius
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            cookieSelenium3.Click();
            return this;
        }

        public NewItalalaTirtiraPage ClosePopUpExpCond()// 3 budas pagal expected conditions, neveiks naujose versijose
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(25));
            IWebElement SearchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[5]/section/a")));
            SearchResult.Click();
            return this;
        }

        public NewItalalaTirtiraPage ClosePopUpAtsarginis() // 1 būdas pagal rasta XPath
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpKPTirtira.Displayed);
            popUpKPTirtira.Click();
            return this;
        }

        public NewItalalaTirtiraPage ClosePopUp()// 2 būdas pagal Selenium rasta XPath, jis kitoks nei ieskant su inspect
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpKPTirtiraSelenium.Displayed);
            popUpKPTirtiraSelenium.Click();
            return this;
        }

        public NewItalalaTirtiraPage SelectPackagesAmount()
        {
            tirtiraamount.Click();
            tirtiraamount.Click();
            return this;
        }

        public NewItalalaTirtiraPage SelectPackagesAmountSelenium()
        {
            tirtiraAmountSelenium.Click();
            tirtiraAmountSelenium.Click();
            return this;
        }

        public NewItalalaTirtiraPage SelectPupeliuParuosimas(string value)
        {
            DropDownSort.SelectByValue(value);
            return this;
        }

        public NewItalalaTirtiraPage VerifySelectedValue(string expectedValue)
        {
            Assert.IsTrue(dropDownValueSelenium.Text.Contains(expectedValue), $"The value is not right");
            return this;

        }

        public NewItalalaTirtiraPage ClickIKrepseli()
        {
            buttonCartSelenium.Click();
            return this;
        }
        public NewItalalaTirtiraPage GetToCart()
        {
            cartsignSelenium.Click();
            return this;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------


        public NewItalalaTirtiraPage InputImonesKodas()
        {
            firmInputField.Clear();
            firmInputField.SendKeys("Firma AB, kodas223322");
            return this;
        }

        public NewItalalaTirtiraPage SelectTerminal()
        {
            terminalField.Click();
            selectedTerminal.Click();
            selectedTerminal.Click();
            return this;
        }

        public NewItalalaTirtiraPage VerifyDropUpValue(string expectedResult)
        {
            string result = selectedTerminal.GetAttribute("value");
            Assert.IsTrue(result.Contains(expectedResult), $"The terminal is wrong");
            return this;
        }

        public NewItalalaTirtiraPage ClickCheckBox()
        {
            if (!checkboxAgree.Selected)
                checkboxAgree.Click();
            return this;
        }

        public NewItalalaTirtiraPage ClickMoketi()
        {
            buttonPay.Click();
            return this;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------



    }
}

    

