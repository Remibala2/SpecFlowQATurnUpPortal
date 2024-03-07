Feature: This feature contains test scenarios for the following
1. Login
2. Create TM
3. Edit TM
4. Delete TM

Scenario Outline: Login - Verify user is able to login with valid credentials
Given user navigate to turnup portal
When user enters valid credentials <username> <password>
Then user is logged in successfully and lands on homepage with correct user name

Examples:
| username | password |
| 'hari'   | '123123' |

Scenario Outline: CreateTM - Verify user is able to create new TM entry
Given user login to turnup portal <username> <password>
When user creates a new TM record <code> <description> <price>
Then system should save the new record <code>

Examples: 

| username | password | code    | description | price |
| 'hari'   | '123123' | 'DTU65' | 'test'      | '2'   |

Scenario Outline: EditTM - Verify user is able to edit new TM entry
Given user login to turnup portal <username> <password>
When user edits last created TM record <code> <description> <price>
Then system should save changes to the last record <code>

Examples:

| username | password | code  | description | price |
| 'hari'   | '123123' | 'DTU65' | 'testedit'        | '2'     |

Scenario Outline: DeleteTM - Verify user is able to delete last created TM entry
Given user login to turnup portal <username> <password>
When user deletes last created TM record <code>
Then system should delete last record <code>

Examples:

| username | password | code  |
| 'hari'   | '123123' | 'DTU65' |