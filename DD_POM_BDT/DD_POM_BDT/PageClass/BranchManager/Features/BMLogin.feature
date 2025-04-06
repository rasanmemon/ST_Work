Feature: Login with BranchManager in application

A short summary of the feature

@FunctionalTest
Scenario: Login by Click BM login 
	Given User will be open the browser and go to url
	When Select the branch Manager login button
	Then BranchManager should be logged in to the application and application showed three buttons
	And Then Close the browser
