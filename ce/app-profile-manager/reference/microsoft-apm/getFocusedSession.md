---
title: "getFocusedSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canCreateSession API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
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

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
