---
title: getSession method (app profile manager) JavaScript API Reference 
description: Learn about the getSession API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getSession (app profile manager)

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
