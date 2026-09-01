---
title: Configure an Apple Messages for Business channel
description: Configure an Apple Messages for Business channel and related features in Copilot Service admin center.
ms.date: 08/31/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure an Apple Messages for Business channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

> [!IMPORTANT]
> As of July 17, 2026, the Apple Messages for Business channel is deprecated. This article will be removed after September 30, 2026. For more information, review [Deprecations in Dynamics 365 Customer Service](../implement/deprecations-customer-service.md#apple-messages-for-business-channel-is-deprecated).

Many customers use the Apple Messages app for everyday communication. Dynamics 365 Customer Service supports integration with Apple Messages for Business, allowing organizations to engage with customers through an asynchronous messaging channel. This channel gives customers the flexibility to respond at their convenience, unlike real-time channels such as Chat for Dynamics 365, where sessions end when the chat window closes.

After you configure the channel, conversations can include rich messaging features provided by Apple, such as file sharing and interactive elements. Apple Messages for Business supports rich messaging experiences, allowing customers and customer service representatives (service representatives or representatives) to communicate through convenient and engaging interactions. Learn about Apple's capabilities in the [Messages for Business documentation](https://register.apple.com/resources/messages/messaging-documentation/end-to-end).

## Prerequisites

Before you configure the Apple Messages for Business channel in Dynamics 365, complete the [Apple Messages for Business onboarding process](https://register.apple.com/resources/messages/messaging-documentation/):

1. Register your business in Apple Business Register.
1. Create a Messages for Business account and select **Microsoft Dynamics 365** as your Messaging Service Provider (MSP).

After you register and receive your Messages for Business account ID, contact Microsoft Support and request that they complete the Apple Messages for Business account onboarding procedure. Provide your account ID so Microsoft can verify the MSP selection and finalize the configuration. The channel doesn't work until Microsoft completes this step.

## Configure an Apple Messages for Business channel instance

1. In the site map of Copilot Service admin center, select **Channels** in **Customer Support**.

1. Go to **Accounts** > **Messaging accounts** > **Manage**, and then on the **Accounts and channels** page, select **Add account**.

1. In the **Channel details** section of the **Add account** page, enter a name, and then select **Apple Messages for Business** in **Channels**.

1. Specify the Apple Messages for Business account ID. To get the account ID, go to your organization's Apple Business Register, open the Messages for Business account, go to the Messaging Service Provider configuration, select **Test your Messaging Service Provider connection**, and then select **Copy ID**.

   > [!NOTE]
   > If your organization uses customer-managed keys, Apple Messages for Business account IDs can't be encrypted. The account IDs are part of the URLs that customer devices use to start conversations and might be visible to users. This visibility isn't considered a security concern.

1. To configure routing and work distribution, either create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream for the Apple Messages for Business channel, and then select **Set up Apple Messages for Business**. Complete the following pages:<br>

   1. In **Available Apple Messages for Business accounts**, select an account.<br>

   1. On the **Language** page, select the language to use.<br>

   1. On the **Behaviors** page, configure the following options:<br>
      - **Custom automated messages**<br>
      - [**Post-conversation survey**](configure-post-conversation-survey.md)<br>
      - **Authentication settings**: To let service representatives request customer authentication, associate a channel-specific authentication setting. You can complete this step after channel setup. Use the OAuth 2.0 OpenID Connect flow. Learn more in [Authentication settings for Apple Messages for Business](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business).<br>

   1. On the **User features** page, configure the following options:<br>
      - **File attachments**: When set to **Yes** for both the customer and representative, they can send and receive file attachments. Learn more in [Enable file attachments](enable-file-attachments.md).<br>
      - **Apple Pay**: When enabled, representatives can send Apple Pay requests to customers. Each channel instance must have an associated payment profile. You can complete this step after channel setup. Learn more in [Configure payment profiles](configure-payment-profiles.md).<br>

   1. Review the **Summary** page, and then select **Create**.

1. Configure routing rules. Learn more in [Configure work classification](configure-work-classification.md).

1. Configure work distribution. Learn more in [Work distribution settings](create-workstreams.md#configure-work-distribution).

1. Optionally, add an AI agent. Skip this step if representatives handle the conversations. Learn more in [Configure an AI agent](create-workstreams.md#add-an-agent-to-a-workstream).

1. In **Advanced settings**, configure the following options based on your business needs:<br>
   - [Sessions](session-templates.md)<br>
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)<br>
   - [Context variables](manage-context-variables.md#add-context-variables)<br>
   - [Smart assist bots](../develop/smart-assist-bot.md)<br>
   - [Quick replies](create-quick-replies.md)<br>
   - [Rich messages](create-rich-messages.md)<br>

The following video shows how to set up the Apple Messages for Business channel in Dynamics 365 Customer Service.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=3c70bbde-4bb0-4139-a329-645f457acf74]

## Configure authentication settings

Complete the steps in [Create Apple Messages for Business authentication settings](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business).

## Configure payment profiles for Apple Pay

Complete the steps in [Configure payment profiles](configure-payment-profiles.md).

## Create rich messages

Complete the steps in [Create rich messages](create-rich-messages.md).

## Use rich messages in conversation control

Review [Rich messages in the conversation control](../use/rich-messages-conversation-control.md).

The following video walks through a conversation on the Apple Messages for Business channel in Dynamics 365 Customer Service.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=b17f16e2-396e-4296-aa7a-97273d439756]

### Related information

[Create and manage workstreams](create-workstreams.md#create-and-manage-workstreams)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
