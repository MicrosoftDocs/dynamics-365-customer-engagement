---
title: "Display custom context | Microsoft Docs"
description: "Read how you can send display custom context on the UI"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: reference
---
# Display custom context

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

To display the context variables in the Conversation Summary Control for a conversation on the UI, make sure that you include `isDisplayable` attribute in the body of [setContextProvider](../reference/methods/setContextProvider.md) method and set its value to `true`. If the value of `isDisplayable` attribute is set to `true`, the context variables will appear as shown below.

![Display context keys](../../media/context-variable-display.png "Display context keys")

For more information, see [setContextProvider method](../reference/methods/setContextProvider.md) and [Conversation summary](../../agent/agent-oc/oc-customer-summary.md#conversation-summary).

### See also

[Manage custom context](send-context-starting-chat.md)<br />
[setContextProvider](../reference/methods/setContextProvider.md)
