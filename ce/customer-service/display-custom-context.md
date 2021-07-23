---
title: "Display custom context | MicrosoftDocs"
description: "Use this topic to understand how to display custom context in the Conversation summary section of conversations."
ms.date: 08/29/2019
ms.topic: reference
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---
# Display custom context

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To display the context variables in the Conversation Summary Control for a conversation on the UI, make sure that you include `isDisplayable` attribute in the body of [setContextProvider](developer/reference/methods/setContextProvider.md) method and set its value to `true`. If the value of `isDisplayable` attribute is set to `true`, the context variables will appear as shown below.

![Display context keys.](media/context-variable-display.png "Display context keys")

For more information, see [setContextProvider method](developer/reference/methods/setContextProvider.md) and [Conversation summary](oc-customer-summary.md#conversation-summary).

### See also

[Manage custom context](send-context-starting-chat.md)<br />
[setContextProvider](developer/reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
