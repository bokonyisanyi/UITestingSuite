Feature: FormSubmit
	In order verify if the UI Testing Site
	As a user
	I want to browse the pages and verify the requirements

Scenario: Verification of Home Page	appearance
	# These steps cover the testing of REQ-UI-01, REQ-UI-03, REQ-UI-02, REQ-UI-04, REQ-UI-09, REQ-UI-10
	When I click on Home Button
	Then I should get navigated to the Home page	
	And the Company Logo should be visible
	And the title should be UI Testing Site
	And the active button should be Home
	And the following text should be visible on the Home page in <h1> tag: Welcome to the Docler Holding QA Department
	And The following text should be visible on the Home page in <p> tag: This site is dedicated to perform some exercises and demonstrate automated web testing.
	
Scenario: Verification of Form page appearance
	# These steps cover the testing of REQ-UI-05, REQ-UI-01, REQ-UI-02, REQ-UI-06, REQ-UI-11
	When I click on Form Button
	Then I should get navigated to the Form page
	And the Company Logo should be visible
	And the title should be UI Testing Site
	And the active button should be Form
	And a form should be visible with one input box and one submit button

Scenario: Verification of UI Testing button	
	# These steps cover the testing of REQ-UI-08
	When I click on the UI Testing button
	Then I should get navigated to the Home page

Scenario: Verification of Form page operation
	# These steps cover the testing of REQ-UI-12
	When I click on Form Button
	When I submit <name> then I should get Hello <name>! greeting on the Hello page
		| name    | greeting       |
		| John    | Hello John!    |
		| Sophia  | Hello Sophia!  |
		| Charlie | Hello Charlie! |
		| Emily   | Hello Emily!   |
	
Scenario: Verification of Error page
	# These steps cover the testing of REQ-UI-07
	When I click on Error button
	Then I should get 404 response code	
