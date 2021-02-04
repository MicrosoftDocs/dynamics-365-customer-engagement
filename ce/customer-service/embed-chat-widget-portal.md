---
title: "Embed chat widget in your website or portal | MicrosoftDocs"
description: "Instructions to embed chat widget in your website or Power Apps portal."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 08/04/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Embed chat widget in your website or portal

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Embed chat widget in your web portal

To embed a chat widget in your web portal:

1.	Sign in to Omnichannel Administration.
2.	Go to **Channels** &gt; **Chat**.
3.	Open the chat widget you want to embed in your website.
4.	On the **Basic details** tab, copy the widget snippet code from the **Code snippet** section.
5.  Paste the chat widget snippet code in the HTML source of your website.

## Embed chat widget in your Power Apps portal

To embed a chat widget in Power Apps portals:

1.	Sign in to Omnichannel Administration.
2.	Go to **Channels** &gt; **Chat**.
3.	Open the chat widget you want to embed in Power Apps portals.
4.	On the **Basic details** tab, copy the widget snippet code from the **Code snippet** section.
    > [!div class=mx-imgBorder]
    > ![Copy code snippet of a chat widget](media/chat-widget-snippet.png "Copy code snippet of a chat widget")
5.	[Open the Portal Management app](https://docs.microsoft.com/powerapps/maker/portals/configure/configure-portal).
6.	Go to **Portal** > **Content Snippets**.
7.	Find the **Chat Widget Code** content snippet and open it.
    > [!div class=mx-imgBorder]
    > ![Go to Chat Widget Code content snippet in portal](media/portal-content-snippet.png "Go to Chat Widget Code content snippet in portal")    
8.	On the **General** tab, scroll-down to the **Value (HTML)** section.
9.	Paste the chat widget snippet code in the **HTML** tab.
    >[!div class=mx-imgBorder]
    > ![Paste code snippet of a chat widget](media/paste-snippet.png "Paste code snippet of a chat widget")
10.	Save the changes. The chat widget is now embedded into the portal.

If you don't see your chat widget in the portal, see [Troubleshoot Omnichannel for Customer Service](troubleshoot-omnichannel-customer-service.md).

## Embed chat widget in mobile experiences

To embed a chat widget in a mobile app:

1. Create the code snippet. Refer to [Render a live chat widget on the mobile app](render-live-chat-widget-mobile.md) for samples showing how to enable rendering of the web version of the live chat widget on mobile devices.
2.	Sign in to Omnichannel Administration.
3.	Go to **Channels** &gt; **Chat**.
4.	Open the chat widget you want to embed in your website or create a new one.
5.	On the **Basic details** tab, copy the widget snippet code you created or modified into the **Code snippet** section.
6.  Copy the widget snippet code from the **Code snippet** section and paste it in the source code of your mobile operating system. 

## Customer experience of chat widget

After the chat widget is configured, it has the following capabilities:

- **Minimized mode**: By default, the chat widget is shown in minimized mode. If any messages are received while the widget is in this mode, a count of the messages is shown.

    > [!div class=mx-imgBorder]
    > ![Chat widget in minimized mode](media/oc-chat-widget-minimized-mode.png "Chat widget in minimized mode")

- **Maximized mode**: A user can maximize the chat widget to start a conversation with an agent.

- **System events**: System-generated messages are shown for events, such as when an agent joins a chat, or a chat is transferred to another agent.

    > [!div class=mx-imgBorder]
    > ![System events in the chat widget](media/chat-widget-system-events.png "System events in the chat widget")

- **Keyboard shortcut**: During the chat session, the customer can press **Ctrl+/** to return the cursor to the message send box from elsewhere on the page. 

- **Pre-chat survey**: If a survey has been configured by an admin, it's shown to the user before the conversation is started. This survey also helps the user connect to an appropriate agent.

    > [!div class=mx-imgBorder]
    > ![Pre-chat survey in the chat widget](media/oc-chat-widget-pre-chat.png "Pre-chat survey in the chat widget")

- **End chat**: A customer can end the chat by selecting the **Close chat** button. A confirmation message is displayed before ending the chat.

> [!NOTE]
> For advanced configuration like embedding chat widget on specific web pages, see [Manage portal content](/portals/manage-portal-content.md). 

### See also

[Supported browsers for live chat widget](system-requirements-omnichannel.md#browsers-for-chat)  
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Render a live chat widget on the mobile app](render-live-chat-widget-mobile.md) 
