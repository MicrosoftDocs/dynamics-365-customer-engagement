---
title: "Configure reconnection to a chat session | MicrosoftDocs"
description: "Administrator steps for configuring reconnect chat in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Configure reconnection to a previous chat session

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

When customers are disconnected in the middle of a conversation&mdash;for reasons that can range from restarting their system while troubleshooting to network disruption&mdash;they can reconnect to the same agent, if you've enabled the settings for reconnection. The options to reconnect to the same agent helps save time and effort, and improves customer satisfaction.

## How reconnection to a previous chat works

When enabled, reconnection to the disconnected chat session can be initiated by using one of the following options:

- **Reconnect with a link**<br>
You can configure link information as a quick response for agents. If the agent anticipates that there will likely be a need to reconnect during a conversation, the agent shares the reconnection link with the customer. This option is available for both authenticated and unauthenticated chat widget settings.

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

1. In the Omnichannel Administration app, go to **Channels** > **Chat**.

2. On the page that appears, do one of the following:

   - Select **New** on the toolbar to create a chat widget.
   - In the **Active Chat Widgets** list, select the chat widget for which you want to enable reconnection option.

3. On the ***<widget_name>* Chat Widget** page, in the **Chat Reconnect** area, set the toggle to **Yes**. The following options are displayed:
   - **Reconnect time limit:** The value of the **Auto-close after inactivity** field in the work stream associated with the chat widget.
   - **Reconnect to previous agent for:** Select a value to indicate the time within which the customer can connect back to the same agent. This value should be less than or equal to the value specified in the **Reconnect time limit** box. The agent's capacity is blocked for the specified duration unless the agent closes the conversation by using the **Close** button, which releases the agent's capacity.
   - **Portal URL:** Specify the link that will be shared by the agent with the customer to reconnect to the chat session. This must be the portal link on which the chat widget is displayed.
   - **Redirection URL:** Optionally, specify the link that the customer will be redirected to when the reconnect timeout occurs. If this is left blank, the customer will see the option to start a new chat conversation.

    > [!div class=mx-imgBorder]
    > ![Configure reconnection to a previous chat session](media/reconnect-chat.png "Configure reconnection to a previous chat session")

4. Select **Save**.

### See also

[Add a chat widget](add-chat-widget.md)  
[Create a work stream](work-streams-introduction.md)  
[Slug for reconnection link](../app-profile-manager/automation-dictionary-keys.md#slug-for-reconnection-link)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]