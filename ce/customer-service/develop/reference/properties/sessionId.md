---
title: "sessionId property JavaScript API Reference | MicrosoftDocs"
description: "Learn about the sessionId property in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# sessionId

The ID of a session.

## Syntax

`Microsoft.Apm.getSession(sessionId).focus();`

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.sessionId);
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
