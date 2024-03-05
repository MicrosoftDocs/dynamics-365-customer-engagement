---
title: "requestFocus method JavaScript API Reference | MicrosoftDocs"
description: "Learn about the requestFocus API in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# requestFocus

Shows a notification indicator on a session if the session is not in focus.

## Syntax

` Microsoft.Apm.getSession(sessionId).requestFocus();`

## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getSession("session-id-4").requestFocus();
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
