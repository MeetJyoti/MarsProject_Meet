Feature: EducationFeature

I would like to add, edit the Education in the Mars application
So that other people can see my profile details

@tag1
Scenario Outline: 01) Add new Education 
	Given I Logged Into Mars Portals
	When I add new Education Details, '<Collegename>', '<CountryName>', '<Degree>', '<Year>'
	Then The Education record should be added successfully

	Examples: 
	| Collegename | CountryName | 		 Degree              | Year |
	| Massey      | Philippines | 		 Information Science |    2010 |
	| Otago       | Canada		| 		 Civil               |      2018|
	| AUT         | Oman        |      Mechanical          |     2019 |

Scenario: 02) Checking Same University name for Different Country
	Given I Logged Into Mars Portals
	When I add Same University Name and Different Country
	Then The record should have added successfully

Scenario Outline: 03) Adding Existing Education Details
	Given I Logged Into Mars Portals 
	When I add  existing Education
	Then The record should throw notification and should not add 

Scenario Outline: 04) Edit the Education record
	Given I Logged Into Mars Portals
	When I Edit the existing Education
	Then The record should have Edited successfully

Scenario Outline: 05) Delete the Education record
	Given I Logged Into Mars Portals 
	When I Delete the existing Education
	Then The record should have Deleted successfully
