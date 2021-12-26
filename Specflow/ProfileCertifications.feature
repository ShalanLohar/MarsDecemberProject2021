Feature: ProfileCertifications
	As a Seller on Mars
	I would like to add my Profile Details such as Certifications.
	So that
	The people seeking for my profile fields which can show in the Certifications.

@addCertifications1
Scenario: 1. Adding of the Seller Profile Certifications with invalid records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on Add New button under Certifications tab
	When I enter the records in '<Certificate>', '<From>' and click on Add button
	Then The error popup message '<Message>' will shown
	Then I click on close browserTwo

	Examples:
	| Certificate | From  | Year | Message                                                                    |
	| SCRUM    | 2016 |      |Please enter Certification Name, Certification From and Certification Year|


@addCertifications2
Scenario: 2. Adding of the Seller Profile Certifications with valid records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on the Add New button under Certifications tab
	When I enter the details in '<Certificate>', '<From>', '<Year>' and click on add button
	Then The display popup message '<Message>' will appear
	And A new row should be added as in '<Certificate>', '<From>', '<Year>' successfully
	Then I click on close browserThree

	Examples:
	| Certificate | From  | Year | Message                                    |
	|ISTQB      | New Zealand | 2016|ISTQB has been added to your certification|

	@addCertifications3
Scenario: 3. Adding of the Seller Profile Certifications with duplicate records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on the Add New button under Certifications section
	When I enter the record in '<Certificate>', '<From>', '<SecondYear>' and click on Add button
	And The error popup message of '<Message>' will be shown
	And I enter the record '<Certificate>', '<From>', '<SecondYear>' and click on add button
	Then The display error popup message '<Message>' will shown
	Then I click on close browserFour

	Examples:
	| Certificate | From  | Year | SecondYear | Message                            |
	| ISTQB     | New Zealand| 2016| 2019       |Duplicated data|
	| ISTQB       | New Zealand | 2016 | 2020       |Duplicated data|

@editCertifications
Scenario: 4. Editing of the Seller Profile Certifications with records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on the Certification pen icon
	When edit the data in '<Certificate>', '<From>', '<Year>' and click on Add button
	And The display prompt message '<Message>' will appear
	Then The new row should be updated as '<Certificate>', '<From>', '<Year>' successfully
	Then I click on close browserFive

	Examples:
	| Certificate | From     | Year | Message                                         |
	| AGILE   | INDIA | 2020 | AGILE has been updated to your certification |

@deleteCertifications
Scenario: 5. Deleting of the Seller Certifications Language
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on delete icon under Certification tab
	When The prompt message of the '<Message>' will appear
	Then the Certification should have the deleted successfully
	Then I click on close browserSix

	Examples:
	| Message                                           |
	| AGILE has been deleted from your certification |
