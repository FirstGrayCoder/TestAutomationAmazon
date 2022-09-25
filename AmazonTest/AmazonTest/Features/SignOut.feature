Feature: SignOut
![Amazon](https://www.amazon.com)
In order to protect my acount on the Amazon site
As a registered amazon user
I want to be able to Sign out of site

Link to a feature: [SignOut](AmazonTest/Features/SignOut.feature)

@criticalPath
Scenario Outline: SignOut
	Given Home page after succesefull avtorisation with valid '<email>' and '<password>'
	When I move mouse to my user '<login>'
	And I click on LogOut button from dropdown menu
	Then SignIn page should be opened

Examples: 
| email           | password | login   |
| rekvest@ukr.net | NetX1lf  | TestOne |

