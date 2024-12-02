---
title: Embed chat widget in your website or portal
description: Embed a chat widget in your website, portal, or mobile experience to provide customers with a personalized experience.
ms.date: 12/04/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/29/2023
---

# Embed chat widget in your website or portal

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

## Embed chat widget in a website or Power Apps portal

Do the following steps to embed the chat widget in a website or Power Apps portal.

1. In Dynamics 365, go to Customer Service admin center.

1. Go to **Channels** &gt; **Chat**.

1. Select the chat instance that you want to embed in your website, and select **Edit**.

1. On the **Chat widget** tab, copy the widget code snippet in the **chat widget** section and then do one or all of the following:

   - To embed chat widget in your website, paste the code in the HTML source \<body\> of your website.

   - To embed chat widget in your Power Apps portals,

        1. [Open the Portal Management app](/powerapps/maker/portals/configure/configure-portal).
        1. Go to **Portal** > **Content Snippets**.
        1. Find the **Chat Widget Code** content snippet and open it.
           :::image type="content" source="../media/portal-content-snippet.png" alt-text="Screenshot of the chat code snippet in portal.":::
        1. On the **General** tab, scroll down to the **Value (HTML)** field, and paste the chat widget snippet code.         
        1. Save the changes. The chat widget is now embedded into the portal.

If you don't see your chat widget in the portal, see [Troubleshoot issues in Omnichannel for Customer Service](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/chat-widget-not-loading-portal).


## Embed chat widget in mobile experiences

1. Create the code snippet. Refer to [Render a live chat widget on the mobile app](../develop/render-live-chat-widget-mobile.md) for samples showing how to enable rendering of the web version of the live chat widget on mobile devices.
1. In Customer Service admin center, go to **Channels** &gt; **Chat**.
1. Open the chat widget you want to embed in your website or create a new one.
1. On the **Chat widget** tab, copy the widget code snippet in the **chat widget** section and paste it in the source code of your mobile operating system.

## Customer experience of chat widget

After you configure the chat widget, it has the following capabilities:

- **Minimized mode**: By default, the chat widget appears in minimized mode. If any messages come while the widget is in the minimized mode, a count of the messages is shown.
     
     :::image type="content" source="../media/oc-chat-widget-minimized-mode.png" alt-text="Screenshot of chat widget in minimized mode.":::

- **Maximized mode**: A user can maximize the chat widget to start a conversation with an agent.

- **System events**: System-generated messages appear for events, such as when an agent joins a conversation, or a conversation is transferred by the agent or supervisor to another agent.
      :::image type="content" source="../media/chat-widget-system-events.png" alt-text="Screenshot of chat widget with system event messages displayed on the widget for customer."::: 
    
- **Keyboard shortcut**: During the chat session, the customer can press **Ctrl+/** to return the cursor to the message send box from elsewhere on the page.

- **Pre-conversation survey**: If a survey is configured by an admin, it appears for the user before the conversation starts. This survey also helps the user connect to an appropriate agent.
      :::image type="content" source="../media/oc-chat-widget-pre-chat.png" alt-text="Screenshot of pre-conversation survey questions that are displayed to the customer.":::
    
- **End chat**: A customer can end the conversation by selecting the **Close chat** button. A confirmation message appears before the conversation ends.

> [!NOTE]
> For advanced configuration like embedding chat widget on specific web pages, see [Create and manage portals](/powerapps/maker/portals/portal-templates).

### Related information

[Supported browsers for live chat widget](../implement/system-requirements-omnichannel.md#browsers-for-chat)  
[Add a chat widget](add-chat-widget.md)  
[Configure a pre-conversation survey](configure-pre-chat-survey.md)  
[Configure agent display name](agent-display-name.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Create quick replies](create-quick-replies.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Render a live chat widget on the mobile app](../develop/render-live-chat-widget-mobile.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
