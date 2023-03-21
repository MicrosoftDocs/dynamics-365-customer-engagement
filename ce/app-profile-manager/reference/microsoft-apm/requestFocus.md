---
title: "requestFocus method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the requestFocus API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/01/2021
ms.topic: reference
---

# requestFocus (app profile manager)

Shows a notification indicator on a session if the session is not in focus.

## Syntax

` Microsoft.Apm.getSession(sessionId).requestFocus();`

## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getSession("session-id-4").requestFocus();
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
