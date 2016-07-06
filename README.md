# More xUnit Templates
A collection of Visual Studio .NET project templates, item templates, and code snippets for xUnit.net.

These templates leverage a fork of xUnit.net that provides additional test case method display options as described in:
* xUnit.net Issue [#759](https://github.com/xunit/xunit/issues/759) on GitHub
* xUnit.net Pull Request [#828](https://github.com/xunit/xunit/pull/828) on GitHub

If or when the pull request is integrated into the main xUnit.net source tree, these templates will be updated to reflect
those packages. All of the forked libraries are identical to the official libraries with the exception of the test case
method display extensions and the alternate NuGet package identifiers. They are compatible with all other xUnit.net tooling,
including the official xUnit.net Visual Studio test runner.

## Supported Languages
The current templates and code snippets support:

* Visual C#
* Visual Basic .NET

## Project Template
The project template creates a new, empty **Unit Test Project** for the target language with the following configuration:

* References to xUnit.net
* References to the xUnit.net Visual Studio test runner
* An application configuration (app.config) with the default test method display options

## Item Template
The following item templates are provided:

* A new, empty unit test class for the target language with the appropriate namespaces
* An empty definition of class data for a theory test case

## Code Snippets
The following code snippets are provided for adding various test methods:

* **fact** - Creates a fact test case
* **afact** - Creates an asynchronous fact test case
* **theory** - Creates a theory test case with inline data
* **atheory** - Creates an asynchronous theory test case with inline data
* **mdata** - Creates a new property to provide member data for a theory test case
* **theorym** - Creates a theory test case with member data
* **atheorym** - Creates an asynchronouys theory test case with member data
* **theoryc** - Creates a theory test case with class data
* **atheoryc** - Creates an asynchronouys theory test case with class data

# Example
![screenshot](screenshot.png)