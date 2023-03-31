---
title: "startProactiveChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: Includes reference information about startProactiveChat method, syntax, and parameters in Omnichannel for Customer Service Session API reference."
ms.date: 01/25/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
---
# startProactiveChat

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[startproactivechat-description](../includes/startProactiveChat-description.md)] Organizations can use end-user data, user journey information, time spent on web page, and more to decide when to proactively engage customers through chat. Organizations can control the proactive chat experience using personalized trigger messages and configurable rules to define the target audience, time frame, and target location.

## Syntax

`Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(notificationUIConfig: notificationUIConfigObject, showPrechat, { inNewWindow: inNewWindowValue });`

## Parameters

| Parameter | Type | Required | Description |
| ---- | ---- | ---- | ---- |
|`notificationUIConfig`| Object | Yes | Allows you to pass UI configurations for proactive chat notification. This object lets you customize the notification, including the message to be displayed. |
|`showPrechat`| Boolean | No | Boolean flag to indicate whether prechat is shown if configured for the widget. The default value is `true`. |
|`inNewWindow`|Boolean|No|Decides whether to open the chat in a new window. This parameter resides within an options object.|

> [!IMPORTANT]
> If no message is provided in the `notificationUIConfig` object, then the default message, "Hi! Have any questions? I'm here to help" gets displayed.

## Return value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(    
                 {message: "Hi! How are you doing today? Do you wish to start a chat?"},
                    true,
                    {
                            inNewWindow: true
                    }
            );
});
```

### See also

[Live chat JavaScript API reference](../../omnichannel-reference.md)  
[Start a chat](../../../initiate-chat-wait-time.md)  
[Start a chat proactively](../../../start-proactive-chat.md)  

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
