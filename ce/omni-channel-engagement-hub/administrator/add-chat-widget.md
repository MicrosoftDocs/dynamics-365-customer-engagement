---
title: "Add a chat widget | MicrosoftDocs"
description: "Instructions to add a chat widget in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: DEDC2F99-3AB4-414D-B3DB-B27F871E804A
ms.custom: 
---

# Add a chat widget

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Work Streams**.
3. Select **New** to create a work stream.
4. On the **Summary** tab, in the **Stream Source** field, select **Live Chat**. Save the work stream. For more information, see [Create and manage work streams](create-work-streams.md).
5. On the **Chat settings** tab, in the **Chat widgets** section, select **Add**.
6. On the **New Chat Widget** page, provide the appropriate information on each tab:

    - **Basic details**:

        1. In the **General information** section, enter a name for the chat widget. You can optionally specify authentication settings. Save the record to enter more details. For more information about how to specify authentication settings, see [Create chat authentication settings](create-chat-auth-settings.md).
        2. In the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. The domain format should not include the protocol (for example, **http** or **https**).
        
        > [!NOTE]
        > If no domains are specified, the chat widget can be embedded on any website without restrictions. If you specify a domain, the chat widget can be hosted only on the specified domain.
        
        3. Copy the value in the **Code snippet** section and embed it in the HTML source of your website.
        
        > [!div class=mx-imgBorder]
        > ![Configure the basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure the basic details of a chat widget")

    - **Design**: Use this tab to specify the theme color, logo, title, subtitle, and operating hours of the chat widget. For more information about how to set up operating hours, see [Create and manage operating hours](create-operating-hours.md).

        > [!div class=mx-imgBorder]
        > ![Configure the design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure the design of a chat widget")

    - **Survey**: Use this tab to set up a pre-chat survey. This survey is shown to users before a conversation is initiated. For more information, see [Configure a pre-chat survey](configure-pre-chat-survey.md).

        > [!div class=mx-imgBorder]
        > ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

### See also

[Create a survey questions library](create-question-library.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Dynamics 365 for Customer Engagement Portal](embed-chat-widget-portal.md)
