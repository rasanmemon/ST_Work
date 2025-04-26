Feature: ValidLogin using right username and password

A short summary of the feature

@FunctionalTest
Scenario: Login with valid details
	Given Goto url
	When Provide details and click login
	Then Should be able to login and product page show
