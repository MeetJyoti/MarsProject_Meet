Feature: EducationFeature

I would like to add, edit the Education in the Mars application
So that other people can see my profile details

@tag1
Scenario: 01) Add new Education 
	Given I Logged Into Mars Portal 
	When I add new Education and Details
	Then The Education record should be added successfully

Scenario: 02) Checking Same University name for Different Country
	Given I Logged Into Mars Portal 
	When I add Same University Name and Different Country
	Then The record should have added successfully

Scenario Outline: 03) Adding Existing Education Details
	Given I Logged Into Mars Portal 
	When I add  existing Education
	Then The record should throw notification and should not add 

Scenario Outline: 04) Edit the Education record
	Given I Logged Into Mars Portal 
	When I Edit the existing Education
	Then The record should have Edited successfully

Scenario Outline: 05) Delete the Education record
	Given I Logged Into Mars Portal 
	When I Delete the existing Education
	Then The record should have Deleted successfully
