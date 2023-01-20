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

During live chat, a customer can no longer chat with the agent if they leave the conversation or stay disconnected for more than three minutes. When a customer is disconnected for more than three minutes, Omnichannel for Customer Service detects the disconnection, and automatically updates the conversation state of the chat.

When the chat is disconnected, Omnichannel for Customer Service will: 

- Move chats from an **Open** to **Closed** state. This ensures that the agent doesn't accept an incoming chat, when there's no customer to respond.

- Move chats from an **Active** to **Wrap-up** state, and update agent capacity. This indicates to the agent that the customer isn't available. As an administrator, you can configure the wrap-up capacity. More information: [Wrap-up state](oc-conversation-state.md#wrap-up). To programmatically configure automatic closure of conversations, see [Configure automatic closure of Wrap-up state for live chat](auto-close-conversation.md#configure-automatic-closure-of-wrap-up-state-for-live-chat).

- Record an automated message in the transcript to indicate that the customer has disconnected. More information: [Configure automated messages](configure-automated-message.md#preconfigured-automated-message-triggers)

## How chat widget connections work

Chat widgets are connected to browsers via a web socket connection. The connectivity can be lost for reasons like:

- The customer closed the browser but didn't close the chat widget at the end of the conversation.

- The customer navigated away from or closed the browser tab or app during the conversation. In some mobile devices, locking the screen or switching apps can also disconnect the chat.

- The customer lost internet connectivity, or had a network or system issue.

During these situations, if the customer returns to the chat widget within three minutes of any of the preceding reasons, then they can continue the conversation. 

If the customer stays disconnected for more than three minutes and then reopens the chat widget, a new chat will begin. However, as an administrator, you can help your customers connect back to the previous chat by enabling reconnection. More information: [Configure reconnection to a previous chat session](configure-reconnect-chat.md)


>[!NOTE]
> A delay in sending messages doesn't affect your chat connection.



## Next steps

[Understand conversation states](oc-conversation-state.md)  
[Configure automatic closure of conversations](auto-close-conversation.md) 

### See also

[View communication panel](oc-conversation-control.md)  
 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
