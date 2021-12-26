﻿Feature: ProfileDescription
	As a Seller on Mars
	I would like to add my Profile Details such as Profile Description.
	So that
	The people seeking for my profile can know more about me.

@addDescription1
Scenario: 1. Adding of the Profile Description with records
	 Given I login to the Trade Skills portal description successfully
     And I click on the description pen icon
     When I add the '<Description>' and click on Save button
     Then the Description should be added as '<Description>' successfully
     Then I click on close browserSeven

     Examples:
     | Description                       |
     |I'm Shalan Lohar. Looking for a software automation tester role. |

     @editDescription
Scenario: 2. Editing of the Profile Description with records
	Given I login to the Trade Skills portal description successfully
    And I click on the description pen icon
    When I edit the '<Description>' and click on Save button
    Then the Description should be updated as '<Description>' successfully
    Then I click on close browserEight

    Examples:
    | Description                                                                                |
    | Software Testers are responsible for the quality of software development and deployment. |