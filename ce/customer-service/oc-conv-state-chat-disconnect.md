---
title: Understand disconnected chats
description: Use this article to know how Omnichannel for Customer Service handles customer disconnection during live chat.
ms.date: 01/23/2023
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
---

# Understand disconnected chats

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

During live chat, a customer can no longer chat with the agent if they leave the conversation or stay disconnected for more than three minutes. When a customer is disconnected for more than three minutes, Omnichannel for Customer Service detects the disconnection, and automatically updates the conversation state of the chat.

When an ongoing chat gets disconnected, Omnichannel for Customer Service: 

- Moves the chat from an **Open** to **Closed** state, so the agent knows that there's no customer to respond to.

- Moves the chat from an **Active** to **Wrap-up** state, and updates agent capacity, so the agent knows that the customer isn't available. You can configure agent capacity for the wrap-up state in the work distribution settings of the workstream. More information: [Wrap-up state](oc-conversation-state.md#wrap-up) and [Configure work distribution](create-workstreams.md#configure-work-distribution)

- Record an automated message in the transcript to indicate that the customer has disconnected. More information: [Configure automated messages](configure-automated-message.md#preconfigured-automated-message-triggers)

## What happens when a chat gets disconnected

Chat widgets are connected to browsers via a web socket connection. The connectivity can be lost for reasons like:

- The customer closed the browser but didn't close the chat widget at the end of the conversation.

- The customer navigated away from or closed the browser tab or app during the conversation. In some mobile devices, locking the screen or switching apps can also disconnect the chat.

- The customer lost internet connectivity, or had a network or system issue.

In such situations, if the customer returns to the chat within three minutes, then they can continue the conversation. 

If the customer reopens the chat widget after three minutes of disconnection, a new chat will begin. However, you can help your customers connect back to the previous chat by enabling reconnection. More information: [Configure reconnection to a previous chat session](configure-reconnect-chat.md)


>[!NOTE]
> A delay in sending messages doesn't affect your chat connection.



## Next steps

[Understand conversation states](oc-conversation-state.md)  
[Configure automatic closure of conversations](auto-close-conversation.md) 

### See also

[View communication panel](oc-conversation-control.md)  
 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
