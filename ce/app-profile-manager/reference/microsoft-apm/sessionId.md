---
title: "sessionId property (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager sessionId property of sessions in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

#  (app profile manager)
The ID of a given session.

## Syntax

`Microsoft.Apm.getSession(sessionId).focus();`

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.sessionId);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
