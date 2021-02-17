---
Order: 20
Title: Examples
Description: Example usage of oehen.arguard
---

# Usage of factory methods

Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.

```csharp
// Creation of a maybe for a declared reference type which could be instantiated or not.
var foo = new Foo();
var maybeFoo = Maybe.Some(foo);

// Creation of a maybe for a reference type which is null.
var maybeFoo2 = Maybe.None<Foo>();

// Creation of a maybe for a declared nullable value type which could be instantiated or not.
int? number = 5;
var maybeNumber = Maybe.SomeStruct<int>(number);

// Creation of a maybe for a nullable value type which is null.
var maybeNumber2 = Maybe.NoneStruct<int>();
```
