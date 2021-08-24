---
title: "sessionId property (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the sessionId property of the session for multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# sessionId

The ID of a given session.

## Syntax

`Microsoft.Apm.getSession(sessionId).focus();`

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.sessionId);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
