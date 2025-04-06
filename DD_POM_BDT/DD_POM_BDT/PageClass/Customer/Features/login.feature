Feature: Login with Customer in application

A short summary of the feature

@FunctionalTest
Scenario: Login with UserName 
	Given User will be open the browser and go to the url
	When Select the customer login button
	And Click dropdown and select user name option and Click the login button 
	Then Customer should be logged in to the application and application showed welcomePage
	And Close the browser
