---
title: "lcw onMessageReceived | MicrosoftDocs"
description: lcw onMessageReceived  (Omnichannel for Customer Service JavaScript API reference)
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.topic: article
ms.reviewer: nenellim
ms.service: dynamics-365-customerservice
---
# lcw:onMessageReceived  (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

This event is triggered when a new message is received by the chat widget. You can use this event to create custom experiences when a new message comes in for the user. For example, playing a sound notification or updating the page title to catch the user’s eye. 

The message can either be sent by a user (for example, an agent in Dynamics) or the system (for example, an automated message). This event will contain data in the payload to explain the source of the message. 

## Sample payload

```JSON
{ 

detail: { 

messageType: "user" 

} 

} 
```

## Example

```javascript
window.addEventListener("lcw:onMessageReceived", function handleWidgetMessageReceivedEvent(){ // Handle the live chat widget message sent event }); 
```

### See also

[lcw:onMessageSent](lcw-onmessagesent.md)<br />
[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)
