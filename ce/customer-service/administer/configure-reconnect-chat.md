---
title: Configure reconnection to a chat session
description: Learn about configuring reconnection to previous chat sessions in Omnichannel for Customer Service.
ms.date: 02/05/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure reconnection to a previous chat session

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


When customers are disconnected in the middle of a conversation&mdash;for reasons that can range from restarting their system while troubleshooting to network disruption&mdash;they can reconnect to the same customer service representative (service representative or representative), if you enabled the settings for reconnection. The options to reconnect to the same service representative help save time and effort, and improve customer satisfaction.

## How reconnection to a previous chat works

When enabled, reconnection to the disconnected chat session can be initiated by using one of the following options:

- **Reconnect with a link**<br>
You can configure link information as a quick response for service representatives. If the representatives anticipate that there is likely to be a need to reconnect during a conversation, they share the reconnection link with the customer. This option is available for both authenticated and unauthenticated chat widget settings. To configure the link, see [Slug for reconnection link](automation-dictionary-keys.md#slug-for-reconnection-link).

- **Reconnect through a prompt**<br>
Customers interacting through chat widgets that have authentication settings configured are presented with the option to continue with the previous session or start a new conversation when they come back to the chat session.

Additionally, you can cater to the timeout scenario by setting the following option:

- **Redirection link**<br>
You can optionally configure a redirection link for the customer to navigate to when they come back after a timeout period that is configured in the reconnection settings. If no redirection link is configured, a fresh conversation starts when the customer selects the reconnect link.

> [!IMPORTANT]
>
> The reconnection feature works as designed only when the following prerequisites are met for the conversation:
>
> - The customer connected again within the reconnection time configured for the feature.
> - The representative didn't end the session by using the **End** button.
> - The customer didn't end the session by closing the chat window.
> - If the representative closed the chat window, the customer might not be reconnected to the same representative.

## Enable reconnection to a previous chat session

You can enable the reconnection options in the chat widget either while setting up the chat widget for the first time, or later, based on your needs.

1. In the site map of Customer Service admin center, select **Workstreams** in **Customer support**.

1. On the **Workstreams** page, select the workstream.

1. Select the chat widget for which you want to enable the reconnection option.

1. On the ***<widget_name>* Chat Widget** page, in the **Chat widget** area, select **Edit**.

1. On the Chat channel settings dialog, go to the **Chat widget** tab and set the **Reconnect to previous chat** toggle to **Yes**. The following options are displayed:
   - **Time limit**: Select a value to indicate the time within which the customer can connect back to the same service representative. The representative's capacity is blocked for the specified duration unless the session is closed. If the customer fails to reconnect within the duration, the conversation moves to the **Wrap-up** state.
   - **Portal URL**: Specify the portal link that the representative can share with the customer to reconnect to the chat session.
   - **Redirect URL**: Optionally, specify the link that the customer can be redirected to when the reconnection timeout occurs. If the field is left blank, the customer sees the option to start a new chat conversation.

1. Select **Save and Close**.
     
   :::image type="content" source="../media/reconnect-previous-chat.png" alt-text="Reconnect to previous chat":::
    

### Related information

[Add a chat widget](add-chat-widget.md)  
[Create a work stream](../work-streams-introduction.md)  
[Slug for reconnection link](automation-dictionary-keys.md#slug-for-reconnection-link)  
[Understand conversation states](../use/oc-conversation-state.md)    
[Understand disconnected chats](../use/oc-conv-state-chat-disconnect.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
