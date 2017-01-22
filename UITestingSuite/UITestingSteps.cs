using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using UITestingSuite.PageObjects;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace UITestingSuite
{
    [Binding]
    public class UITestingSteps
    {
        public static IWebDriver driver;
        public static HomePage homePage = new HomePage();
        public static FormPage formPage = new FormPage();
        public static ErrorPage errorPage = new ErrorPage();
        public static HelloPage helloPage = new HelloPage();
        public static Page page = new Page();

        [BeforeTestRun]
        public static void setUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, homePage);
            PageFactory.InitElements(driver, formPage);
            PageFactory.InitElements(driver, errorPage);
            PageFactory.InitElements(driver, helloPage);
            PageFactory.InitElements(driver, page);
        }

        [Given(@"I opened a Chrome and UI Testing page")]
        public void GivenIOpenedAChromeAndUITestingPage()
        {            
            driver.Url = "http://uitest.duodecadits.com";
        }        

        [When(@"I click on Home Button")]
        public void WhenIclickOnHomeButton()
        {
            page.home.Click();
        }

        [When(@"I click on Form Button")]
        public void WhenIclickOnFormButton()
        {
            page.form.Click();
        }

        [When(@"I click on the UI Testing button")]
        public void ThenIClickOnTheUITestingButton()
        {
            page.uiTestingbtn.Click();
        }

        [When(@"I click on Error button")]
        public void WhenIClickOnErrorButton()
        {
            page.error.Click();
        }

        [Then(@"I should get (.*) response code")]
        public void ThenIShouldGetResponseCode(int expected)
        {
            Assert.AreEqual(expected, getResponseCode(driver.Url));
        }

        [Then(@"the title should be (.*)")]
        public void ThenTheTitleShouldBeUITestingSite(String expected)
        {            
            Assert.AreEqual(expected, driver.Title);
        }

        [Then(@"the active button should be Home")]
        public void ThenTheActiveButtonShouldBeHome()
        {
            Assert.IsTrue(page.isActive(page.home));
            Assert.IsFalse(page.isActive(page.form));
            Assert.IsFalse(page.isActive(page.error));
        }

        [Then(@"the active button should be Form")]
        public void ThenTheActiveButtonShouldBeForm()
        {
            Assert.IsTrue(page.isActive(page.form));
            Assert.IsFalse(page.isActive(page.home));
            Assert.IsFalse(page.isActive(page.error));
        }

        [Then(@"I should get navigated to the Home page")]
        public void ThenIShouldGetNavigatedToTheHomePage()
        {
            Assert.AreEqual("http://uitest.duodecadits.com/", driver.Url);
        }

        [Then(@"I should get navigated to the Form page")]
        public void ThenIShouldGetNavigatedToTheFormPage()
        {
            Assert.AreEqual("http://uitest.duodecadits.com/form.html", driver.Url);
        }

        [Then(@"the Company Logo should be visible")]
        public void ThenTheCompanyLogoShouldBeVisible()
        {
            Assert.IsNotNull(page.dh_logo);
        }

        [Then(@"a form should be visible with one input box and one submit button")]
        public void ThenAFormShouldBeVisibleWithOneInputBoxAndOneSubmitButton()
        {
            Assert.IsNotNull(formPage.helloForm);
            Assert.IsNotNull(formPage.helloInput);
            Assert.IsNotNull(formPage.helloSubmit);
        }

        [Then(@"the following text should be visible on the Home page in <h1> tag: (.*)")]
        public void assertH1Tag(string expected)
        {
            Assert.AreEqual("Welcome to the Docler Holding QA Department", homePage.h1Text.Text);
            
        }

        [Then(@"The following text should be visible on the Home page in <p> tag: (.*)")]
        public void assertPTag(string expected)
        {
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.", homePage.pText.Text);
        }

        [When(@"I submit <name> then I should get Hello <name>! greeting on the Hello page")]
        public void WhenISubmitIShouldGetHelloGreetingOnTheHelloPage(Table table )
        {
            foreach (var row in table.Rows)
            {
                submitName(row[0]);
                Assert.AreEqual("Hello " + row[0] + "!", row[1]);
                driver.Navigate().Back();
            }
        }

        public void submitName(String name)
        {
            formPage.submitText(name);
        }

        public void getGreeting(String expected)
        {
            Assert.AreEqual(expected, helloPage.helloText.Text);
        }

        public int getResponseCode(String url)
        {
            HttpWebResponse response = null;
            HttpStatusCode statusCode= 0;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";

                response = (HttpWebResponse)request.GetResponse();
                statusCode = response.StatusCode;
                Debug.Write("The status code: "+statusCode);
                return (int)statusCode;
            }
            catch (WebException e)
            {
                return (int)((HttpWebResponse)e.Response).StatusCode;
            }            
        }    

        [AfterTestRun]
        public static void tearDown()
        {
            driver.Close();            
        }        
    }

}
