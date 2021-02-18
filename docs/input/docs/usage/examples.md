---
Order: 20
Title: Examples
Description: Example usage of oehen.arguard
---

# Argument null validation example

This example throws an `ArgumentNullException` if the parameter `foo` is null.

Example without oehen.arguard package

```csharp
public void ExampleMethodWithoutArguard(object foo)
{
    if (foo is null)
    {
        throw new ArgumentNullException();
    }

    // ...
}
```

Example with oehen.arguard package

```csharp
public void ExampleMethodWithArguard(object foo)
{
    foo.ThrowIfNull(nameof(foo));

    // ...
}
```

More examples in the API documentation.
