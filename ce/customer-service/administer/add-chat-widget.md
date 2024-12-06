---
title: Configure a chat widget
description: Perform the steps mentioned in the article to configure a chat widget in Dynamics 365 Contact Center.
ms.date: 02/29/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: article
---

# Configure a chat widget

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

You can configure a live chat widget that can be displayed on your portal for customers to interact with bots and human agents.

To add a chat widget, configure a workstream that defines how chat conversations are routed to queues. More information: [Create a workstream](create-workstreams.md)

## Configure a chat widget

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Chat**. The **Chat channels** page appears.
    
1. Select **Add chat channel**.

1. On the **Channel details** page, enter a name and select a language in the **Name** and **Language** fields, respectively.

1. On the **Chat Widget** page, enter the following details:
   - **Title:** Display name for the chat widget.
   - **Subtitle:** Additional title, such as "We're online".
   - **Theme color:** Choose a color from the list.
   - **Logo URL:** Select the default value or enter the link to the logo that you want to be displayed.
   - **Agent display name:** Select a value from the list.
   > [!NOTE]
   > You can customize the chat widget appearance using data tags. Learn more at [Customize live chat widgets using data tags](../develop/customize-chat-widget.md).

1. Switch the toggle to **Yes** to enable the following options:
   - [Proactive chat](proactive-chat.md)
   - [Reconnect to previous chat](configure-reconnect-chat.md)
   - Only show widget during operation hours
     - **Operation hours name**: Select an operating hour setting. More information: [Configure operating hours](create-operating-hours.md).
   - **Only show widget on the provided domains**: Enter the link of the portal.

1. On the **Behaviors** page, configure the following options:
   - [Custom automated messages](configure-automated-message.md)
   - [Pre-conversation survey](configure-pre-chat-survey.md)
   - [Post-conversation survey](configure-post-conversation-survey.md)
   - [Authentication settings](create-chat-auth-settings.md)
   - Customer wait time
      
      > [!Note] 
      > These settings aren't configurable for the persistent chat feature. More information: [Configure persistent chat](persistent-chat.md)
   
       - **Show position in queue:** Select this if you want to show customers their position in the queue when they're waiting to interact with an agent. More information: [Show customers their queue position](show-queue.md)
       - **Show average wait time:** Select this if you want to show to customers the average wait time in the queue when they're waiting to interact with an agent. More information: [Show customers their average wait time in a queue](average-wait-time.md)
   - **Customer location detection:** Select a location provider. More information: [Set up visitor location detection](geo-location-provider.md).

1. On the **User features** page, configure the following options:
   - [File attachments](enable-file-attachments.md)
   - [Customer notifications](#configure-customer-notifications)
   - [Conversation transcripts](download-email-chat-transcripts.md)
   - **Voice and video calls**: Switch the toggle to **On** and select the calling option.
   - **Screen sharing**: Switch the toggle to **On** and select a provider.
   - **Co-browse**: Switch the toggle to **On** and select a provider if you want the agents to see and interact with a customer's web browse.

      > [!NOTE]
      > - You must install a third-party provider from AppSource to use the screen sharing or co-browse feature.
      > - You can select only one co-browse provider and or one screen sharing provider for each chat widget. Only those co-browse and screen sharing providers that have published a solution on AppSource will appear in the lists.

1. On the **Review and finish** page, review the channel settings, and select **Create channel**.

### Configure customer notifications

You can configure visual and sound notifications to be sent to customers when they're interacting with agents through the chat widget on your organization portal. If the chat window is minimized or isn't active, a sound notification is played when a message arrives and a count of the unread messages is displayed.

Perform the following steps to enable the customer notifications:

1. In Customer Service admin center or Contact Center admin center, edit a chat widget, and on the **Chat channel settings** page, select the **User features** tab.
2. For **Customer notifications**, switch the toggle to **On**. The following checkboxes are displayed as selected:
   - **Show number of new messages**
   - **Play sound notifications for new messages**
3. Keep the default settings or select one of them depending on your requirement.

You can also configure the customer notifications when you're configuring the chat channel.

### Troubleshooting

[Errors in creating a chat widget](../troubleshoot-omnichannel-customer-service.md#chat-widget)

### Related information

[Configure a pre-conversation survey](configure-pre-chat-survey.md)  
[Configure agent display name](agent-display-name.md)  
[Configure proactive chat](proactive-chat.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Create quick replies](create-quick-replies.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)  
[Embed chat widget in mobile experiences](../develop/render-live-chat-widget-mobile.md)  
[Supported browsers for live chat widget](../implement/system-requirements-omnichannel.md#browsers-for-chat)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
