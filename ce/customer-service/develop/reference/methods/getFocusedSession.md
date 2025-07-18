---
title: getFocusedSession method (app profile manager) JavaScript API Reference 
description: Learn about the getFocusedSession API of app profile manager in Copilot Service workspace.
ms.topic: reference
ms.date: 06/17/2025
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getFocusedSession (app profile manager)

Returns the session object of the session that is in focus.

## Syntax

`Microsoft.Apm.getFocusedSession();`

## Return value

Session as an object.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.sessionId);
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
