Feature: Withdraw using invalid amount

A short summary of the feature

@FunctionalTest
Scenario: Withdraw amount from Customer Account
	Given From Open browser till login
	When Click the withdrawl button and enter invalid amount
	And Click the withdrawl submit button
	Then Amount will not be withdrawl from account
	And Close the browser window 