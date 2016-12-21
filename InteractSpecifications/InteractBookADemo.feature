Feature: InteractBookADemo
	In order to understand how Interacts products work
	As a Customer
	I want to book a demo online


Scenario: Booking a demo
	Given I navigate to Interact homepage
	And I click on Book A Demo button
	When I enter the contact information
	And I click submit button
	Then Online confirmation is displayed
