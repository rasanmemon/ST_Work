Feature: Delete the Customer 

A short summary of the feature

@FunctionalTesting
Scenario: Delete for the customers
	Given Steps till Search Customer
	When Click the delete button of user want to delete
	Then Customers data will be deleted
	And Close window
