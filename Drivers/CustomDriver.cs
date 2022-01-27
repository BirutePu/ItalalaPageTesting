﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatinis.Drivers
{
    public class CustomDriver
    {
        public static IWebDriver GetChromeDriver() 
        {
            return GetDriver(Browsers.Chrome);   
        }
        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }
       
        private static IWebDriver GetDriver(Browsers browserName) 
        {
            IWebDriver driver = null;

            switch (browserName) 
            {
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            return driver;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*public static IWebDriver GetIncognitoChrome()
               {
                   return GetDriver(Browsers.IncognitoChrome);
               }*/


        /* case Browsers.IncognitoChrome:
                    driver = GetChromeWithOptions();
                    break;*/



        /* private static IWebDriver GetChromeWithOptions()
         {
             ChromeOptions options = new ChromeOptions();
             options.AddArgument("incognito");
             options.AddArgument("start-maximized");
             //options.AddArguments("incognito", "start-maximized");
             return new ChromeDriver(options);

         }*/
    }
}