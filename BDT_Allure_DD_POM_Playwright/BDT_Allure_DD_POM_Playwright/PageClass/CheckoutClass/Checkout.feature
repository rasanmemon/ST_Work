Feature: Checkout feature

A short summary of the feature

@FunctionalTest
Scenario: Checkout by selecting product
	Given Goto url and login
	When Select products and go to cart and checkout
	Then Checkout information will be overview
