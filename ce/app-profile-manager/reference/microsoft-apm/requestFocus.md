---
title: "requestFocus method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the requestFocus API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: requestFocus (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

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
