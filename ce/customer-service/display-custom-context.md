---
title: "Display custom context | Microsoft Docs"
description: "Read how you can send display custom context on the UI"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/29/2019
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Display custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To display the context variables in the Conversation Summary Control for a conversation on the UI, make sure that you include `isDisplayable` attribute in the body of [setContextProvider](developer/reference/methods/setContextProvider.md) method and set its value to `true`. If the value of `isDisplayable` attribute is set to `true`, the context variables will appear as shown below.

![Display context keys](media/context-variable-display.png "Display context keys")

For more information, see [setContextProvider method](developer/reference/methods/setContextProvider.md) and [Conversation summary](oc-customer-summary.md#conversation-summary).

### See also

[Manage custom context](send-context-starting-chat.md)<br />
[setContextProvider](developer/reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]