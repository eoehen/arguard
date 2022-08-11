# oehen.arguard

oehen.arguard is a dotnet argument and parameter validator extension library.

## Installation

Use the nuget package manager to install oehen.arguard:

Package [oehen.arguard](https://www.nuget.org/packages/oehen.arguard) is publish to [nuget.org](https://www.nuget.org/).

`dotnet add package oehen.arguard --version <VERSION>`

## Usage

### Usage in a constructor

This example shows a solution to check constructor parameter and assign them to local fields in one line.

```c#
    public class ClassA
    {
        private readonly string _text;
        private readonly int _number;

        public ClassA(string name, int number)
        {
            // name should not be null or whitespace
            _text_ = text.ThrowIfIsNullOrWhiteSpace(nameof(text));

            // number should be greater than zero
            _number = number.ThrowIfIsLessThanZero(nameof(number));

            // ...
        }
    }
```

### Usage in a method

This example shows a solution to check the parameter of a public method.

```c#
    public void DoSomethingWithThisApple(Apple apple)
    {
        apple.ThrowIfNull(nameof(apple));

        // ...
    }
```

## Documentation

The latest documentation can find at [https://eoehen.github.io/arguard/](https://eoehen.github.io/arguard/).

## License

[![License](http://img.shields.io/:license-mit-blue.svg)](https://github.com/eoehen/arguard/blob/master/LICENSE)
