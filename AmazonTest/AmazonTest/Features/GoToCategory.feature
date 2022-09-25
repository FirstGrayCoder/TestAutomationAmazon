Feature: GoToCategory
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a unregistered/registered amazon user
I need to be able to go to product category page

Link to a feature: [GoToCategory](AmazonTest/Features/GoToCategory.feature)

@criticalPath
Scenario: GoToCategory
	Given I open Home page of Amazon
	When I push burger menu button
	And I push Amazon music button
	And I push Amazon Podcasts button
	Then Page with list of songs should be opened
