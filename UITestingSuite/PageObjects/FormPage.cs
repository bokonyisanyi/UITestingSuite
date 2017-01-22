using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITestingSuite.PageObjects
{
    public class FormPage : Page
    {        
        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement helloInput { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement helloSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "hello-form")]
        public IWebElement helloForm { get; set; }       

        public void submitText(String inputText)
        {
            helloInput.SendKeys(inputText);
            helloSubmit.Click();
        }
    }
}
