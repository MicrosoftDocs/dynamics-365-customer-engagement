---
title: ON_SESSION_CLOSED event (app profile manager) JavaScript API Reference
description: Learn about the ON_SESSION_CLOSED event of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 05/01/2024
ms.topic: reference
---

# ON_SESSION_CLOSED event (app profile manager)


This event is invoked by the client when a session is closed. This event provides an opportunity to perform clean-up tasks or update the application state in response to session closure. ON_SESSION_CLOSED event takes the following eventData:
 


| eventData            | Description  | 
|------------------|----------|
|sessionId         | The session ID of session that was close.  | 



## Example


```JavaScript

// Define a handler function that's triggered when a session is closed
let sessionClosedHandlerFunction = function(eventInput) {
    // Log the ID of the closed session to the console
    console.log("Session closed: " + eventInput.data.sessionId);
};
// Retrieve the event topic specific to session closing from the API
let sessionCloseTopic = Microsoft.Apm.getEventPublisherTopic("ON_SESSION_CLOSED");
// Create a new broadcast channel to subscribe to session close events
let sessionCloseSubscriber = new BroadcastChannel(sessionCloseTopic);
// Attach the session closed handler function to the message event of the subscriber
sessionCloseSubscriber.onmessage = sessionClosedHandlerFunction;

```

> [!NOTE]
> The code sample utilizes the [Broadcast Channel API - Web APIs](https://developer.mozilla.org/en-US/docs/Web/API/Broadcast_Channel_API), to communicate between different documents such as pages or iframes that are of the same origin. Make sure it is compatible with your customization as support for this API can vary.


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]