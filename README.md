# TecTest

TecTest is a C# console application that determines if a given word can be formed by concatenating symbols of chemical elements from the periodic table. It returns all possible combinations of element symbols that can form the word, with each combination represented as an array of strings in the format 'elementName (elementSymbol)'.

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Running Tests](#running-tests)
- [Project Structure](#project-structure)

## Project Overview

This project includes the implementation of the `Elements` class, which provides the method `ElementalForms` to find all valid combinations of element symbols that can form a given word. The project follows Test-Driven Development (TDD) principles to ensure robustness and correctness.

## Features

- Converts a word into all possible combinations of chemical elements.
- Returns an empty array if no valid combinations are found.
- Comprehensive unit tests to ensure correctness.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (Version 7.0 or later)
- An IDE or text editor, such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
 ```
   git clone https://github.com/mbilaal1/TecTest.git
   cd TecTest
   ```

  Build the solution:
  ```
  dotnet build
  ```
  Run the console application:

  ```
  dotnet run --project TecTestAvayler
  ```
Enter a word when prompted to see the possible element forms.


### Running Tests

Unit tests are written using the NUnit framework. To run the tests:

Navigate to the test project directory:

```
cd AvaylerTests
```

Run the tests:
```
dotnet test
```

The tests cover a wide range of scenarios to ensure the Elements method works correctly.

### Project Structure
```
TecTestAvayler
├── AvaylerTests
│   ├── CodewarsTests.cs
│   └── TddTests.cs
├── TecTestAvayler
│   ├── Elements.cs
│   └── Program.cs

TecTestAvayler: Contains the main console application.
    Elements.cs: Contains the Elements class with element symbols and names and functionality.
    Program.cs: Contains the entry point of the application.
AvaylerTests: Contains the test project.
    CodewarsTests.cs: Additional test cases.
    TddTests.cs: Contains TDD-based unit tests for the Elements class.
```
