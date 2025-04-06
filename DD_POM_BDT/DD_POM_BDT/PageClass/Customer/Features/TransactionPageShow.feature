Feature: Transaction page show

A short summary of the feature

@FunctionalTest
Scenario: Transaction record show to Customer 
	Given Browser open to login
	When Click the Transaction button 
	Then Transaction page shows
	And Reset the page
	And Back to main page
	And close window now
