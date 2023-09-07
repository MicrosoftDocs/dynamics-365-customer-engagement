---
title: "Configure persistent chat | MicrosoftDocs"
description: "Use this article to understand how persistent chat works and how you can configure it in Omnichannel for Customer Service."
ms.date: 07/28/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.collection: get-started
---

# Configure persistent chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and agents need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Live chat and persistent chat share the same channel. If you need to configure both live and persistent chat widgets, create two separate workstreams and update the settings accordingly.  

The primary differences between live chat and persistent chat are as follows:

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Agent availability outside of operation hours|Allows customers to reach out to agents outside of working hours. If no agents are available, the conversation will remain open and the agent will receive the customer's messages during the operating hours.|Outside of operating hours, customers might not be able to chat with live agents.
|Ending conversations|Customers can't end conversations from their side. Only agents can do it. |Both customers and agents can end the conversation by closing the chat.|
|Default system messages|Persistent chat doesn't display default messages about average wait time and queue positions, because a customer doesn't need to wait for an agent. |In live chat, the customer receives system messages about wait time. These messages can be overwritten in the **Settings** tab.

## How persistent chat works

From the start of a conversation until the agent explicitly ends it, agents and customers will be able to see the history of the conversation in the chat widget. Customers can close the chat widget and come back after a long time, and still see their history, with the ability to pick up where they left. When a customer is unresponsive for a long time, agents can attend to other conversations by moving their current conversation into a waiting stage, by selecting the ✖ button. Chats in a waiting stage do not take up agent capacity. When the customer comes back to the chat, the agent is notified and the conversation can be picked up and resolved.

## Prerequisites

Make sure that the authentication settings are configured. More information: [Create chat authentication settings](create-chat-auth-settings.md)

## Set up persistent chat

In Customer Service admin center or Omnichannel admin center, select the **Make chats persistent** checkbox when you create the chat workstream. More information: [Create and manage workstreams](create-workstreams.md)

Make sure that you set the **Keep same agent for entire conversation** toggle to **Yes** in the **Work distribution** settings of the workstream. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)


#### Set up persistent chat in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

You can enable persistent chat in the chat widget settings for a chat channel.
<!-- >

1. Go to Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Select **New chat widget**. For more information, see [Add a chat widget](add-chat-widget.md).

4. In the **Conversation Mode** area, for **Select mode**, select  **Persistent Chat**.

5. Select **Save**.

6. Go to **Work Distribution Management** > **Work Streams**.

7. Change the **auto-close after inactivity** field from the default value to a value of your choice, that will allow conversations to stay open longer.

8. Set **agent affinity** to true. When a customer returns to the chat, this setting ensures the system connects them to the same agent. The conversation stays with the agent regardless of capacity or presence until a supervisor manually reassigns it to another agent or moves it back to a queue.

9. Select **Save and close**.
-->

### See also

[Configure a chat widget](add-chat-widget.md)  
[Create and manage workstreams](create-workstreams.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
