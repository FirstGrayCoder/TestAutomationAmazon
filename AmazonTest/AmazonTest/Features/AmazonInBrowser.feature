Feature: AmazonInBrowser
![Ebay](https://www.amazon.com/)
In order to buy/sell products on the Amazon site
As a internet user
I want to be able to open Amazon site

Link to a feature: [AmazonInBrowser](AmazonTests/Features/AmazonInBrowser.feature)

@smoke
Scenario: SearchAmazonInBrowser
	Given I open browser
	When I input site name to the address line of the browser
	And I click google search button 
	Then Site Amazon should be appear in search result page
