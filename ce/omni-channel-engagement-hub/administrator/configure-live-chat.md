---
title: "Configure a live chat widget and embed it in portal"
description: "Instructions to configure a live widget in Omni-channel Engagement Hub and embed it in Dynamics 365 Portal."
keywords: live chat work stream, live chat widget, omni-channel engagement hub
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 01/16/2019
ms.service: 
ms.topic: article
ms.assetid: 55DFF759-DD1C-4B71-A232-2015C085E748
ms.custom: 
---

# Configure a live chat widget and embed it in portal

Quickly configure and add a live chat to your portal to talk to your customers and prospects in real-time. This helps you to initiate conversations with first-time website visitors and solve issues of your existing customers instantly. To configure a live chat widget and embed it in portal, you must:

1. [Create a live chat work stream](#step-1-create-a-live-chat-work-stream)
2. [Create a chat widget](#step-2-create-a-chat-widget)
3. [Embed chat widget in portal](#step-3-embed-chat-widget-in-portal)

## Step 1: Create a live chat work stream

1. In the omni-channel site map, go to **Work Streams** and select **New** from the command bar.
2. On the **Summary** tab of the new work stream page, provide the appropriate information in each section:

    - **General Information** 
        1. **Name**: Enter a name for the work stream.
        2. **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
        3. **Stream Source**: Select the channel supported for the work stream: **Live Chat**. 
        4. **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity.
        5. **Record Identification Rule**: Follow the steps given in the topic [Configure record identification rule](record-identification-rule.md). 
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

## Step 2: Create a chat widget

1. Go to the work stream created in [Step 1](#step-1-create-a-live-chat-work-stream).
2. On the **Chat settings** tab, in the **Chat widgets** section, select **Add**.
3. On the **New Chat Widget** page, provide the appropriate information on each tab.

    - **Basic details**:

        1. In the **General information** section, enter a name for the chat widget. You can optionally specify authentication settings. Save the record to enter more details.
        2. In the **Widget location** section, select **Add** to specify the portal domain where the chat widget must be shown. If you don't specify a domain, the chat widget is shown in all configured domains. The domain format should not include the protocol (for example, **http** or **https**).

            > [!div class=mx-imgBorder]
            > ![Configure the basic details of a chat widget](../media/chat-widget-snippet.png "Configure the basic details of a chat widget")

    - **Design**: Use this tab to specify the theme color, logo, title, subtitle, position, and operating hours of the chat widget.

    - **Survey**: Use this tab to set up a pre-chat survey. This survey is shown to users before a conversation is initiated.

## Step 3: Embed chat widget in portal

1. Open the chat widget created in [Step 2](#step-2-create-a-chat-widget).
2. On the **Basic details** tab, copy the widget snippet code from the **Code snippet** section.
    > [!div class=mx-imgBorder]
    > ![Copy code snippet of a chat widget](../media/chat-widget-snippet.png "Copy code snippet of a chat widget")
3. Open the Dynamics 365 for Customer Engagement Portal app.
4. Go to **Portal** > **Web Pages**.
5. Change the view to **Localized Content**.
6. Open the web page on which the chat widget needs to be embedded.
7. On the **General** tab, scroll-down to the **Content** section.
8. Paste the chat widget snippet code in the **HTML** tab.
    > [!div class=mx-imgBorder]
    > ![Paste code snippet of a chat widget](../media/paste-snippet.png "Paste code snippet of a chat widget")
9. Save the changes. The chat widget is now embedded into the web page.

### See also

[Create and manage work streams](work-streams.md) </br>
[Set up a chat widget](set-up-chat-widget.md)
