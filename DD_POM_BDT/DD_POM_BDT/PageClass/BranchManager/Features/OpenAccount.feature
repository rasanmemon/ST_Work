Feature: OpenAccount of Customer

A short summary of the feature

@tag1
Scenario: Open Account of Customer using details
	Given Steps till Add Customer
	When Now Click Open Account Button 
	And Select Customer and its Currency
	And Click Process button 
	Then Alert will generate which tell account is created.
	And Now Close browser
