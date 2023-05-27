Feature: LanguageFeature

As a seller, I would like to sign up to MarsQA portal and add languages that I know.
So people seeking for some skills can look into it.

@tag1
Scenario: 01) Adding Language
	Given I Logged Into Mars App
	When Adding Language on my profile, '<LanguageAdd>', '<ChooseLanguageLevel>'
	Then The language should be added succesfully

	Examples: 
	| LanguageAdd		| ChooseLanguageLevel |
	|     English    |          Basic      |
	|     Spanish     |          Fluent     |


Scenario: 02) -  Adding Invalid input for Language Record
	Given I Logged Into Mars App
	When Pre Existing record is entered, '<LanguageAdd>', '<ChooseLanguageLevel>'
	Then Should result in a notification
	 
	 	Examples: 
	| LanguageAdd		| ChooseLanguageLevel |
	|        English    |          Basic      |
	|     Spanish       |          Fluent     |
