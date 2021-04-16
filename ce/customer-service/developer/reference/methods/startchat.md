---
title: "startChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: 
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 07/08/2020
ms.topic: article
---
# startChat

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[startchat-description](../includes/startChat-description.md)]

> [!NOTE]
> Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.startChat({inNewWindow: inNewWindowValue});`

## Parameters

|Parameter|Type|Required|Description|
|----|----|----|----|
|`inNewWindow`|Boolean|No|Decides whether to open the chat in a new window.|

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Opens an existing chat, if any. Else initiates a new chat
               Microsoft.Omnichannel.LiveChatWidget.SDK.startChat({inNewWindow: true});
});
```
## See also

[setAuthTokenProvider](setAuthTokenProvider.md)<br />
[setContextProvider](setContextProvider.md)<br />
[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]