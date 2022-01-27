using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Page
{
    public class NewItalalaRegistrationPage : BasePage
    {
        private const string PageAddress = "https://www.italala.lt/39426064429/checkouts/1da8ac895750e8d6b5cf6fe9e4cd2036";
        //https://www.italala.lt/39426064429/checkouts/378b2cdec45f2a61f91e81856ffc1b5c -antraskartas
        //https://www.italala.lt/39426064429/checkouts/773f1c4269686909834ebb762ede632c -treciaskartas
        //https://www.italala.lt/39426064429/checkouts/1da8ac895750e8d6b5cf6fe9e4cd2036 -paskutiniskartas

        private IWebElement emailInputField => Driver.FindElement(By.Id("checkout_email"));
        private IWebElement nameInputField => Driver.FindElement(By.Id("checkout_shipping_address_first_name"));
        private IWebElement surnameInputField => Driver.FindElement(By.Id("checkout_shipping_address_last_name"));
        private IWebElement addressInputField => Driver.FindElement(By.Id("checkout_shipping_address_address1"));
        private IWebElement cityInputField => Driver.FindElement(By.Id("checkout_shipping_address_city"));
        private IWebElement postalcodeInputField => Driver.FindElement(By.Id("checkout_shipping_address_zip"));
        private IWebElement countryValue => Driver.FindElement(By.XPath("//option[. = 'Lietuva']"));
        private IWebElement phoneInputField => Driver.FindElement(By.Id("checkout_shipping_address_phone"));
        private IWebElement rememberCheckBox => Driver.FindElement(By.Id("checkout_remember_me"));
        private IWebElement buttonContinueSelenium => Driver.FindElement(By.Id("continue_button"));
       


        public NewItalalaRegistrationPage(IWebDriver webdriver) : base(webdriver)
        { }


        public NewItalalaRegistrationPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public NewItalalaRegistrationPage InputEmailAddress(string emailaddress)
        {
            emailInputField.Clear();
            emailInputField.SendKeys(emailaddress);
            return this;
        }
        
        public NewItalalaRegistrationPage InputName(string name)
        {
            nameInputField.Clear();
            nameInputField.SendKeys(name);
            return this;
        }
        
        public NewItalalaRegistrationPage InputSurname(string surname)
        {
            surnameInputField.Clear();
            surnameInputField.SendKeys(surname);
            return this;
        }
        
        public NewItalalaRegistrationPage InputHomeAddress(string address)
        {
            addressInputField.Clear();
            addressInputField.SendKeys(address);
            return this;
        }
        
        public NewItalalaRegistrationPage InputCity(string city)
        {
            cityInputField.Clear();
            cityInputField.SendKeys(city);
            return this;
        }

        public NewItalalaRegistrationPage SelectCountry()
        {
            countryValue.Click();
            return this;
        }

        public NewItalalaRegistrationPage InputCode(string postCode)
        {
            postalcodeInputField.Clear();
            postalcodeInputField.SendKeys(postCode);
            return this;
        }

        public NewItalalaRegistrationPage InputPhone(string phoneNumber)
        {
            phoneInputField.Clear();
            phoneInputField.SendKeys(phoneNumber);
            return this;
        }

        public NewItalalaRegistrationPage VerifyAddressAdded()
        {
            Assert.IsNotNull(addressInputField, "The address is not added");
            return this;
        }
        
        public NewItalalaRegistrationPage VerifyEmailAdded()
        {
            Assert.IsNotNull(emailInputField, "The address is not added");
            return this;
        }

        public NewItalalaRegistrationPage RememberCheckBoxClick()
        {
            if (rememberCheckBox.Selected)
                rememberCheckBox.Click();
            return this;
        }

        public NewItalalaRegistrationPage ClickContinueButtonSelenium()
        {
            buttonContinueSelenium.Click();
            return this;
        }
        
        
    }
}

    
