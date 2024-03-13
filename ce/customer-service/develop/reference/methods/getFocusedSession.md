---
title: "getFocusedSession method JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getFocusedSession API in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# getFocusedSession

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

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
