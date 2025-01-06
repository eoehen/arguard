---
Order: 10
Title: Introduction
Description: Introduction of oehen.arguard library
---

# Introduction

The oehen.arguard is a .NET extension nuget library package for argument validation.

# Advantages

What is the benefit to validate parameters of public methods?

* It identifies exactly what parameter of a method are incorrect.
* It makes the code fail on invalid input even if some other condition means that the value isn't dereferenced.
* It makes the exception occur before the method could have any other side-effects you might reach before the first dereference.
* It means you can be confident that if you pass the parameter into something else, you're not violating their contract.
* It documents your method's requirements with source code.
* Throw a `ArgumentNullException` instead `NullReferenceException` can help to find the responsible part is something with the parameter value.
* Parameter validation is expected by various code analysis systems.

# Implementation

All validation implementations are extended methods starting with `[argument].Throw...` corresponded of the argument datatype.
