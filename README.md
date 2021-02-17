# oehen.arguard

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/a5b2507f45fa4392a73d162648bf33f1)](https://app.codacy.com/gh/eoehen/arguard?utm_source=github.com&utm_medium=referral&utm_content=eoehen/arguard&utm_campaign=Badge_Grade_Settings)
[![NuGet](https://img.shields.io/nuget/v/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard) [![NuGet Downloads](https://img.shields.io/nuget/dt/oehen.arguard.svg)](https://www.nuget.org/packages/oehen.arguard/)

![oehen.arguard](docs/logo/arguardlogo_1000x400.png)

oehen.arguard is a dotnet argument and parameter validator extension library.

## Installation

Use the nuget package manager to install oehen.arguard:

Package [oehen.arguard](https://www.nuget.org/packages/oehen.arguard) is publish to [nuget.org](https://www.nuget.org/).

`dotnet add package oehen.arguard --version <VERSION>`

## Usage

How to throw an `NullArgumentException` if the argument `apple` is null:

`apple.ThrowIfNull(nameof(apple));`

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

`dotnet cake .\recipe.cake --bootstrap`

`dotnet cake .\recipe.cake`

## Code Coverage

[![codecov](https://codecov.io/gh/eoehen/arguard/branch/develop/graph/badge.svg?token=9B8NT9L82D)](https://codecov.io/gh/eoehen/arguard)

## Contributing

Contributions are welcome. See [Contribution Guidelines](CONTRIBUTING.md).

## License

[![License](http://img.shields.io/:license-mit-blue.svg)](https://github.com/eoehen/arguard/blob/master/LICENSE)
