﻿# IRulesEngine.MemberIsAllowed Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Signatures](ExpressionPowerTools.Serialization.Signatures.n.md) > [IRulesEngine](ExpressionPowerTools.Serialization.Signatures.IRulesEngine.i.md) > **MemberIsAllowed**

Checks if a member is allowed.

## Overloads

| Overload | Description |
| :-- | :-- |
| [MemberIsAllowed(MemberInfo member)](#memberisallowedmemberinfo-member) | Checks if a member is allowed. |
## MemberIsAllowed(MemberInfo member)

Checks if a member is allowed.

```csharp
public virtual Boolean MemberIsAllowed(MemberInfo member)
```

### Return Type

 [Boolean](https://docs.microsoft.com/dotnet/api/system.boolean)  - A value indicating whether or not the member access is allowed.

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `member` | [MemberInfo](https://docs.microsoft.com/dotnet/api/system.reflection.memberinfo) | The [MemberInfo](https://docs.microsoft.com/dotnet/api/system.reflection.memberinfo) to check. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/10/2020 10:31:18 PM | (c) Copyright 2020 Jeremy Likness. | 0.8.7-alpha |