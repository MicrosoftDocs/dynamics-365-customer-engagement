---
title: "getSession (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the getSession API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getSession

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
