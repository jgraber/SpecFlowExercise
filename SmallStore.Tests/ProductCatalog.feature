Feature: ProductCatalog
	In order to browse the product catalog
	I want to see a list of products

Scenario: Browsing the catalog
	Given the product catalog has 5 items
	When I navigate to the store
	Then I find those 5 items on the start page
