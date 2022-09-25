Feature: BuyProduct
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a registered amazon user
I would to be able to buy products on Amazon

Link to a feature: [BuyProduct](AmazonTest/Features/BuyProduct.feature)

@criticalPath
Scenario Outline: BuyProduct
	Given I open product  page as registered user with valid '<email>' and '<password>'
	When I change delivery country
	And I click Buy now button
	Then Shipping page should be opened

Examples: 
| email           | password |
| rekvest@ukr.net | NetX1lf  |
