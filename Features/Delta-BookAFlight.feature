Feature: Delta-BookAFlight

A short summary of the feature

@tag1
Scenario: Search for a flight
	Given I have a browser navigated to the Delta homepage showing the book a flight tool
	When I search for a flight AAAdefined by the cookie history loaded in the profile user
	Then I should see a list of available flights
	