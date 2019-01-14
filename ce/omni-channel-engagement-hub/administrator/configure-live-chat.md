---
title: "Configure a live chat widget and embed it in portal"
description: "Instructions to configure a live widget in Omni-channel Engagement Hub and embed it in Dynamics 365 Portal."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 01/14/2019
ms.service: 
ms.topic: article
ms.assetid: 55DFF759-DD1C-4B71-A232-2015C085E748
ms.custom: 
---

# Configure a live chat widget and embed it in portal

To configure a live chat widget and embed it in portal, you must:

1. [Create a work stream](#step-1-create-a-work-stream)
2. [Create a chat widget](#step-2-create-a-chat-widget)
3. [Embed chat widget in portal](#step-3-embed-chat-widget-in-portal)

## Step 1: Create a work stream

## Step 2: Create a chat widget

1. Go to the work stream created in [Step 1](#step-1-create-a-work-stream).
2. On the **Chat settings** tab, in the **Chat widgets** section, select **Add**.
3. On the **New Chat Widget** page, provide the appropriate information on each tab.

    - **Basic details**:

        1. In the **General information** section, enter a name for the chat widget. You can optionally specify authentication settings. Save the record to enter more details.
        2. In the **Widget location** section, select **Add** to specify the portal domain where the chat widget must be shown. If you don't specify a domain, the chat widget is shown in all configured domains. The domain format should not include the protocol (for example, **http** or **https**).

            > [!div class=mx-imgBorder]
            > ![Configure the basic details of a chat widget](../media/chat-widget-snippet.png "Configure the basic details of a chat widget")

    - **Design**: Use this tab to specify the theme color, logo, title, subtitle, position, and operating hours of the chat widget.

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

[Set up a chat widget](set-up-chat-widget.md)
