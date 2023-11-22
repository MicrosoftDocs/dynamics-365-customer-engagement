---
title: "sessionId property (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the sessionId property of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# sessionId (app profile manager)

The ID of a session.

## Syntax

`Microsoft.Apm.getSession(sessionId).focus();`

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.sessionId);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
