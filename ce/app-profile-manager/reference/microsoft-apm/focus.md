---
title: "focus method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the focus API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: focus (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Sets the focus on a session.

## Syntax

`Microsoft.Apm.getSession(sessionId).focus();`

## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getSession("session-id-4").focus();
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
