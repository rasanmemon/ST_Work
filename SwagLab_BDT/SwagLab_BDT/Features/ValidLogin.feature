Feature: Validate the login functionality of application of SwagLab

A short summary of the feature

@FunctionalTest
Scenario: Validate with correct Login Id and Password
	Given User will be open the browser and go to the url
	When Enter the valid Login id
	And Enter the password
	And Click login button
	Then User should be logged in to the application and application showed Product page
