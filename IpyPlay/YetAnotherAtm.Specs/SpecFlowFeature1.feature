Feature: Cash Withdrawal
	In order to use my money
	As a consumer
	I want withdraw cash from an ATM

Scenario: Successful withdrawal from an account
	Given I have deposited $100 in my account
	When I request $20
	Then I see $20 dispensed
