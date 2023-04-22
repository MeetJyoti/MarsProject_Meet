Feature: LanguageFeature

As a seller, I would like to sign up to MarsQA portal and add languages that I know.
So people seeking for some skills can look into it.

@tag1
Scenario: 01) Adding Language
	Given I Logged Into Mars Portal Successfully
	When Adding Language on my profile
	Then The language  should be added succesfully

Scenario: 02) -  Adding Invalid input for Language Record
	Given I Logged Into Mars Portal Successfully
	When Pre Existing record is entered
	Then Should result in a notification "Duplicated data"
	 
