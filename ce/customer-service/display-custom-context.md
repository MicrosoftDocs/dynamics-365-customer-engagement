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

To display the context variables in the Conversation Summary Control of conversations, make sure that you include the `isDisplayable` attribute in the body of [setContextProvider](developer/reference/methods/setContextProvider.md) method, and then set its value to `true`.

If the value of `isDisplayable` attribute is set to `true`, then the context variables will appear as follows:

![Display context keys.](media/context-variable-display.png "Display context keys")

More information: [Conversation summary](oc-customer-summary.md#conversation-summary)

### See also

[Manage custom context](send-context-starting-chat.md)<br />
[setContextProvider](developer/reference/methods/setContextProvider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
