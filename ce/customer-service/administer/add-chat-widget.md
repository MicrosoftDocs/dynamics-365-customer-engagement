---
title: Configure a chat widget in Dynamics 365 Contact Center
description: Learn how to configure a chat widget in Dynamics 365 Contact Center.
ms.date: 08/07/2026
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
---

# Configure a chat widget

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

You can configure a live chat widget that you display on your portal so customers can interact with AI agents and service representatives.

To add a chat widget, configure a workstream that defines how chat conversations are routed to queues. Learn more in [Create a workstream](create-workstreams.md).

## Configure the modern chat widget (Preview)

You can add the modern chat widget to an existing channel or create a new channel and then add the widget.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

### Add to an existing Chat channel

1. In the site map of Copilot Service admin center, select **Workstreams** in **Customer support**. The **Workstreams** page appears.

1. Select an existing **Workstream** where the **Channel** is set to **Chat**.

1. Select **Add Modern UI**.

> [!NOTE]
> - By adding the widget to an existing channel, you can test and deploy the new **Modern** widget while preserving your existing workstream configurations. Use this approach if you already deployed the classic widget.
> - Some settings, such as **Behaviors** and **User features**, are shared between the modern and classic versions. You can edit them in the active version only to prevent accidental changes on your live site before you're ready to deploy the new version.

### Create a new Chat channel

1. In the site map of Copilot Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.

1. Select **Manage** for **Chat**. The **Chat channels** page appears.
1. Select **Add chat channel**.
1. Select **Modern**. A preview of the widget appears with the default settings in the right pane. The system updates the preview in real time based on your selections.
1. Select **Continue** and do the steps in the next section.

### Set up the modern widget

1. In **General Configuration**, enter a name and select a language in the **Name** and **Language** fields.

1. In **Workstream details**, select one of the options and enter the details. Learn more in [Create workstreams](create-workstreams.md).

1. In **Color Settings**, select **Brand color** to open the **Color Selector**, and choose your brand color.

1. In **Chat button**, select one of the options:
   - **Select an icon**: An icon to display in your chat button.
   - **Use custom icon**: Enter your icon URL in the **Icon image URL** field. This icon must be a publicly hosted .png or .svg file.

1. In **Header**, enter the following details:
   - **Show header text**: Leave the toggle **On** to display a title for your widget.
   - **Header text**: Enter the text for your header.
   - **Show widget icon**: Leave the toggle **On** to display a header logo.
   - Select an icon or **Use custom icon**. If you use custom icon, the icon must be a publicly hosted .png or .svg file.

1. In **Intro page**, enter the following details:
   - **Enable intro page**: Leave the toggle **On** to show a customer prompt when the customer opens the widget.
   - **Greeting title**
   - **Greeting subtitle**: Enter a subtitle for the greeting. This text typically prompts the customer to ask a question.
   - **Show legal disclaimer**: Leave the toggle **On** to always show a disclaimer to customers.
   - **Disclaimer text**: Enter disclaimer to show to customers.

1. In **Chat Widget**, enter the following details:
   - **Allow users to expand the chat**: Turn on the toggle to enable a button that allows the customer to increase the widget size.
   - **Set custom size**: Turn on the toggle, and then change the **Width** and **Height** sliders to change the default widget size.
   - **Representative display name**: Select a value from the list.
   - Turn on the toggles to enable the following options:
     - [Proactive chat](proactive-chat.md)
     - [Reconnect to previous chat](configure-reconnect-chat.md)
     - **Show widget during operation hours**: Select an operating hour setting and optionally select the checkbox to show the widget outside of operation hours. Learn more in [Configure operating hours](create-operating-hours.md).
     - **Only show widget on the provided domains**: Enter the link of the portal.

1. In **Behaviors**, configure the following options:
   - [Custom automated messages](configure-automated-message.md)
   - [Pre-conversation survey](configure-pre-chat-survey.md)
   - [Post-conversation survey](configure-post-conversation-survey.md)
   - [Authentication settings](create-chat-auth-settings.md). The authentication setting is mandatory for persistent chat.
   - Customer wait time: This setting isn't applicable to [persistent chat](persistent-chat.md).
      - **Show position in queue**: Select to show customers their position in the queue when they're waiting to interact with a service representative. Learn more in [Show customers their queue position](show-queue.md).
      - **Show average wait time**: Select to display the average wait time in the queue when customers are waiting to interact with a representative. Learn more in [Show customers their average wait time in a queue](average-wait-time.md).
   - **Customer location detection**: Select a location provider. Learn more in [Set up visitor location detection](geo-location-provider.md).

