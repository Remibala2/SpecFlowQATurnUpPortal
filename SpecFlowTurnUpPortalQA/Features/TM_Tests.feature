Feature: This feature contains test scenarios for the following
1. Login
2. Create TM
3. Edit TM
4. Delete TM

Scenario: Login - Verify user is able to login with valid credentials
Given user navigate to turnup portal
When user enters valid credentials
Then user is logged in successfully and lands on homepage with correct user name

Scenario: CreateTM - Verify user is able to create new TM entry
Given user login to turnup portal
When user creates a new TM record
Then system should save the new record

Scenario: EditTM - Verify user is able to edit new TM entry
Given user login to turnup portal
When user edits last created TM record
Then system should save changes to the last record

Scenario: DeleteTM - Verify user is able to delete last created TM entry
Given user login to turnup portal
When user deletes last created TM record
Then system should delete last record