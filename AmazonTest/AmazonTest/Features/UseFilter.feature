Feature: UseFilter
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a unregistered/registered amazon user
I should be able to use filters for search product what i need

Link to a feature: [UseFilter](AmazonTest/Features/UseFilter.feature)

@criticalPath
Scenario: UseFilter
	Given I open page with list of products 
	When I check filter SanDisc
	And I check filter Amazon.com
	Then Page with result what i need should be opened


