---
title: "Configure a chat widget and embed it in portal | MicrosoftDocs"
description: "Instructions to configure a chat widget in Omni-channel Engagement Hub and embed it in Dynamics 365 Portal."
keywords: live chat work stream, chat widget, omni-channel engagement hub
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 55DFF759-DD1C-4B71-A232-2015C085E748
ms.custom: 
---

# Quickly configure a chat widget

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Quickly configure and add a chat widget to your portal to chat with your customers and prospects. To configure a chat widget and embed it in portal, you must:

1. [Create a live chat work stream](#step-1-create-a-live-chat-work-stream)
2. [Configure a chat widget](#step-2-configure-a-chat-widget)
3. [Embed chat widget in portal](#step-3-embed-chat-widget-in-portal)

## Step 1: Create a live chat work stream

1. In the omni-channel site map, go to **Work Streams** and select **New** from the command bar.
2. On the **Summary** tab of the new work stream page, provide the name of the work stream.
3. In the **Stream source** drop-down list, select **Live chat** as the channel.
4. Select **Save** to save the live chat work stream.

   > [!div class=mx-imgBorder]
   > ![New workstream](../media/omni-channel-new-work-stream.png)

## Step 2: Configure a chat widget

1. On the **Chat settings** tab, in the **Chat widgets** section, select **Add**. The **New Chat Widget** page opens.
2. On the **Basic details** tab, in the **General information** section, enter a name for the chat widget, and save the record.
3. Copy the widget snippet code from the Code snippet section. This snippet code will be used in [Step 3](#step-3-embed-chat-widget-in-portal).

    > [!div class=mx-imgBorder]
    > ![Configure the basic details of a chat widget and copy code snippet of a chat widget](../media/chat-widget-snippet.png "Configure the basic details of a chat widget and copy code snippet of a chat widget")

## Step 3: Embed chat widget in portal

1.	Open the Dynamics 365 for Customer Engagement Portal app.
2.	Go to **Portal** > **Content Snippets**.
3.	Find the **Chat Widget Code** content snippet and open it.
    > [!div class=mx-imgBorder]
    > ![Go to Chat Widget Code content snippet in portal](../media/portal-content-snippet.png "Go to Chat Widget Code content snippet in portal")
4.	On the **General** tab, scroll-down to the **Value (HTML)** section.
5.	Paste the chat widget snippet code in the **HTML** tab.
    > [!div class=mx-imgBorder]
    > ![Paste code snippet of a chat widget](../media/paste-snippet.png "Paste code snippet of a chat widget")
6.	Save the changes. The chat widget is now embedded into the portal.

### See also

[Create and manage work streams](create-work-streams.md) </br>
[Create and manage routing rules in Omni-channel](routing-rules.md) </br>
[Configure a chat widget](set-up-chat-widget.md)
