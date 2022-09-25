Feature: WrongEmail
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a unregistered amazon user
I can`t be able to Sign in to site

Link to a feature: [WrongEmail](AmazonTest/Features/WrongEmail.feature)

@criticalPath
Scenario Outline: WrongEmail
	Given I open SignIn page
	When I input wrong '<email>' to input field
	And I push Continue button with wrong password
	Then Caution message should be appeard

Examples: 
	| email       | password | user name |
	| wrong@jj.kk | NetX1lf  | TestOne   |
	