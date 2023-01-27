---
title: "Configure reconnection to a chat session | MicrosoftDocs"
description: "Learn about configuring reconnections to previous chat sessions in Omnichannel for Customer Service."
ms.date: 01/23/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure reconnection to a previous chat session

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]


When customers are disconnected in the middle of a conversation&mdash;for reasons that can range from restarting their system while troubleshooting to network disruption&mdash;they can reconnect to the same agent, if you've enabled the settings for reconnection. The options to reconnect to the same agent help save time and effort, and improve customer satisfaction.

## How reconnection to a previous chat works

When enabled, reconnection to the disconnected chat session can be initiated by using one of the following options:

- **Reconnect with a link**<br>
You can configure link information as a quick response for agents. If the agent anticipates that there will likely be a need to reconnect during a conversation, the agent shares the reconnection link with the customer. This option is available for both authenticated and unauthenticated chat widget settings. To configure the link, see [Slug for reconnection link](../app-profile-manager/automation-dictionary-keys.md#slug-for-reconnection-link).

- **Reconnect through a prompt**<br>
Customers interacting through chat widgets that have authentication settings configured are presented with the option to continue with the previous session or start a new conversation when they come back to the chat session.

Additionally, you can cater to the timeout scenario by setting the following option:

- **Redirection link**<br>
You can optionally configure a redirection link for the customer to navigate to when they come back after a timeout period that is configured in the reconnection settings. If no redirection link is configured, a fresh conversation will start when the customer selects the reconnect link.

> [!IMPORTANT]
>
> The reconnection feature works as designed only when the following prerequisites are met for the conversation:
>
> - The customer connected again within the reconnection time that's configured for the feature.
> - The agent didn't end the session by using the **End** button.
> - The customer didn't end the session by closing the chat window.
> - If the agent closed the chat window, the customer might not be reconnected to the same agent.

## Enable reconnection to a previous chat session

You can enable the reconnection options in the chat widget either while setting up the chat widget for the first time, or later, based on your needs.

**To enable reconnection to a previous chat session**

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     - In the site map, select **Workstreams** in **General settings**.

1. On the **Workstreams** page, select the workstream.

1. Select the chat widget for which you want to enable the reconnection option.

1. On the ***<widget_name>* Chat Widget** page, in the **Chat widget** area, select **Edit**.

1. On the Chat channel settings dialog, go to the **Chat widget** tab and set the **Reconnect to previous chat** toggle to **Yes**. The following options are displayed:
   - **Time limit**: Select a value to indicate the time within which the customer can connect back to the same agent. The agent's capacity is blocked for the specified duration unless the agent closes the session. If the customer fails to reconnect within the duration the conversation moves to the **Wrap-up** state.
   - **Portal URL**: Specify the link that will be shared by the agent with the customer to reconnect to the chat session. This must be the portal link on which the chat widget is displayed.
   - **Redirect URL**: Optionally, specify the link that the customer will be redirected to when the reconnect timeout occurs. If this is left blank, the customer will see the option to start a new chat conversation.

1. Select **Save and Close**.
     
   :::image type="content" source="media/reconnect-previous-chat.png" alt-text="Reconnect to previous chat":::
    

### See also

[Add a chat widget](add-chat-widget.md)  
[Create a work stream](work-streams-introduction.md)  
[Slug for reconnection link](../app-profile-manager/automation-dictionary-keys.md#slug-for-reconnection-link)  
[Understand conversation states](oc-conversation-state.md)    
[Understand disconnected chats](oc-conv-state-chat-disconnect.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
