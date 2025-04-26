Feature: Shipment Feature

A short summary of the feature

@tag1
Scenario: Fill the shipment details and order should be placed
	Given Goto url and login and add products and checkout
	When Fill the shipment details
	Then Order will be placed
