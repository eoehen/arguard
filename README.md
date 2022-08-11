# oehen.arguard

[![NuGet](https://img.shields.io/nuget/v/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard) [![NuGet Downloads](https://img.shields.io/nuget/dt/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard/)

![oehen.arguard](docs/logo/arguardlogo_1000x400.png)

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

## Information

| | Stable | Pre-release |
|:--:|:--:|:--:|
|GitHub Release|[![GitHub prerelease](https://img.shields.io/github/v/release/eoehen/arguard?include_prereleases)](https://github.com/eoehen/arguard/releases/latest)|[![GitHub release](https://img.shields.io/github/v/release/eoehen/arguard)](https://github.com/eoehen/arguard/releases/latest)|
|NuGet|[![NuGet](https://img.shields.io/nuget/v/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard)|[![NuGet](https://img.shields.io/nuget/vpre/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard)|

## Build

|Develop|Master|
|:--:|:--:|
|![develop](https://github.com/eoehen/arguard/workflows/CI-Build/badge.svg?branch=develop)|![master](https://github.com/eoehen/arguard/workflows/CI-Build/badge.svg?branch=master)|

To build this package we are using [Cake.Recipe](https://github.com/cake-contrib/Cake.Recipe).

On Windows PowerShell run:

`.\build.ps1`

### New Release

- Prepare [Milestone](https://github.com/eoehen/arguard/milestones) for releasing.
- Create and switch to gitflow release branch.
- Set `GITHUB_TOKEN` environment variable.

> `$Env:GITHUB_TOKEN="{token}"`

- Run `Cake.Recipe` for creating release notes.

> `.\build.ps1 --target=releasenotes`

- Check release notes.
- Merge gitflow release branche to develop and master.
- Finish the created [release](https://github.com/eoehen/arguard/releases) version on github.

## Code Coverage & Quality

[![codecov](https://codecov.io/gh/eoehen/arguard/branch/develop/graph/badge.svg?token=9B8NT9L82D)](https://codecov.io/gh/eoehen/arguard)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/b09d240a2f6a4a398a582ff7295f4830)](https://www.codacy.com/gh/eoehen/arguard/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=eoehen/arguard&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/b09d240a2f6a4a398a582ff7295f4830)](https://www.codacy.com/gh/eoehen/arguard/dashboard?utm_source=github.com&utm_medium=referral&utm_content=eoehen/arguard&utm_campaign=Badge_Coverage)

## Contributing

Contributions are welcome. See [Contribution Guidelines](CONTRIBUTING.md).

## License

[![License](http://img.shields.io/:license-mit-blue.svg)](https://github.com/eoehen/arguard/blob/master/LICENSE)
