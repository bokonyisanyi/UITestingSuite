using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSuite.PageObjects
{
    public class Page
    {
        public IWebDriver driver;

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement dh_logo { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement home { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement form { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement error { get; set; }

        [FindsBy(How = How.ClassName, Using = "navbar-brand")]
        public IWebElement uiTestingbtn { get; set; }

        public IWebElement getParent(IWebElement element)
        {
            IWebElement parent = element.FindElement(By.XPath(".."));
            return parent;
        }

        public Boolean isActive(IWebElement element)
        {
            return getParent(element).GetAttribute("class") == "active";
        }

    }
}
