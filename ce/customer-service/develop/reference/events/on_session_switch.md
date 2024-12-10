---
title: ON_SESSION_SWITCH event (app profile manager) JavaScript API Reference
description: Learn about the ON_SESSION_SWITCH event of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 05/01/2024
ms.topic: reference
---

# ON_SESSION_SWITCH event (app profile manager)


This event is invoked by the client when a session is switched to another session. This event allows client-side handlers to react to session switches, updating the user interface or internal state as necessary. ON_SESSION_SWITCH event takes the following eventData:


| eventData            | Description  | 
|------------------|----------|
| previousSessionId           | The session ID of the previous session.  | 
| newSessionId           | The ID of the session that's now focused.  | 


## Example

```JavaScript

// Define a handler function that's triggered when the session is switched
let sessionSwitchedHandlerFunction = function(eventInput) {
    // Log the previous and new session IDs to the console
    console.log("Previous session:  " + eventInput.data.previousSessionId +
                " - Current session: " + eventInput.data.newSessionId);

}; 
// Retrieve the event topic specific to session switching from the API
let sessionSwitchTopic = Microsoft.Apm.getEventPublisherTopic("ON_SESSION_SWITCH");
// Create a new broadcast channel to subscribe to session switch events
let sessionSwitchSubscriber = new BroadcastChannel(sessionSwitchTopic);
// Attach the session switched handler function to the message event of the subscriber
sessionSwitchSubscriber.onmessage = sessionSwitchedHandlerFunction;

```

> [!NOTE]
> The code sample utilizes the [Broadcast Channel API - Web APIs](https://developer.mozilla.org/en-US/docs/Web/API/Broadcast_Channel_API), to communicate between different documents such as pages or iframes that are of the same origin. Make sure it is compatible with your customization as support for this API can vary.


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]

