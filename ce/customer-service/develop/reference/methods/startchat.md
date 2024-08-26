---
title: "startChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: "Includes reference information about startChat method, syntax, and parameters in Omnichannel for Customer Service JavaScript API reference."
ms.date: 11/07/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
---
# startChat

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[startchat-description](../includes/startchat-description.md)].

> [!NOTE]
> - Listen to the **lcw:ready** event raised by a live chat before calling the live chat SDK methods. The live chat methods should be invoked after the **lcw:ready** event is raised. You can listen for this event by adding your own event listener on the window object.
> - You don't need to use the `setContextProvider` method if you are using the `startChat` SDK API to pass the context. 

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.startChat({inNewWindow: inNewWindowValue,customContext: customContextObject});`

## Parameters

|Parameter|Type|Required|Description|
|----|----|----|----|
|`inNewWindow`|Boolean|No|Decides whether to open the chat in a new window.|
|`customContext`|Object|No|Set the custom context provider synchronously. If you've set a value in `setContextProvider`, it will be overridden by the value you've set for `customContext`.|

## Return value

None

## Example

```JavaScript
 Microsoft.Omnichannel.LiveChatWidget.SDK.startChat({
    inNewWindow: true,
   customContext: {
        'contextKey1': {'value': 'contextValue1', 'isDisplayable': true}
    }
});

```

### Related information

[setAuthTokenProvider](setAuthTokenProvider.md)<br />
[setContextProvider](setContextProvider.md)<br />
[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
