---
title: ON_TAB_SWITCH event JavaScript API Reference
description: Learn about the ON_TAB_SWITCH event in Copilot Service workspace.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 03/21/2025
ms.topic: reference
---

# ON_TAB_SWITCH event


This event is invoked by the client when a tab is switched to another tab. This event allows client-side handlers to react to tab switches, updating the user interface or internal state as necessary. ON_TAB_SWITCH event takes the following eventData.


| eventData            | Description  | 
|------------------|----------|
| previousSessionId           | The session ID of the previous tab.  |
| previousTabId           | The tab ID of the previous tab.   | 
| SessionId           | The session ID of the tab that's now focused.  | 
| tabId               | The ID of the tab that's now focused.  |   


## Example

```JavaScript

// Define a handler function that's triggered when the tab is switched
let tabSwitchedHandlerFunction = function(eventInput) {
    // Log the previous and new session IDs and tabs IDs to the console
    console.log("Previous session:  " + eventInput.data.previousSessionId + 
                " Previous tab: " + eventInput.data.previousTabId +
                " Current session: " + eventInput.data.sessionId + 
                " Previous tab: " + eventInput.data.tabId );

}; 

// Retrieve the event topic specific to tab switching from the API
let tabSwitchTopic = Microsoft.Apm.getEventPublisherTopic("ON_TAB_SWITCH");
// Create a new broadcast channel to subscribe to tab switch events
let tabSwitchSubscriber = new BroadcastChannel(tabSwitchTopic);
// Attach the tab switched handler function to the message event of the subscriber
tabSwitchSubscriber.onmessage = tabSwitchedHandlerFunction; 

```

> [!NOTE]
> The code sample uses the [Broadcast Channel API - Web APIs](https://developer.mozilla.org/en-US/docs/Web/API/Broadcast_Channel_API) to communicate between different documents such as pages or iframes that are of the same origin. Make sure it's compatible with your customization as support for this API can vary.


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]