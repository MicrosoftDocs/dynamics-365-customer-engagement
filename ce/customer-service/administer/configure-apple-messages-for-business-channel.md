---
title: Configure an Apple Messages for Business channel
description: This article provides steps to configure an Apple Messages for Business channel and Apple pages in the admin center.
ms.date: 11/08/2024
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure an Apple Messages for Business channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Many customers use the Apple Messages app for their daily communication needs. The Apple Messages app also supports Messages for Business, a way to apply iMessage's richer communication capabilities to engage with businesses. The asynchronous nature of this channel gives customers the convenience of resolving their issues when they find time, in contrast to real-time channels such as Chat for Dynamics 365, where the session ends when the chat window is closed.

Apple Messages for Business supports rich messaging experiences, allowing customers and agents to converse through convenient and engaging interactions. Learn more at [Introduction to Messages for Business - Apple Developer](https://developer.apple.com/design/human-interface-guidelines/messages-for-business).

> [!IMPORTANT]
> Apple requires that you complete a mandatory [onboarding process](https://go.microsoft.com/fwlink/?linkid=2296920) before you can configure the Apple Messages for Business channel. To get started, contact Microsoft support.

## Prerequisites

Before you configure the Apple Messages for Business channel in Contact Center admin center or Customer Service admin center, ensure that the following prerequisites are met:

1. Register your business with Apple Business Register. Learn more at [Apple Business Register](https://register.apple.com/)
1. Enable Messages for Business and create a Messages for Business account for your brand. Learn more at [Apple Messages for Business Accounts Introduction](https://register.apple.com/resources/messages/messaging-documentation/)
1. Configure the Messaging Service Provider (MSP) using the URL provided for your geo region in the following table.

   | Geo location   | API Endpoint URL|
   |-------------|---------|
   | Asia-Pacific |  ```https://dynamics365-omnichannel-apac.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Australia | ```https://dynamics365-omnichannel-aus.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Canada | ```https://dynamics365-omnichannel-can.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Europe | ```https://dynamics365-omnichannel-eur.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | France | ```https://dynamics365-omnichannel-fra.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Germany | ```https://dynamics365-omnichannel-ger.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | India | ```https://dynamics365-omnichannel-ind.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Japan | ```https://dynamics365-omnichannel-jpn.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | North America | ```https://dynamics365-omnichannel-nam.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | South America | ```https://dynamics365-omnichannel-sam.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | Switzerland | ```https://dynamics365-omnichannel-che.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | United Arab Emirates | ```https://dynamics365-omnichannel-uae.omnichannelengagementhub.com/applemessagesforbusiness``` |
   | United Kingdom | ```https://dynamics365-omnichannel-uk.omnichannelengagementhub.com/applemessagesforbusiness``` | 


## Configure an Apple Messages for Business channel instance

1. In the site map of Contact Center admin center or Customer Service admin center, select **Channels** in **Customer Support**.

1. Go to **Accounts** > **Messaging accounts** > **Manage**, and then on the **Accounts and channels** page, select **Add account**.

1. On the **Add account** page, **Channel details** section, enter a name, and then select **Apple Messages for Business** in **Channels**.

1. On the **Add account** page, specify the Apple Messages for Business account ID. To get the account ID, go to your organization's Apple Business Register, open the Messages for Business account, navigate to the Messaging Service Provider configuration and select **Test your Messaging Service Provider connection**, and then copy the account ID by selecting **Copy ID**.
   > [!Note]
   > If your organization uses customer-managed keys, be aware that Apple Messages for Business acount IDs can't be encrypted. Apple Messages for Business account IDs are part of the URLs used by customer devices to start new conversations and might be visible to users. The visibility isn't considered a security concern.

1. To configure routing and work distribution, either create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you created for the Apple Messages for Business channel, and then on the workstream page, select **Set up Apple Messages for Business** and do the following steps:<br>

     1. In the **Available Apple Messages for Business accounts** area, select an account from the list.<br>
      
     1. On the **Language** page, select the language to use.<br>
      
     1. On the **Behaviors** page, configure the following options:<br>
        - **Custom automated messages**<br>
        - [**Post-conversation survey**](configure-post-conversation-survey.md)<br>
        - **Authentication settings:** If you enable authentication, your agents can request that their customers authenticate their identities. You must associate a channel-specific authentication setting. This step may be completed later, after channel setup. Use the OAuth 2.0 OpenID connect flow. Learn more at [Authentication settings for Apple Messages for Business](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business).<br>
     
      1. On the **User features** page, configure the following options:<br>
           - **File attachments:** When set to yes for both customer and agent, customers and agents can send and receive file attachments. Learn more at [Enable file attachments](enable-file-attachments.md).<br>
           - **Apple Pay:** If you enable Apple Pay, your agents can send Apple Pay requests to customers. Each channel instance must have a payment profile associated. This step may be completed later, after channel setup. Learn more at [Configure payment profiles](configure-payment-profiles.md).<br>
        
      1. Review the **Summary** page, and then select **Create**. The channel instance is configured.
        
1. Configure routing rules. Learn more at [Configure work classification](configure-work-classification.md)

1. Configure work distribution. Learn more at [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Optionally, you can add a bot. Skip this step if human agents handle your conversations. Learn more at [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream)

1. In **Advanced settings**, configure the following options based on your business needs:<br>
      - [Sessions](session-templates.md)<br>
      - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)<br>
      - [Context variables](manage-context-variables.md#add-context-variables)<br>
      - [Smart assist bots](../develop/smart-assist-bot.md)<br>
      - [Quick replies](create-quick-replies.md)<br>
      - [Rich messages](create-rich-messages.md)<br>

The following video provides information on how to set up the Apple Messages for Business channel in Dynamics 365 Customer Service.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=3c70bbde-4bb0-4139-a329-645f457acf74]

## Configure authentication settings

Configure the authentication settings by performing the steps in [Create Apple Messages for Business authentication settings](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business).

## Configure payment profiles for Apple Pay

Set up the profile by completing the steps in [Configure payment profiles](configure-payment-profiles.md).

## Create rich messages

Create rich messages by completing the steps in [Create rich messages](create-rich-messages.md). 

## Use rich messages in conversation control

Learn more at [Rich messages in the conversation control](../use/rich-messages-conversation-control.md).

The following video provides information on how to view a conversation on the Apple Messages for Business channel in Dynamics 365 Customer Service.

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
