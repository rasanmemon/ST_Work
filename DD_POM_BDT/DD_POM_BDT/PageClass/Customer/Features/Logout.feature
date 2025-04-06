Feature: Logout customer from application

A short summary of the feature

@FunctionalTest
Scenario: Logout customer from application
	Given From browser to login
	When Click the logout button
	Then User will be logout from application
	And close browser
