---
title: "Configure reconnection to a chat session | MicrosoftDocs"
description: "Administrator steps for configuring reconnect chat in Omnichannel for Customer Service."
ms.date: 05/01/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure reconnection to a previous chat session

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

When customers get disconnected in the middle of a conversation with agents on account of network disruption or any other reason, allowing them to reconnect to the same agent helps save time and effort and improve customer satisfaction. Administrators can provide agents with the ability to reconnect with their customers in such scenarios. When the reconnection feature is enabled, customers see the option to continue with the previous session or start a new conversation when they come back to the chat session. At the beginning of the chat session, agents can share with the customer a preconfigured link that the customer can copy and use it to reconnect to the same chat and agent when the session is disconnected. The unathenticated customers will be presented only with the reconnect link and not be prompted with options to start a new conversation. When customers come back after the timeout period, you can configure a redirect link to reset the context for the customers, who have to provide the details again so that the conversation is routed to an appropriate queue.

> [!IMPORTANT]
>
> The customer needs to connect back within the specified time and should not end the session by closing the chat window.

## Enable reconnection to a previous chat session

You can enable the reconnection options in the chat widget either while setting up the chat widget for the first time or later based on your needs.

1. In the Omnichannel Administration app, go to **Channels** > **Chat**.

2. On the page that appears, select **New** on the toolbar to create a chat widget or in the **Active Chat Widgets** list, select the chat widget for which you want to enable reconnect chat.

3. On the ***<widget_name>* Chat Widget** page, in the **Chat Reconnect** area, set the toggle to **Yes** to enable reconnection to previous chat. The following options are displayed:
   - **Reconnect time limit:** The value that is set for the **Auto-close after inactivity** field in the work stream associated with the chat widget is displayed.
   - **Reconnect to previous agent for:** Select a value to indicate the time within which the customer can connect back to the same agent and chat session. The agent's capacity is put on hold for the duration specified in this box.
   - **Portal URL:** Specify the link that will be shared by the agent with the customer to reconnect to the chat session.
   - **Redirection URL:** Specify the link that the customer will be redirected to when the reconnect period times out.

4. Select **Save**.

### See also

[Add a chat widget](add-chat-widget.md)