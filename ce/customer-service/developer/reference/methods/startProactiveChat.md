---
title: "startProactiveChat (JavaScript API reference) for Omnichannel for Customer Service in Dynamics 365 | MicrosoftDocs"
description: 
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/12/2020
ms.topic: article
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
> If no message is provided in `notificationUIConfig` object, then the default message, that is, `Hi! Have any questions? I'm here to help` gets displayed.

## Return Value

None

## Example

```JavaScript
window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
               Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat(    
                    notificationUIConfig: {message: "Hi! How are you doing today? Do you wish to start a chat?"},
                    true,
                    {
                            inNewWindow: true
                    }
            );
});
```
## See also

[JavaScript API reference for live chat SDK](../../omnichannel-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]