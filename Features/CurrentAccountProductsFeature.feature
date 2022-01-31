Feature: CurrentAccountProductsFeature
	Simple calculator for adding two numbers

@Smoke
# Make Sure the SpecFlow Scenarios are INDEPENDENT
Scenario: Perform HomePage access to Lloyds Bank site
	Given I launch the application
	Then the page is displayed
