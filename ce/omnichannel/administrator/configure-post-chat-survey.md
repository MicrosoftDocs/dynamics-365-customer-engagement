---
title: "Configure a post-chat survey | MicrosoftDocs"
description: "Instructions to configure a post-chat survey in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Configure a post-conversation survey

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

You can configure your chat widget to show users a survey that they can respond to after they finish a conversation.

## Prerequisite

The post-conversation survey uses Microsoft Forms Pro to create surveys. Make sure you have access to create surveys in Microsoft Forms Pro in the same org as Omnichannel for Customer Service and have created the required survey. The survey that you create will be listed as an option to choose for linking to the conversation. More information: [Create surveys with Forms Pro](https://go.microsoft.com/fwlink/p/?linkid=2135108).

## How post-conversation survey works

When you enable post-conversation survey for a channel, the survey will appear for the customer after the agent or customer ends the conversation. You can configure the survey link or survey questions to be displayed in the chat window.

## Configure a post-conversation survey for a chat widget

Perform the following steps to configure the survey:

1. Sign in to Omnichannel Administration.
2. Go to **Channels** &gt; **Chat**.
3. Open the channel for which you want to configure a post-chat survey, and select **Survey**.
4. In the **Post-conversation survey** area, set the toggle for **Turn on** to **Yes**.
5. In **Microsoft Forms Pro survey**, search for a survey, and select it.
6. In the **How should we send the survey** box, select Insert survey in conversation or Send survey link to conversation.
7. If you selected **Send survey link to conversation**, in the **Message** box that appears, select the default message text or type a custom message. The personalized survey link is appended to the message and displayed to the customer.
8. Select **Save**.

    > [!div class=mx-imgBorder]
    > ![Post-conversation survey](../media/oc-post-conversation-survey.png "Post-conversation survey")

### See also

[Add a chat widget](add-chat-widget.md)  
[Channels](channels.md)  