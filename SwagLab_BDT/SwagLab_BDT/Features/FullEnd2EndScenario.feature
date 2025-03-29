Feature: Complete Order Placement on SwagLab web application

A short summary of the feature

@FunctinalTest
Scenario: User should be logged in to the application and place order
	Given User will be open the browser and go to url
	When Enter the Login id and Password and click login button
	And Add a Product in cart and proceed to check out
	And Click the checkout button
	And Enter shipping Details
	Then Validate the order information  and total amount and finish order
	And Validate the order has been placed
	And close the browser
