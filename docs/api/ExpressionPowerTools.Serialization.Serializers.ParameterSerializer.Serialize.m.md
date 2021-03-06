﻿# ParameterSerializer.Serialize Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Serializers](ExpressionPowerTools.Serialization.Serializers.n.md) > [ParameterSerializer](ExpressionPowerTools.Serialization.Serializers.ParameterSerializer.cs.md) > **Serialize**

Serializes the expression.

## Overloads

| Overload | Description |
| :-- | :-- |
| [Serialize(ParameterExpression expression, SerializationState state)](#serializeparameterexpression-expression-serializationstate-state) | Serializes the expression. |
## Serialize(ParameterExpression expression, SerializationState state)

Serializes the expression.

```csharp
public virtual Parameter Serialize(ParameterExpression expression, SerializationState state)
```

### Return Type

 [Parameter](ExpressionPowerTools.Serialization.Serializers.Parameter.cs.md)  - The serializable [Constant](ExpressionPowerTools.Serialization.Serializers.Constant.cs.md) .

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `expression` | [ParameterExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.parameterexpression) | The [ConstantExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.constantexpression) to serialize. |
| `state` | [SerializationState](ExpressionPowerTools.Serialization.Serializers.SerializationState.cs.md) | State, such as [JsonSerializerOptions](https://docs.microsoft.com/dotnet/api/system.text.json.jsonserializeroptions) , for the serialization. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
