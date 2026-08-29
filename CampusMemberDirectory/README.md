# CAMPUS MEMBER DIRECTORY
The project demonstrates **inheritance** from OOPS.

## Problem Statement

The Campus Member Directory is a C# application designed to represent different types of members within a campus, such as students and lecturers.

The system uses object-oriented programming principles like inheritance and polymorphism, to represent common and type-specific behaviour. **A common abstract CampusMember class stores shared information such as the member's name, while derived classes such as Student and Lecturer provide their own role-specific information and behaviour**.

## Design Overview
The system uses an abstract base class called `CampusMember`.

`CampusMember`

CampusMember is the common base class for all campus members.

It contains:

-` Name` – a read-only property shared by all members.
- `DescribeRole()` – an abstract method that requires each derived class to provide its own implementation.
- `Introduction()` - a virtual method that uses DescribeRole() and can be overridden by the derived classes
- Constructor validation to ensure that the member name is not null, empty, or whitespace.

**`Student`**

Student inherits from CampusMember.

It contains student-specific information such as:

`Programme`

It implements `DescribeRole()` to provide a description specific to a student.

**`Lecturer`**

Lecturer inherits from CampusMember.

It contains lecturer-specific information such as:

`Department`

It implements `DescribeRole()` to provide a description specific to a lecturer.

*The inheritance structure allows common state to be defined once in CampusMember while derived classes implement their own specialized behaviour.*

## Class diagram

## Build and Test
- Build the solution from the repository root:

`dotnet build`

- Run all tests

`dotnet test`

## Test Summary
- An exhaustive test suite is given in [CampusMemberDirectory.Test](./CampusMemberDirectory.Tests)
- All 20 tests are passed

### References
- [Microsoft Learn C# and MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)
- [C# Tutorial Geeks for Geeks](https://www.geeksforgeeks.org/c-sharp/csharp-programming-language/)