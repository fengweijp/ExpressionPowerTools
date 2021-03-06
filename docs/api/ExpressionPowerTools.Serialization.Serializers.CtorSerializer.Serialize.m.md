﻿# CtorSerializer.Serialize Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Serializers](ExpressionPowerTools.Serialization.Serializers.n.md) > [CtorSerializer](ExpressionPowerTools.Serialization.Serializers.CtorSerializer.cs.md) > **Serialize**

Serialize a [NewExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.newexpression) .

## Overloads

| Overload | Description |
| :-- | :-- |
| [Serialize(NewExpression expression, SerializationState state)](#serializenewexpression-expression-serializationstate-state) | Serialize a [NewExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.newexpression) . |
## Serialize(NewExpression expression, SerializationState state)

Serialize a [NewExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.newexpression) .

```csharp
public virtual CtorExpr Serialize(NewExpression expression, SerializationState state)
```

### Return Type

 [CtorExpr](ExpressionPowerTools.Serialization.Serializers.CtorExpr.cs.md)  - The serializable [CtorExpr](ExpressionPowerTools.Serialization.Serializers.CtorExpr.cs.md) .

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `expression` | [NewExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.newexpression) | The [NewExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.newexpression) to serialize. |
| `state` | [SerializationState](ExpressionPowerTools.Serialization.Serializers.SerializationState.cs.md) | State, such as [JsonSerializerOptions](https://docs.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions) , for the serialization. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
