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
    public class NewItalalaElSalvadorPage : BasePage
    {
        private const string PageAddress = ("https://www.italala.lt/collections/kavos-pupeles/products/el-salvador-finca-el-salvador-kombucha-250g");

        private IWebElement cookie => Driver.FindElement(By.CssSelector("#cookies-submit > a"));
        private IWebElement popUpKavosPupElSalvador => Driver.FindElement(By.XPath("/html/body/div[5]/section/a"));
        private IWebElement popUpKPSavadorSelenium => Driver.FindElement(By.CssSelector(".close-modal"));
        private IWebElement salvadoramount => Driver.FindElement(By.CssSelector("#product_form_6780931375149 > div:nth-child(4) > div > div.qty__adjust > a.qty__adjust-btn.js-qty__adjust-btn.increase"));
        private SelectElement DropDownSortSalvador => new SelectElement(Driver.FindElement(By.Id("product-select-option-0")));
        private IWebElement dropDownValueSelenium => Driver.FindElement(By.XPath("//option[. = 'French Press']"));
        private IWebElement buttonCartSelenium => Driver.FindElement(By.CssSelector("div:nth-child(6) > .productForm-submit"));
        private IWebElement toShopKPSelenium => Driver.FindElement(By.LinkText("Kavos pupelės"));

        

        public NewItalalaElSalvadorPage(IWebDriver webdriver) : base(webdriver)
        { }


        public NewItalalaElSalvadorPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public NewItalalaElSalvadorPage CloseKukis()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            cookie.Click();
            return this;
        }

        public NewItalalaElSalvadorPage ClosePopUpExpCond()// 3 budas pagal expected conditions, neveiks naujose versijose
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(25));//veikia
            IWebElement SearchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[5]/section/a")));//veikia
            SearchResult.Click();//veikia
            return this;
        }
        public NewItalalaElSalvadorPage ClosePopUpAtsarginis() // 2 būdas pagal rasta XPath
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpKavosPupElSalvador.Displayed);
            popUpKavosPupElSalvador.Click();
            return this;
        }

        public NewItalalaElSalvadorPage ClosePopUp()// 1 būdas pagal XPath is selenium
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(35));
            wait.Until(d => popUpKPSavadorSelenium.Displayed);
            popUpKPSavadorSelenium.Click();
            return this;
        }

        public NewItalalaElSalvadorPage SelectPackagesAmount()
        {
            salvadoramount.Click();
            salvadoramount.Click();
            return this;
        }

        public NewItalalaElSalvadorPage SelectPupeliuParuosimas(string value)
        {
            DropDownSortSalvador.SelectByValue(value);
            return this;
        }

        public NewItalalaElSalvadorPage VerifySelectedValue(string expectedValue)
        {
            Assert.IsTrue(dropDownValueSelenium.Text.Contains(expectedValue), $"The value is not right");
            return this;
        }

        public NewItalalaElSalvadorPage ClickIKrepseli()
        {
            buttonCartSelenium.Click();
            return this;
        }

        public NewItalalaElSalvadorPage GetBackToParduotuve()
        {
            toShopKPSelenium.Click();
            return this;
        }
    }
}
