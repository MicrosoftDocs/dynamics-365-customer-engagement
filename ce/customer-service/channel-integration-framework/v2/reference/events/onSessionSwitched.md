---
title: "onSessionSwitched event (JavaScript API Reference) for Dynamics 365 Channel Integration Framework (CIF) version 2.0 | Microsoft Docs"
description: ""
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 03/20/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# onSessionSwitched event (CIF JavaScript API reference)

Invoked by the client when a session is switched.

## eventData

The `onSessionSwitched` event takes following eventData:

| eventData | Description |
|-----------|---------|
| `sessionId` | Unique identifier of the session. |
| `focussed` | Indicates whether the session is in focus or not.<br />If the value is `true` it indicates that the session id returned in the payload is in focus and value `false` indicates that the particular session is not in focus.|
| `context`| Indicates additional context. |

## See also

[setClickToAct](../microsoft-ciframework/setClickToAct.md)<br />
[addHandler](../microsoft-ciframework/addHandler.md)<br />
[removeHandler](../microsoft-ciframework/removeHandler.md)


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]