1. On the **User features** page, configure the following options:
   - [File attachments](enable-file-attachments.md)
   - [Customer notifications](#configure-customer-notifications)
   - [Conversation transcripts](download-email-chat-transcripts.md)
   - **Voice and video calls**: Switch the toggle to **On** and select the calling option.
   - **Screen sharing**: Switch the toggle to **On** and select a provider.
   - **Co-browse**: Turn on the toggle and select a provider if you want the representatives to see and interact with a customer's web browser.

      > [!NOTE]
      > - You must install a non-Microsoft provider from Microsoft Marketplace to use the screen sharing or co-browse feature.
      > - You can select one co-browse provider only and one screen sharing provider for each chat widget. Solutions published on Marketplace only appear in the lists.

1. On **Notifications**, set the **Notifications** toggle to **On** if you intend to re-use this channel in a mobile application with push notifications, and enter your Azure Notification Hub details.

1. On **Review and finish**, review the channel settings, and select **Create channel**.

### Manage modern and classic versions of the widget

If you're an existing user, each chat channel supports both a **Classic** and **Modern** version to help you migrate to the new widget version. You can test each version independently, and set the version that your widget's script tag uses.

You can customize and select the versions on the **Workstream** page where you configure your **Chat** channel.

- **Edit widget configuration**: Select the pencil button next to the **Classic** or **Modern** version to edit the configuration.

- **Copy widget test script**: Select the vertical ellipses next to the **Classic** or **Modern** version, and then select **Copy testing script** to copy the widget script to your clipboard. This script tag, unlike the general script tag, always loads this version of the widget.
- **Set active version**: Select the vertical ellipses next to the **Classic** or **Modern** version, and then select **Set as active** to make the general script tag use the selected version. This action makes the new **Modern** version go live for a script tag you already deployed. You can roll back to the **Classic** version if needed.

## Configure the classic chat widget

1. In the site map of Copilot Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.

1. Select **Manage** for **Chat**. The **Chat channels** page appears.

1. Select **Add chat channel**.

1. Select the **Classic** version.

1. On the **Channel details** page, enter a name and select a language in the **Name** and **Language** fields, respectively.

1. On **Chat Widget**, enter the following details:
   - **Title:** Display name for the chat widget.
   - **Subtitle:** Other title, such as "We're online".
   - **Theme color:** Choose a color from the list.
   - **Logo URL:** Select the default value or enter the link to the logo that you want to be displayed.
   - **Representative display name:** Select a value from the list.
   > [!NOTE]
   > You can customize the chat widget appearance using data tags. Learn more in [Customize live chat widgets using data tags](../develop/customize-chat-widget.md).

   - Turn on the toggle to enable the following options:
     - [Proactive chat](proactive-chat.md)
     - [Reconnect to previous chat](configure-reconnect-chat.md)
     - Only show widget during operation hours
       - **Operation hours name**: Select an operating hour setting. Learn more in [Configure operating hours](create-operating-hours.md).
     - **Only show widget on the provided domains**: Enter the link of the portal.

1. On **Behaviors**, configure the following options:
   - [Custom automated messages](configure-automated-message.md)
   - [Pre-conversation survey](configure-pre-chat-survey.md)
   - [Post-conversation survey](configure-post-conversation-survey.md)
   - [Authentication settings](create-chat-auth-settings.md). The authentication setting is mandatory for persistent chat.
   - Customer wait time: This setting isn't applicable to [persistent chat](persistent-chat.md).
  
      - **Show position in queue:** Select to show customers their position in the queue when they're waiting to interact with a service representative. Learn more in [Show customers their queue position](show-queue.md).
      - **Show average wait time:** Select to display the average wait time in the queue when customers are waiting to interact with a representative. Learn more in [Show customers their average wait time in a queue](average-wait-time.md).
   - **Customer location detection:** Select a location provider. Learn more in [Set up visitor location detection](geo-location-provider.md).

1. On the **User features** page, configure the following options:
   - [File attachments](enable-file-attachments.md)
   - [Customer notifications](#configure-customer-notifications)
   - [Conversation transcripts](download-email-chat-transcripts.md)
   - **Voice and video calls**: Switch the toggle to **On** and select the calling option.
   - **Screen sharing**: Turn on the toggle and select a provider.
   - **Co-browse**: Turn on the toggle and select a provider if you want the representatives to see and interact with a customer's web browser.

      > [!NOTE]
      > - You must install a non-Microsoft provider from Microsoft Marketplace to use the screen sharing or co-browse feature.
      > - You can select one co-browse provider only and one screen sharing provider for each chat widget. Solutions published on Marketplace only appear in the lists.

1. On **Notifications**, set the **Notifications** toggle to **On** if you intend to re-use this channel in a mobile application with push notifications, and enter your Azure Notification Hub details.

1. On **Review and finish**, review the channel settings, and select **Create channel**.

### Configure customer notifications

You can configure visual and sound alerts that customers can receive when they're interacting with representatives using the chat widget on your organization portal. If the chat window is minimized or inactive, the system plays a sound notification when the representative sends a message. The customer also sees a count of the unread messages.

Follow these steps to enable the customer notifications:

1. In Copilot Service admin center, edit a chat widget. On **Chat channel settings**, select the **User features** tab.
1. For **Customer notifications**, turn on the toggle. The following checkboxes are selected:
   - **Show number of new messages**
   - **Play sound notifications for new messages**
1. Keep the default settings or select one of them depending on your requirement.

You can also configure the customer notifications when you're configuring the chat channel.

### Troubleshoot

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
[Supported browsers for live chat widget](/dynamics365/contact-center/implement/system-requirements-contact-center)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
