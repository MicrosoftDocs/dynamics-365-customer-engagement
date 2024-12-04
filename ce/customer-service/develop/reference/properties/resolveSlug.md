---
title: resolveSlug method (app profile manager) JavaScript API Reference
description: Learn about the resolveSlug API of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 04/02/2024
ms.topic: reference
---

# resolveSlug (app profile manager)


Allows you to get the value of a session context variable.

## Syntax

`Microsoft.Apm.getFocusedSession().resolveSlug(input);`

## Parameters

| Name             | Type     | Required | Description |
|------------------|----------|----------|---------------------------------------------|
| input            | String  | Yes | Session context variable to be retrieved. |


## Return value

String.

## Example

These examples use the 'resolveSlug' method to retrieve the value of a session context variable.


**Entity session template**

Retrieves the value from a variable in an entity session.

```JavaScript
var caseTitle = Microsoft.Apm.getFocusedSession().resolveSlug("{anchor.title}")
```

**Generic session template**

Retrieves the value from a variable in a generic session.

 ```JavaScript
var customerName = Microsoft.Apm.getFocusedSession().resolveSlug("{customerName}")
```
> [!NOTE]
> Make sure that you include the variable between brackets {}.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]

