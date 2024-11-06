---
title: Configure post-conversation survey
description: Learn how to configure a post-conversation survey for the channels in your contact center.
ms.date: 08/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Configure a post-conversation survey

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


You can configure your chat widget to show users a survey that they can respond to after they finish a conversation.

> [!NOTE]
> Post-conversation surveys are not supported in Government Community Cloud.

## How post-conversation surveys work

When you enable a post-conversation survey for a channel, the survey will appear for the customer after the agent or customer ends the conversation. While configuring the survey, you can use the settings for the response options available in Dynamics 365 Customer Voice. More information: [Work with survey settings](/dynamics365/customer-voice/distribution-settings)

The post-conversation works as follows:

1. Create a survey in Dynamics 365 Customer Voice
2. Configure a survey
3. Experience the runtime behavior

You can enable post-conversation surveys for the following channels:

- Live chat
- SMS for Twilio, SMS for TeleSign
- Facebook
- LINE
- WeChat
- WhatsApp
- Custom channel
- Microsoft Teams
- Apple Messages for Business

For the Live chat channel only, you can configure the survey link or survey questions to be displayed in the chat window.

## Prerequisite

The post-conversation survey uses Dynamics 365 Customer Voice to create surveys. Make sure that you have access to create surveys in Dynamics 365 Customer Voice in the same org as Omnichannel for Customer Service, and you created the required survey. The survey that you create is listed as an option to choose for linking to the conversation. More information: [Create surveys with Dynamics 365 Customer Voice](/dynamics365/customer-voice/create-survey)

## Configure the post-conversation survey

You can set up surveys when configuring a channel or update an existing channel instance that is already configured.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Workstreams** in **Customer support**.

1. Select the channel instance, and then select **Edit**.

1. On the **Behaviors** tab, set the toggle for **Post-conversation survey** to **On**.

1. In **Dynamics 365 Customer Voice survey**, search for the survey you want to configure, and select it.
    - Optionally, if you want to create a survey, select **Create Dynamics 365 Customer Voice**. The Dynamics 365 Customer Voice page opens on a new tab, where you perform the steps to create a survey. After you create the survey, it's available for selection in the **Dynamics 365 Customer Voice survey** box in the **Post-conversation survey** area.

1. In the **How should we send the survey** box, the following options are available depending on the channel you select:
    - **Send survey link to conversation:** At runtime, the survey link is sent to the customers.

       - In the **Message** box that appears, select the default message text or type a custom message. The personalized survey link is appended to the message and displayed to the customer.
    - **Insert survey in conversation:** At runtime, the agent can insert a survey link in an active conversation that results in the survey questions being displayed on the customer chat window. This option is available only for the Live chat channel.

1. Select the **Bot conversation survey** checkbox to share surveys for conversations that are handled by bots.


   By default, the **Use same survey settings as above** checkbox is selected.

1. If you want to use different survey settings for the conversations handled by bots, repeat steps 4 and 5.

1. Select **Save and close**.

## Runtime experience of post-conversation surveys

If the post-conversation survey is enabled for a conversation, after the conversation ends, the pre-designed survey is shared with the customer. This survey allows you to keep a track of the customer feedback for the service provided. Any conversation can be considered as closed when one of the following scenarios happens:

- Agent closes the chat conversation
- Customer closes the chat conversation
- System closes the chat conversation after a predefined time

For Live chat conversations, customers can receive survey questions within the same conversation or through a link that takes them to an external site. For SMS and social channels, a survey link is shared.

> [!NOTE]
> The surveys that you create and the survey data that's processed are not hosted or stored in Omnichannel for Customer Service.
>
> [!NOTE]
> Survey responses will be logged as "Anonymous" and will appear as "anonymous-post-conversation@omnichannelengagementhub.com"

### Related information

[Add a chat widget](add-chat-widget.md)  
[Channels](../use/channels.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
