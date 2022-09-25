Feature: UnregisteredCanNotAddProductToList
![Amazon](https://www.amazon.com)
In order to buy products on the Amazon site only for registered users
As a unregistered amazon user
I would not to be able to add product to my list on Amazon

Link to a feature: [UnregisteredCanNotAddProductToList](AmazonTest/Features/UnregisteredCanNotAddProductToList.feature)

@criticalPath
Scenario: UnregisteredCanNotAddProductToList
	Given I open page of product
	When As unregistered user I push Add to List button
	Then SignIn page should be opened for signin or register
