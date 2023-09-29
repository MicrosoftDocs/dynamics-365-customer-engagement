---
title: Embed chat widget in your website or portal
description: Embed a chat widget in your website, portal, or mobile experience to provide customers with a personalized experience.
ms.date: 09/29/2023
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.article: how-to
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/29/2023
---

# Embed chat widget in your website or portal

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Do the following steps to embed the chat widget in a portal, Power Apps portal, or mobile experiences.

1. In Dynamics 365, go to Customer Service admin center.

1. Go to **Channels** &gt; **Chat**.

1. Select the chat instance that you want to embed in your website, and select **Edit**.

1. On the **Chat widget** tab, copy the widget code snippet in the **chat widget** section.

### [Embed chat widget in your web portal](#tab/webportal)

1. Paste the code in the HTML source \<body\> of your website.

### [Embed chat widget in your Power Apps portals](#tab/powerappsportal)

1. [Open the Portal Management app](/powerapps/maker/portals/configure/configure-portal).

1. Go to **Portal** > **Content Snippets**.

1. Find the **Chat Widget Code** content snippet and open it.
    > [!div class=mx-imgBorder]
    > ![Go to Chat Widget Code content snippet in portal.](media/portal-content-snippet.png "Go to Chat Widget Code content snippet in portal")

1. On the **General** tab, scroll down to the **Value (HTML)** section.

1. Paste the chat widget snippet code in the **HTML** tab.
    >[!div class=mx-imgBorder]
    > ![Paste code snippet of a chat widget.](media/paste-snippet.png "Paste code snippet of a chat widget")

1. Save the changes. The chat widget is now embedded into the portal.

If you don't see your chat widget in the portal, see [Troubleshoot issues in Omnichannel for Customer Service](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/chat-widget-not-loading-portal).

## Embed chat widget in mobile experiences

1. Create the code snippet. Refer to [Render a live chat widget on the mobile app](render-live-chat-widget-mobile.md) for samples showing how to enable rendering of the web version of the live chat widget on mobile devices.
1. In Customer Service admin center, go to **Channels** &gt; **Chat**.
1. Open the chat widget you want to embed in your website or create a new one.
1. On the **Basic details** tab, copy the widget snippet code you created or modified into the **Code snippet** section.
1. Copy the widget snippet code from the **Code snippet** section and paste it in the source code of your mobile operating system.

## Customer experience of chat widget

After you configure the chat widget, it has the following capabilities:

- **Minimized mode**: By default, the chat widget appears in minimized mode. If any messages come while the widget is in the minimized mode, a count of the messages is shown.

    > [!div class=mx-imgBorder]
    > ![Chat widget in minimized mode.](media/oc-chat-widget-minimized-mode.png "Chat widget in minimized mode")

- **Maximized mode**: A user can maximize the chat widget to start a conversation with an agent.

- **System events**: System-generated messages appear for events, such as when an agent joins a conversation, or a conversation is transferred by the agent or supervisor to another agent.

    > [!div class=mx-imgBorder]
    > ![System events in the chat widget.](media/chat-widget-system-events.png "System events in the chat widget")

- **Keyboard shortcut**: During the chat session, the customer can press **Ctrl+/** to return the cursor to the message send box from elsewhere on the page.

- **Pre-chat survey**: If a survey is configured by an admin, it appears for the user before the conversation starts. This survey also helps the user connect to an appropriate agent.

    > [!div class=mx-imgBorder]
    > ![Pre-chat survey in the chat widget.](media/oc-chat-widget-pre-chat.png "Pre-chat survey in the chat widget")

- **End chat**: A customer can end the conversation by selecting the **Close chat** button. A confirmation message appears before the conversation ends.

> [!NOTE]
> For advanced configuration like embedding chat widget on specific web pages, see [Create and manage portals](/powerapps/maker/portals/portal-templates).

### See also

[Supported browsers for live chat widget](system-requirements-omnichannel.md#browsers-for-chat)  
[Add a chat widget](add-chat-widget.md)  
[Configure a pre-conversation survey](configure-pre-chat-survey.md)  
[Configure agent display name](agent-display-name.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Create quick replies](create-quick-replies.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Render a live chat widget on the mobile app](render-live-chat-widget-mobile.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
