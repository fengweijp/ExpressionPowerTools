﻿# IQueryDeserializer Interface

[Index](../index.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore](ExpressionPowerTools.Serialization.EFCore.AspNetCore.a.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures.n.md) > **IQueryDeserializer**

Deserializes the query.

```csharp
public interface IQueryDeserializer
```

Derived  [QueryDeserializer](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.QueryDeserializer.cs.md) 

## Methods

| Method | Description |
| :-- | :-- |
| [Task&lt;QueryResult> DeserializeAsync(IQueryable template, Stream json, ILogger logger)](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures.IQueryDeserializer.DeserializeAsync.m.md) | Performs the deserialization. |

---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
