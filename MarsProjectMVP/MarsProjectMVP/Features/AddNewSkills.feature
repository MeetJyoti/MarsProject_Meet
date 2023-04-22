Feature: AddNewSkills

I would like to add, edit the language in the Mars application
So that other people can see my profile details

@tag1
Scenario: 01) Add new Skills 
	Given I logged into Mars application
	When I add new Skills and Level
	Then The record should be added successfully

Scenario: 02) Adding Existing Skills 
	Given I logged into Mars application
	When I add Existing Skills
	Then The record should not be added successfully, should throw notofication

Scenario Outline: 03) Edit the created skills
Given I logged into Mars application
When I edit the existing skills
Then The record should have edited successfully

Scenario Outline: 04) Delete the Skill record
Given I logged into Mars application
When I delete the existing skill
Then The record should have deleted successfully