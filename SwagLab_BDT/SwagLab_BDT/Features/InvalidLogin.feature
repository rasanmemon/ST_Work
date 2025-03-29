Feature: Invalidate the login functionality of application of SwagLab

A short summary of the feature

@FunctionalTesting
Scenario: Validate with wrong Login Id and Password
	Given User will be able open the browser and go to the url
	When Enter the invalid Login id
	And Enter the invalid password
	And Click the login button
	Then User should not be logged in to the application and application showed error
