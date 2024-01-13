Feature: Add Items in my cart

As a user,
I am able to add 4 items to cart and 
I should be able remove the lowest price item

Scenario: Validation of adding and removing items in my cart
	Given I add four random items to my cart
	When I view my cart
	Then I find total four items listed in my cart
	When I search for lowest price item
	And I am able to remove the lowest price item from my cart
	Then I am able to verify three items in my cart
