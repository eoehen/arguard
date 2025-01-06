---
Order: 20
Title: Examples
Description: Example usage of oehen.arguard
---

# Argument null validation example

This example throws an `ArgumentNullException` if the parameter `foo` is null.

## Previous example

Example for the previous argument validation:

```csharp
public void ExampleMethodWithoutArguard(object foo)
{
    if (foo is null)
    {
        throw new ArgumentNullException();
    }

    this.localVar = foo;

    // ...
}
```

## arguard example

Example argument validation with oehen.arguard library:

```csharp
public void ExampleMethodWithArguard(object foo)
{
    this.localVar = foo.ThrowIfNull(nameof(foo));

    // ...
}
```

More examples in the API documentation.
