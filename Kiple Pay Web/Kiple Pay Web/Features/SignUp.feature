Feature: As a User
	I want to Sign Up for Kiple Pay App
	so that I can use Kiple Pay

@SignUp
Scenario Outline: Sign Up for Kiple Pay App
	Given I navigate to Kiple Pay website
	Then verify navigated to Kiple Pay Website
	When I click on Sign UP button in menu bar
	Then verify navigated to sigh up page
	When I enter full name <fullName> in name text field
	When I enter email address <emailAddress> in email text field
	When I enter password <password> in password text field
	When I enter same password <password> in verify text field
	When I accept privacy terms
	When I click on sign up button after entering all details
	Then verify output messages
	Then close session of driver
Examples:
          | fullName          | emailAddress    | password |
          | Automation Tester | testng@test.com | Test123- |
          

 

	