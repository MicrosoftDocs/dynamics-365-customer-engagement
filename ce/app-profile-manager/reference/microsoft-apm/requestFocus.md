---
title: "requestFocus method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager requestFocus API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: requestFocus (app profile manager)

Shows a notification indicator on a given session if the session is not focused.

## Syntax

` Microsoft.Apm.getSession(sessionId).requestFocus();`

## Return value

None
## Example

```JavaScript
Microsoft.Apm.getSession("session-id-4").requestFocus();
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
