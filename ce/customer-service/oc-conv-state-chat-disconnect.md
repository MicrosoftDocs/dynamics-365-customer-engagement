---
title: Detect chat disconnection
description: Use this article to learn chat disconnection in Omnichannel for Customer Service.
ms.date: 01/23/2023
ms.topic: conceptual
author: mh-jaya
ms.author: v-jmh
ms.custom: bap-template
---

# Detect chat disconnect

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

When a customer gets disconnected from live chat for a duration of more than 3 minutes, Omnichannel for Customer Service detects the disconnection and automatically updates the state of the chat conversation. Customers can get disconnected from the chat for various reasons like navigation to a different tab or window, accidental closure of the chat browser or tab, or other network or system issues.

When the customer disconnects, Omnichannel for Customer Service will: 

- Move chats from an **Open** state to **Closed**. This ensures that the agent doesn't accept an incoming chat, when there's no customer to respond.

- Move chats in an **Active** state to **Wrap-up** state. This indicates to the agent the customer is no longer present, and it speeds up the freeing of capacity to help additional customers. Note: wrap-up capacity is controlled by settings in your organization - Understand conversation states | Microsoft Docs 

- Record an automated message in the transcript to indicate that the customer has disconnected. More information: [Configure automated messages]()

## How chat widget connections work

Connections to the chat widget are maintained via a web socket connection. Connectivity to the chat widget can be lost for multiple reasons like:

- The customer closed the browser but didn't close the chat widget while having the conversation with the agent.

- The customer navigated away from or closed the browser tab or app where the conversation was ongoing. In some mobile devices, this could include locking the screen or switching apps away from the chat. 

- The customer's internet connectivity was lost, or the customer had some network or system issue.

However, if customer returns to the chat widget within three minutes of one of these actions, they can continue the conversation. The customer will get disconnected only if they leave the conversation or stay disconnected for more than three minutes. 

>[!NOTE]
> - A delay in sending messages doesn't impact your chat connection.
> - You can also choose to allow customers to reconnect back to an older chat by configuring reconnection. More information: [Configure reconnection to a chat session]()

## Next steps

[Understand conversation states](oc-conversation-state.md)  

### See also

[View communication panel](oc-conversation-control.md)  
[Configure automatic closure of conversations](auto-close-conversation.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
