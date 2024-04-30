---
title: ON_SESSION_SWITCH event (app profile manager) JavaScript API Reference
description: Learn about the ON_SESSION_SWITCH event of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.date: 04/23/2024
ms.topic: reference
---

# ON_SESSION_SWITCH event (app profile manager)


This event is invoked by the client when a session is switched to another session. This event allows client-side handlers to react to session switches, updating the user interface or internal state as necessary. ON_SESSION_SWITCH event takes the following eventData:


| eventData            | Description  | 
|------------------|----------|
| previousSessionId           | The session ID of the previous session.  | 
| newSessionId           | The ID of the session that is now focused.  | 


## Example

```JavaScript

let sessionSwitchedhandlerFunction = function(eventInput)
{
console.log("SessionSwitched: previousSession -" + eventInput.data.previousSessionId + " newSession -" + eventInput.data.newSessionId);
}

let sessionSwitchTopic = Microsoft.Apm.getEventPublisherTopic("ON_SESSION_SWITCH");

let sessionSwitchSubscriber = new BroadcastChannel(sessionSwitchTopic);

sessionSwitchSubscriber.onmessage = sessionSwitchedhandlerFunction;

```



[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]

