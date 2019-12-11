Feature: Name Parsing
	In order to display a name is multiple different ways
    I need a way to parse a name correctly

@mytag
Scenario Outline: Parsing Names
	Given I have a <name>
	When I parse the name into first middle and last
	Then I should get the following <first>, <middle>, and <last>

	Examples:
		| name                | first   | middle | last        |
		| Steve C Harvey      | Steve   | C      | Harvey      |
		| Mariah Williams     | Mariah  |        | Williams    |
		| Madonna             | Madonna |        |             |
		| Keith Danger Dahlby | Keith   | Danger | Dahlby      |
		| Johnny B. Goode     | Johnny  | B      | Goode       |
		| Amanda Huggin-Kiss  | Amanda  |        | Huggin-Kiss |