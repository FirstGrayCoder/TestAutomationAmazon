Feature: CustomerService
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a registered amazon user
I should to be able to get customer service

Link to a feature: [CustomerService](AmazonTest/Features/CustomerService.feature)

@criticalPath
Scenario Outline: CustomerService
	Given I open Customer service page as registered user with valid '<email>' and '<password>'
	When I click International shopping button
	And I click Free shipping en other promotions button
	And I click Free shipping eligibility button
	Then Help information should be appeard

Examples: 
| email           | password |
| rekvest@ukr.net | NetX1lf  |
