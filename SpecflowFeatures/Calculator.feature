Feature: CalculatorFeature
	Simple calculator for adding two numbers

@mytag
Scenario: Example 1
	Given I have an instruction input file 'Example1.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#| 2   |     | 3       |        | 3     |
	When I calculate as per instructions in the file
	Then the result should be 15

Scenario: 01Example 2
	Given I have an instruction input file 'Example2.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#|     |     | 9       |        | 5     |
	When I calculate as per instructions in the file
	Then the result should be 45

Scenario: Test 1
	Given I have an instruction input file 'Test1.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#| 6   | 2   | 8       | 4      | 9     |
	When I calculate as per instructions in the file
	Then the result should be 26

Scenario: Test 2
	Given I have an instruction input file 'Test2.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#| 2   | 3   | 4       | 5      | 6     |
	When I calculate as per instructions in the file
	Then the result should be 4

Scenario: Test 3 decimal value
	Given I have an instruction input file 'Test3.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#| 5   | 4   | 3       | 7		| 1     |
	When I calculate as per instructions in the file
	Then the result should be 0.8571428571428571

Scenario: Test 4 negative value
	Given I have an instruction input file 'Test4.txt'
	# With below values
	#| add | sub | mutiply | divide | apply |
	#| -5  | -4  |  3      | -7		| -6    |
	When I calculate as per instructions in the file
	Then the result should be 3