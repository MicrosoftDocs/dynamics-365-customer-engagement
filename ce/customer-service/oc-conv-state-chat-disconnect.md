---
title: Understand disconnected chats
description: Use this article to know how Omnichannel for Customer Service handles customer disconnection during live chat.
ms.date: 01/23/2023
ms.topic: conceptual
author: mh-jaya
ms.author: v-jmh
ms.custom: bap-template
---

# Understand disconnected chats

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

During live chat, a customer will get disconnected if they leave the conversation or stay disconnected for more than three minutes. When a customer is disconnected from the chat for more than three minutes, Omnichannel for Customer Service will detect the disconnection and automatically update the conversation state of the chat.

When the chat is disconnected, Omnichannel for Customer Service will: 

- Move chats from an **Open** to **Closed** state. This ensures that the agent doesn't accept an incoming chat, when there's no customer to respond.

- Move chats that are in an **Active** state to **Wrap-up** state. This indicates to the agent that the customer is no longer present and updates the agent capacity. Note that wrap-up capacity is controlled by settings in your organization. More information: [Wrap-up state](oc-conversation-state.md#wrap-up) 

- Record an automated message in the transcript to indicate that the customer has disconnected. More information: [Configure automated messages](configure-automated-message.md#preconfigured-automated-message-triggers)

## How chat widget connections work

Connections to the chat widget are maintained via a web socket connection. Connectivity to the chat widget can be lost for multiple reasons like:

- The customer closed the browser but didn't close the chat widget at the end of the conversation.

- The customer navigated away from or closed the browser tab or app during the conversation. In some mobile devices, locking the screen or switching apps can also cause disconnect the chat.

- The customer's internet connectivity was lost, or the customer had some network or system issue.

If the customer returns to the same chat widget within three minutes of one of the listed reasons, then they can continue the conversation. But, if the customer stays disconnected for more than 3 minutes, and then reopens the chat widget, a completely new chat will begin.  


>[!NOTE]
> - A delay in sending messages doesn't impact your chat connection.
> - You can also choose to allow customers to reconnect back to an older chat by configuring reconnection. More information: [Configure reconnection to a previous chat session](configure-reconnect-chat.md)


## Next steps

[Understand conversation states](oc-conversation-state.md)  

### See also

[View communication panel](oc-conversation-control.md)  
[Configure automatic closure of conversations](auto-close-conversation.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
