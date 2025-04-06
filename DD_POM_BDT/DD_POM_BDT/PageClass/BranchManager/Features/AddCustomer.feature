Feature: AddCustomer

A short summary of the feature

@FunctionalTest
Scenario: Add Customer through details
	Given User will be open the browser and go to url and login
	When User click the add user button
	And Enter details
	And Click add customer button
	Then User will be added in application
	And Close the browser now
