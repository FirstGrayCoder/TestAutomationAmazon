Feature: SignInToSite
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site
As a registered amazon user
I want to be able to Sign in to site

Link to a feature: [SignInToSite](AmazonTest/Features/SignInToSite.feature)

@smoke
Scenario Outline: SignIn
	Given I open sign in page of site
	When I input '<email>' to inpun field
	And I push Continue button
	Then Page for input password shoul be opened
	And I input '<password>' to inpun field
	And I push SignIn button
	Then Home page with '<user name>' should be opened

Examples: 
	| email           | password | user name |
	| rekvest@ukr.net | NetX1lf  | TestOne   |
	

