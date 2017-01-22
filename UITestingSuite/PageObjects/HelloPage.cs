using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSuite.PageObjects
{
    public class HelloPage : Page
    {        
        [FindsBy(How = How.Id, Using = "hello-text")]
        public IWebElement helloText { get; set; }

    }
}
