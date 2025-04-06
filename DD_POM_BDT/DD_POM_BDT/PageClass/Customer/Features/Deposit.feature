Feature: Deposit amount 

A short summary of the feature

@FunctionalTest
Scenario: Deposit amount in Customer Account
	Given User will be open the browser and go to the url and login
	When Click the deposit button and enter amount
	And Click deposit submit button
	Then Amount will be deposited in account
	And Close window now