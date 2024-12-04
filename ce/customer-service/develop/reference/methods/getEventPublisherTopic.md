---
title:  getEventPublisherTopic (app profile manager)
description: Learn about the  getEventPublisherTopic method of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 05/01/2024
ms.topic: reference
---

# getEventPublisherTopic (app profile manager)


Returns a unique topic name for a given event in multisession.
 

## Syntax

let topic = `Microsoft.Apm.getEventPublisherTopic(eventName);`


## Parameters

| **Name**        | **Type** | **Required** |
|-----------------|----------|--------------|
| eventName | string | Yes           |  

## Return value

A string that represents the unique topic name for the specified event in the current Customer Service workspace session.

## Example

```javascript
// Retrieving the event topic for the "ON_SESSION_CLOSED" event
const sessionCloseTopic = Microsoft.Apm.getEventPublisherTopic("ON_SESSION_CLOSED");

// Output example 
console.log(sessionCloseTopic);
```

> [!NOTE]
> This method is only supported with [ON_SESSION_SWITCH](../events/on_session_switch.md) and [ON_SESSION_CLOSED](../events/on_session_closed.md) events.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]