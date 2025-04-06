Feature: Check Transaction Between Dates

A short summary of the feature

@FunctionalTesting
Scenario: Check Transaction Between Dates
	Given Open Browser to Transaction option
	When Set Start and End Date
	Then Get records of between dates
	And close the window now
