---
title: "getSession method JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getSession API in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# getSession

Returns the session object for a session ID.

## Syntax

`Microsoft.Apm.getSession(sessionId);`

## Parameters

| **Name        | **Type** | **Required** | **Description** |
|------------------|----------|--------------| --------------- |
| sessionID        | String   | Yes          | The session ID  |

## Return value

Session as an object.

## Example

```JavaScript
const sessionId = "session-id-1";
const session = Microsoft.Apm.getSession(sessionId);
if (!session.isDefault) {
    session.title = "new title";
}
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
