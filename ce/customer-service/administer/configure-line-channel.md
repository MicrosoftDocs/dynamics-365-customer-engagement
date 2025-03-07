---
title: Configure a LINE channel
description: Instructions to configure a LINE channel.
ms.date: 03/03/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure a LINE channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Many customers use social messaging channels like LINE for their personal communication needs. Many also prefer using these messaging channels to engage with businesses. The asynchronous nature of these channels gives customers the convenience of getting their issues resolved when they have time. This functionality is different from real-time channels like Chat for Dynamics 365 Customer Service, where the session ends when the chat window is closed.

The LINE channel gives you an opportunity to capitalize on the social media trend and engage with your customers in a seamless and personalized experience.

## Prerequisites

The prerequisites to configure the LINE channel in Contact Center admin center or Customer Service admin center are as follows:

1.	Create a [LINE](https://line.me/en/) handle.
2.	Create a LINE channel in the LINE Developers console. For more information, refer to [Create a LINE channel](https://developers.line.biz/en/docs/messaging-api/getting-started/#creating-a-channel).

After completing the prerequisites, you can add the LINE channel for your organization by following these steps:

1.	Create a LINE channel.
2.	Create routing rules.

## Create a LINE channel

**To configure the LINE channel**

1. In the site map of Contact Center admin center or Customer Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
1. Select **New account**.
    
1. Enter the following details:
   
   1. On the **Channel details** page, enter a name and select **LINE** in **Channel**.
   
   1. On the **Account details** page, enter the following details:
      - **Channel ID:** ID of the LINE application. Go to the [LINE developer portal](https://developers.line.biz/console/) > **Provider** > **Channel** (ensure that it's a Messaging API) > **Basic settings**, and then copy the value in the **Channel ID** box.
      - **Channel secret:** Application secret of the LINE application. Go to the [LINE developer portal](https://developers.line.biz/console/) > **Provider** > **Channel** (ensure that it's a Messaging API) > **Basic settings**, and then copy the value in the **Channel secret** box.
      - **Channel access token:** Token of the LINE application. Go to the [LINE developer portal](https://developers.line.biz/console/) > **Provider** > **Channel** (ensure that it's a Messaging API) > **Messaging API**, and then copy the value in the **Channel access token (long-lived)** box.
   
   1. On the **Callback information** page, copy the text in the **Callback URL** box. You use the copied information in the LINE account.
   1. Select **Done**.
1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you created for the LINE channel and on the workstream page, select **Set up LINE**, and configure the following options:
   1. On the **LINE** page, select an account from **Available LINE accounts**.
   
   1. On the **Language** page, select a language.
   
   1. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [Post-conversation survey](configure-post-conversation-survey.md)
   
   1. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow customer service representatives (service representatives or representatives) and customers to send and receive file attachments. For more information, refer to [Enable file attachments](enable-file-attachments.md).
      - Customers can send file attachments.
      - Service representatives can send file attachments.
   1. Verify the settings on the **Summary** page, and select **Finish**. The LINE channel instance is configured.

1. Configure routing rules. For more information, refer to [Configure work classification](configure-work-classification.md).

1. Configure work distribution. For more information, refer to [Work distribution settings](create-workstreams.md#configure-work-distribution).

1. Add a bot. For more information, refer to [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Customer and representative experiences

A customer can start a conversation in any of the following ways:

- LINE app on a mobile device
- LINE app on a desktop device
- [line.me/en/](https://line.me/en/)

If a customer starts a conversation from the LINE website and then later switches to the mobile device, the previous conversation persists and the customer can continue the conversation.

The representative receives the notification of the incoming chat request, along with customer details. For more information, refer to [View notifications](../use/oc-notifications.md).

After the system links the LINE social profile to a customer or contact record by the representative, subsequent LINE conversations are linked to the customer records, and then the customer summary is populated.

If the system doesn't identify the customer by name, a new contact record can be created.

## Privacy notice

If you enable this feature, your data is shared with LINE and flows outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud environment). For more information, refer to [Connect an agent to LINE](/azure/bot-service/bot-service-channel-connect-line?view=azure-bot-service-4.0&preserve-view=true).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws related to monitoring, recording, and storing communications with their end users. This responsibility includes adequately notifying end users that their communications with representatives might be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their representatives that their communications with end users may be monitored, recorded, or stored.

### Related information

[Understand and create workstreams](create-workstreams.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
