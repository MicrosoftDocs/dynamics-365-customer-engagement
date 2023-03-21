---
title: "startChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes reference information about startChat method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
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

## Return value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               // Opens an existing chat, if any. Else initiates a new chat
               Microsoft.Omnichannel.LiveChatWidget.SDK.startChat({inNewWindow: true});
});
```

### See also

[setAuthTokenProvider](setAuthTokenProvider.md)<br />
[setContextProvider](setContextProvider.md)<br />
[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
