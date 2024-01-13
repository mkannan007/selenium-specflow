Feature: AddToCart

As a user,
I am able to add 4 items to cart and 
I should be able remove the lowest price item

Scenario: Validation of adding and removing items in my cart
	Given I add 4 random items to my cart
	When I view my cart
	Then I should see total 4 items listed in my cart
	When I search and remove the lowest price item from my cart
	Then I should see total 3 items listed in my cart
	#Then I am able to verify three items in my cart
