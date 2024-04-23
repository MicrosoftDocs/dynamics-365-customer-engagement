---
title: ON_SESSION_CLOSED event (app profile manager) JavaScript API Reference
description: Learn about the ON_SESSION_SWITCH event of app profile manager in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.date: 04/23/2024
ms.topic: reference
---

# ON_SESSION_CLOSED event (app profile manager)


This event is invoked when the client when a session is closed. This event provides an opportunity to perform clean-up tasks or update the application state in response to session closure. ON_SESSION_CLOSED event takes the following eventData:
 


| eventData            | Description  | 
|------------------|----------|
|sessionId         | The session ID of session that was close.  | 



## Example


```JavaScript

let sessionClosedhandlerFunction = function(eventInput)
{
console.log("SessionClosed: closedSession -" + eventInput.data.sessionId);
}

let sessionCloseSubscriber = new BroadcastChannel(sessionCloseTopic);
let sessionCloseTopic = Microsoft.Apm.getEventPublisherTopic("ON_SESSION_CLOSED");

sessionCloseSubscriber.onmessage = sessionClosedhandlerFunction;


```



[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]