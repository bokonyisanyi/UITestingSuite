# UITestingSuite
To run the test suite please follow these steps:
  1. Check code out to your local machine using Git client  
  - Import it to Visual Studio (File -> Open -> Project/Solutions... and select the project file from its parend directory)
  - Build the project (Build -> Build Solution) This will build the UITestingSuite project itself and get the third party packages.
    On the left side in the Test Explorer window should appear with five scenarios defined in the project.
  - A UiTestingSuite playlist is defined in the project. Select it from the dropdown or if it is not in the list, open the playlist file located in the UITestingSuite directory
  - Run the test suite (Run All)
  
  
 The following packages used in the project:
 <ul>
  Selenium.Support.3.0.1 <br>
  Selenium.WebDriver.3.0.1 <br>
  Selenium.WebDriver.ChromeDriver.2.27.0 <br>
  SpecFlow.2.1.0 <br>
  SpecRun.Runner.1.5.2 <br>
  SpecRun.SpecFlow.1.5.2 <br>
  </ul>
  Might these packages should be installed (Tools -> Extensions and Updates)
  
  The test report can be found in the outpot of the test execution in the "Report file:..." section
  
