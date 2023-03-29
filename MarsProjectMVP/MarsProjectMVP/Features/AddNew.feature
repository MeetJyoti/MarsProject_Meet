Feature: AddNew

I would like to add, edit the language in the Mars application
So that other people can see my profile details

@tag1
Scenario: Add new Skills 
	Given I logged into Mars application
	When I add new Skills and Level
	Then The record should be added successfully
