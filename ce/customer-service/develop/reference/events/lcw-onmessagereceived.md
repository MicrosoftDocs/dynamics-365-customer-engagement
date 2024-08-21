---
title: lcw:onMessageReceived 
description: lcw onMessageReceived event (Omnichannel for Customer Service JavaScript API reference).
ms.date: 05/15/2024
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
ms.custom: bap-template

---
# lcw:onMessageReceived event (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

The `lcw:onMessageReceived` event is triggered when the chat widget gets a new message. You can use this event to create custom experiences for the user. For example, play a sound notification or update the page title to catch the user eye for the new message.

Users such as an agent in Dynamics 365 can send the message or the system can send an automated message. So, the possible values for `messageType` are user and system.

This event contains data in the payload to explain the source of the message.

## Sample payload

**Agent assigned**

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
**Agent assignment accepted**

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

### Related information
[lcw:ready](lcw-ready.md)  
[lcw:error](lcw-error.md)  
[lcw:chatRetrieved](lcw-chatRetrieved.md)  
[lcw:chatQueued](lcw-chatQueued.md)  
[lcw:onClose](lcw-onclose.md)  
[lcw:closeChat](lcw-closechat.md)  
[lcw:startChat](lcw-startchat.md)   
[lcw:onMinimize](lcw-onminimize.md)  
[lcw:onMaximize](lcw-onmaximize.md)  
[lcw:onMessageSent](lcw-onmessagesent.md)  
[lcw:threadUpdate](lcw-threadUpdate.md)   
[`Live chat SDK JavaScript API reference`](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
