@UIRegression
Feature: IDP001 Login Using Valid Credentials
	As a standard user
	I want to ensure that I can login using valid account credentials

# Stories tested in this feature
# IDP25537 : Create Gherkin Tests for IDP Happy Path – 3 Points (Kai)
# IDP25539 : Automate IDP Smoke Test Using Selenium 

Background:
	#No Background for current feature
Scenario: UI-Login -01- Login using valid account credentials
	Given the user "test.users@justretirement.com" has an account with password "Password123" and logs in
	
	Then he should see the Login Successful page