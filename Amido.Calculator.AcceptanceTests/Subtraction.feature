Feature: Substraction
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the substraction of 2 numbers

Scenario: Subtract two numbers
	Given I have cleared any previous result
	When I take away 20 from 30
	Then the result should be 10
