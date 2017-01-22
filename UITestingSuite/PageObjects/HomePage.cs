using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;





namespace UITestingSuite.PageObjects
{
    public class HomePage : Page
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]  
        public IWebElement h1Text { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/p")]
        public IWebElement pText { get; set; }

    }
}
