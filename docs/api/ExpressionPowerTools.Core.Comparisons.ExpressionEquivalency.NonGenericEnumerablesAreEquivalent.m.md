﻿# ExpressionEquivalency.NonGenericEnumerablesAreEquivalent Method

[Index](../index.md) > [ExpressionPowerTools.Core](ExpressionPowerTools.Core.a.md) > [ExpressionPowerTools.Core.Comparisons](ExpressionPowerTools.Core.Comparisons.n.md) > [ExpressionEquivalency](ExpressionPowerTools.Core.Comparisons.ExpressionEquivalency.cs.md) > **NonGenericEnumerablesAreEquivalent**

Ensures two enumerables are same length an each value is equivalent.

## Overloads

| Overload | Description |
| :-- | :-- |
| [NonGenericEnumerablesAreEquivalent(IEnumerable srcEnumerable, IEnumerable tgtEnumerable)](#nongenericenumerablesareequivalentienumerable-srcenumerable-ienumerable-tgtenumerable) | Ensures two enumerables are same length an each value is equivalent. |
## NonGenericEnumerablesAreEquivalent(IEnumerable srcEnumerable, IEnumerable tgtEnumerable)

Ensures two enumerables are same length an each value is equivalent.

```csharp
public static Boolean NonGenericEnumerablesAreEquivalent(IEnumerable srcEnumerable, IEnumerable tgtEnumerable)
```

### Return Type

 [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean)  - A flag indicating whether the two are equivalent.

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `srcEnumerable` | [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable) | The source [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable) . |
| `tgtEnumerable` | [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable) | The target [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable) . |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
