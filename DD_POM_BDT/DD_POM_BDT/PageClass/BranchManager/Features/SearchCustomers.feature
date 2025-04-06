Feature: Customers searching using search bar 

A short summary of the feature

@FunctionalTesting
Scenario: Search for the customers in search bar  
	Given Steps till Open Account
	When Click on the customer button
	And Select the search bar and search as any detail
	Then The table show the user data on table
	And Close the window
