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

The message can either be sent by a user (for example, an agent in Dynamics) or the system (for example, an automated message), so the possible values for messageType are "user" and "system". This event will contain data in the payload to explain the source of the message. 

## Sample payload

**Agent assignment**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "agentassignmentready"
],

},
"messageType": "system"

} 
```

**Agent accepted**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "agentaccepted"
],

},
"messageType": "system"

} 
```

**Agent sent a message**

```JSON
{ 

"channelData": { 

"tags": [
    "public",
    "client_activity_id:1612311164266bkaspzvq05b"
],

},
"messageType": "user"

} 
```

**Agent ended the conversation**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "agentendconversation"
],

},
"messageType": "system"

} 
```

**Agent ended the session**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "primarysessionclosed"
],

},
"messageType": "system"

} 
```

**Agent assignment failed**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "agentassignmentfailure"
],

},
"messageType": "system"

} 
```

**Queue position**

```JSON
{ 

"channelData": { 

"tags": [
    "system",
    "queueposition",
    "customerqueuepositionnext"
],

},
"messageType": "system"

} 
```

## Example

```javascript
window.addEventListener("lcw:onMessageReceived", function handleWidgetMessageReceivedEvent(payload){ // Handle the live chat widget message sent event });
```

### See also

[lcw:onMessageSent](lcw-onmessagesent.md)<br />
[lcw:ready](lcw-ready.md)<br />
[lcw:error](lcw-error.md)<br />
[Live chat SDK JavaScript API reference](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]