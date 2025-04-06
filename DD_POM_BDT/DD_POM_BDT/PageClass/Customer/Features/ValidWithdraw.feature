Feature: Withdraw amount using valid 

A short summary of the feature

@FunctionalTest
Scenario: Withdraw amount from Customer Account
	Given Open browser till login
	When Click the withdrawl button and enter amount
	And Click withdrawl submit button
	Then Amount will be withdrawl from account
	And Close the window now