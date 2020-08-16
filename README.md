# C# Introduction Assignment – CRUD
**By: Aaron Barthel**

An application that accepts user supplied email addresses. The user can then List, Add, Edit & Delete the emails in the list.

**Trello Board:** [https://trello.com/b/CSqWUaZP/c-introduction-assignment-crud](https://trello.com/b/CSqWUaZP/c-introduction-assignment-crud)

## Requirements
* Allow the user to input data of your choice (names, numbers, etc).
* Store the data that was entered in an array of length 10.
* Allow the user to print out the currently stored data.
* Continue to allow the user to enter data until the array is full, and keep the program loop running until exited with a sentinel value.
* Allow the user to add an item to the dataset.
* Allow the user to display the dataset with the items numbered, starting at number 1 (not 0).
* If there are less than 10 items, do not display the numbers for items that aren’t populated.
* Have a basic menu to select between the above two items, and exit.
* Limit the number of items the user can enter to 10.
* Exit the program when the user enters a sentinel value of your choice (make sure to tell the user what it is).
* Program.cs has a docstring at the top with the title, purpose, your name and last modified date.
* Variable names are semantic, and in camelCase.
* Code is well formatted, code blocks are indented.
* Code is well structured, every code block has one entrance and one exit (excluding try blocks), break (except in switches), continue, goto and Environment.Exit() are not used. One return per method.
* Timesheet is submitted.
* Repository has a commit history (not just one commit at the end).
* Commit messages provide insight into what changes were made.
* Repository has a README.md.
  * README.md has a Trello link and Trello is public.
  * README.md has a citations summary.
* Repository has a .gitignore file filtering for Visual Studio Code, Visual Studio, DotNET Core, Windows, MacOS and Linux (http://gitignore.io), and it was added in time to stop unnecessary files being tracked.
* Allow the user to edit an item.
* Allow the user to select the item for editing using either number or value.
* Allow the user to delete an item.
* Allow the user to select the item for deletion using either number or value.
* Create methods for each function (create, read, update, delete). Use PascalCase for method names.
* Create a method that does the prompting and validation of the input of an item and performs any modifications (trimming, etc.) before returning the valid input. Use this method in your create and update methods.
* Sort the dataset however is appropriate for your data set (alphabetically, by length, etc.) whenever an item is added or edited.
* Prevent duplicate items from being added to the list.
  * Make duplication checking case-insensitive.
* Trim inputs of trailing and leading whitespace before adding them to the list (create / edit).
  * If duplication checking, make this trim before checking for duplicates.
* Prevent empty inputs from being added.
* Add an additional validation requirement that is appropriate for your data set.
* Add import and export options that will prompt the user for a file name, and write or read to/from that file name if it exists. The default relative pathing (inside the bin folder) is fine.
* Convert from using arrays to using the List<> object, and allow dynamically sized lists (more than 10).
* Add an unexpected / unique feature.



## Citations

  * https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparer?view=netcore-3.1
    *  Had to look up StringComparer as I needed something that Implemented IEqualityComparer so I could compare string while ignoring case.
