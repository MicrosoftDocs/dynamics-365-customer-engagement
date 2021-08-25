---
title: "getFocusedSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getFocusedSession API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: getFocusedSession (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

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
