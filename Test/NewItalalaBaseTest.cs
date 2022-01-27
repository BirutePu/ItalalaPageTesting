using Automatinis.Drivers;
using Automatinis.Page;
using Automatinis.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Test
{
    public class NewItalalaBaseTest
    {
        private static IWebDriver driver;
        public static NewItalalaPage _newItalalaPage;
        public static NewItalalaKavosPupelesPage _newKavosPupelesPage;
        public static NewItalalaElSalvadorPage _newElSalvadorPage;
        public static NewItalalaTirtiraPage _newTirtiraPage;
        public static NewItalalaRegistrationPage _newRegistrationPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _newItalalaPage = new NewItalalaPage(driver);
            _newKavosPupelesPage = new NewItalalaKavosPupelesPage(driver);
            _newElSalvadorPage = new NewItalalaElSalvadorPage(driver);
            _newTirtiraPage = new NewItalalaTirtiraPage(driver);
            _newRegistrationPage = new NewItalalaRegistrationPage(driver);

        }

        [TearDown]
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }
    }

}

