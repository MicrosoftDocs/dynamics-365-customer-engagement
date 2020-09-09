---
title: "Configure a post-conversation survey | MicrosoftDocs"
description: "Instructions to configure a post-conversation survey in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/18/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Configure a post-conversation survey

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../../legal/supp-dynamics365-preview.md).

## Introduction

You can configure your chat widget to show users a survey that they can respond to after they finish a conversation.

> [!NOTE]
> Post-conversation survey is not supported in Government Community Cloud.

## Prerequisite

The post-conversation survey uses Forms Pro to create surveys. Make sure you have access to create surveys in Forms Pro in the same org as Omnichannel for Customer Service, and you've created the required survey. The survey that you create will be listed as an option to choose for linking to the conversation. More information: [Create surveys with Forms Pro](https://go.microsoft.com/fwlink/p/?linkid=2135108)

## How post-conversation surveys work

When you enable a post-conversation survey for a channel, the survey will appear for the customer after the agent or customer ends the conversation. While configuring the survey, you can use the settings for the response options available in Forms Pro. More information: [Work with survey settings](https://docs.microsoft.com/forms-pro/invite-settings)

You can enable post-conversation surveys for the following channels:

- Live chat
- SMS
- Facebook
- LINE
- Twitter
- WeChat
- WhatsApp
- Custom channel
- Microsoft Teams

For a chat channel only, you can configure the survey link or survey questions to be displayed in the chat window.

## Configure a post-conversation survey

You can set up surveys when configuring a channel or update an existing channel instance that is already configured.

1. Sign in to Omnichannel Administration.

2. Go to **Channels**, and select a channel for which you want to configure a post-conversation survey.

3. Select the **Surveys** tab.

4. In the **Post-conversation survey** area, set the toggle for **Turn on** to **Yes**.

5. In **Microsoft Forms Pro survey**, search for a survey and select it.

6. In the **How should we send the survey?** box, the following options are available depending on the channel you select:
   - **Send survey link to conversation:** When selected, sends the survey link to customers.

       - In the **Message** box that appears, select the default message text or type a custom message. The personalized survey link will be appended to the message and displayed to the customer.
   - **Insert survey in conversation:** This option is available only for the Chat channel. When you configure this option, the agent can insert a survey link in an active session. The survey questions are displayed on the customer chat window.

7. Select **Save**.

> [!div class=mx-imgBorder]
> ![Post-conversation survey](../media/oc-post-conversation-survey.png "Post-conversation survey")

> [!NOTE]
> The surveys that you create and survey data that is processed are not hosted or stored in Omnichannel for Customer Service.

### See also

[Add a chat widget](add-chat-widget.md)  
[Channels](channels.md)  
