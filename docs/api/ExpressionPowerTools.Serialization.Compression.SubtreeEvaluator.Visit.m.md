﻿# SubtreeEvaluator.Visit Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Compression](ExpressionPowerTools.Serialization.Compression.n.md) > [SubtreeEvaluator](ExpressionPowerTools.Serialization.Compression.SubtreeEvaluator.cs.md) > **Visit**

Vists the node.

## Overloads

| Overload | Description |
| :-- | :-- |
| [Visit(Expression exp)](#visitexpression-exp) | Vists the node. |
## Visit(Expression exp)

Vists the node.

```csharp
public virtual Expression Visit(Expression exp)
```

### Return Type

 [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression)  - The modified [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) .

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `exp` | [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) | The [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) to visit. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/13/2020 7:35:36 AM | (c) Copyright 2020 Jeremy Likness. | 0.8.8-alpha |