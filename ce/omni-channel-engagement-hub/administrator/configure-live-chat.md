---
title: "Configure a live chat widget and embed it in portal | MicrosoftDocs"
description: "Instructions to configure a live widget in Omni-channel Engagement Hub and embed it in Dynamics 365 Portal."
keywords: live chat work stream, live chat widget, omni-channel engagement hub
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

Quickly configure and add a live chat widget to your portal to chat with your customers and prospects. To configure a live chat widget and embed it in portal, you must:

1. [Create a live chat work stream](#step-1-create-a-live-chat-work-stream)
2. [Configure a chat widget](#step-2-configure-a-chat-widget)
3. [Embed chat widget in portal](#step-3-embed-chat-widget-in-portal)

## Step 1: Create a live chat work stream

1. In the omni-channel site map, go to **Work Streams** and select **New** from the command bar.
2. On the **Summary** tab of the new work stream page, provide the appropriate information in each section:

    - **General Information** 
        1. **Name**: Enter a name for the work stream.
        2. **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
        3. **Stream Source**: Select the channel supported for the work stream: **Live Chat**. 
        4. **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity.
        5. **Record Identification Rule**: Follow the steps given in the topic [Set up record identification rule](record-identification-rule.md). 
        6. Select **Save** to save the work stream.
   
     - **Work distribution**
        1. Select whether the work distribution mode should be **Push** or **Pick**.
        2. In the **Notification** field, select the type of notification setting.
        3. In the **Screen pop timeout** field, select the amount of time before the screen pop times out.
            > [!NOTE]
            > The **Notification** and **Screen pop timeout** fields aren't supported in this preview. They will be made available in a future release.
            
      - **Context variables**
        1. Select **New** to create a new context variable for the work stream. 
        2. In the **Quick Create** flyout, enter a name and specify the type for the context variable.
        
 4. Define the routing rules in the **Routing Rule Item** tab. To know how to configure a routing rule, see [Create and manage routing rules in Omni-channel](routing-rules.md).    
 
 5. Select **Save** to save the live chat work stream.

       ![New workstream](../media/omni-channel-new-work-stream.png)

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
