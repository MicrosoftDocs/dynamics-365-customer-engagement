---
title: "getSession method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canCreateSession API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getSession (app profile manager)

Returns the session object for a given session ID.

## Syntax

`Microsoft.Apm.getSession(sessionId);`

## Parameters

| **Name**         | **Type** | **Required** | **Description** |
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

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
