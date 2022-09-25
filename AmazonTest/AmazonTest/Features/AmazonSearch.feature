Feature: AmazonSearch
![Amazon](https://www.amazon.com)
In order to buy products on the amazon site
As a amazon user
I want to be able to search product on site

Link to a feature: [AmazonSearch](AmazonTests/Features/AmazonSearch.feature)

@criticalpath
Scenario Outline: AmazonSearch
	Given I open  '<site page>' of Amazon
	When I input '<search word>' to the search field
	And I click site search button 
	Then Page with '<search results of word>' should be opened


Examples: 
	| site page                                        | search word      | search results of word |
	| https://amazon.com                               | Sony Playstation | Sony Playstation       |
	| https://www.amazon.com/gp/goldbox?ref_=nav_cs_gb | Iphone           | iPhone                 |

