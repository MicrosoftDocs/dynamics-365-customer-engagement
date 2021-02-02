---
title: "Persistent chat | MicrosoftDocs"
description: "Overview of Persistent chat in Omnichannel for Customer Service."
author: Meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 01/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Preview: Configure persistent chat

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).



## Configure persistent chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and agents need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Live chat and persistent chat share the same channel. 

The primary differences between live chat and persistent chat are as follows:

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Agent availability outside of operation hours|Allows customers to reach out to agents outside of working hours. If no agents are available, the conversation will remain open and the agent will receive the customer's messages during the operating hours.|Outside of operating hours, customers mightn't be able to chat with live agents.
|Ending conversations|Customers can't end conversations from their side. Only agents can do it. |Both customers and agents can end the conversation by closing the chat.|
|Default system messages|Persistent chat doesn't display default messages about average wait time and queue positions, because a customer doesn't need to wait for an agent. |In live chat, the customer receives system messages about wait time. These messages can be overwritten in the settings tab.

## How persistent chat works

From the start of a conversation until the agent explicitly ends it, agents and customers will be able to see the history of the conversation in the chat widget. Customers can close the chat widget and come back after a long time, and still see their history, with the ability to pick up where they left. When a customer is unresponsive for a long time, agents can attend to other conversations by moving their current conversation into a waiting stage, by clicking on the ✖ button. When the customer comes back to the chat, the agent is notified and the conversation can be picked up and resolved.

## Set up persistent chat

You can enable persistent chat in the chat widget settings for a chat channel.You will need to add authentication settings to configure persistent chat. For more information on adding authentication settings, see : [Create chat authentication settings](create-chat-auth-settings.md)

1. Sign into Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Select **New chat widget**. For more information, see [Add a chat widget](add-chat-widget.md).

4. In the **Conversation Mode** area, for **Select mode**, choose "Persistent Chat".

5. Select **Save**.

6. Go to **Work Distribution Management** > **Work Streams**.

7. Change the **auto-close after inactivity** field from the default value to 28 days, that will allow conversations to stay open longer.

8. Set **agent affinity** to true. When a customer returns to the chat, this setting will ensure that the system first tries to connect them to the same agent.

> [!NOTE] 
> If you need to configure both live and persistent chat widgets, ensure to create two separate work streams and update the settings accordingly.  

9. Select **Save and close**.

### See also

[Configure a chat widget](add-chat-widget.md)

[Create work streams](work-streams-introduction.md)