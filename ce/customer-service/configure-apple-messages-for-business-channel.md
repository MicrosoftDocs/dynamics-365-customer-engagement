---
title: "Configure an Apple Messages for Business channel | MicrosoftDocs"
description: "This article provides steps to configure an Apple Messages for Business channel and corresponding Apple pages in Omnichannel for Customer Service."
ms.date: 04/05/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Configure an Apple Messages for Business channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]


Many customers use the Apple Messages app for their daily communication needs. The Apple Messages app also supports Messages for Business, a new way to apply iMessage's richer communication capabilities to engage with businesses. The asynchronous nature of this channel gives customers the convenience of getting their issues resolved when they find time, in contrast to real-time channels such as Chat for Dynamics 365, where the session ends when the chat window is closed.

Apple Messages for Business supports rich messaging experiences, allowing customer and agents to converse through convenient and engaging interactions. More information: [Introduction to Messages for Business - Apple Developer](https://developer.apple.com/design/human-interface-guidelines/business-chat/overview/introduction/)

## Prerequisites

Before you configure the Apple Messages for Business channel in Dynamics 365 Omnichannel for Customer Service, ensure that the following prerequisites are met:

1. Register your business with Apple Business Register More information: [Apple Business Register](https://register.apple.com/)
1. Enable Messages for Business and create a Messages for Business account for your brand. More information: [Apple Messages for Business Accounts Introduction](https://register.apple.com/resources/messages/messaging-documentation/)
1. Configure the Messaging Service Provider (MSP) using the correct URL provided for your geo-region in the following table.

   | Geo location   | API Endpoint URL|
   |-------------|---------|
   | Asia-Pacific | https://dynamics365-omnichannel-apac.omnichannelengagementhub.com/applemessagesforbusiness |
   | Australia | https://dynamics365-omnichannel-aus.omnichannelengagementhub.com/applemessagesforbusiness |
   | Canada | https://dynamics365-omnichannel-can.omnichannelengagementhub.com/applemessagesforbusiness |
   | Europe | https://dynamics365-omnichannel-eur.omnichannelengagementhub.com/applemessagesforbusiness |
   | France | https://dynamics365-omnichannel-fra.omnichannelengagementhub.com/applemessagesforbusiness |
   | Germany | https://dynamics365-omnichannel-ger.omnichannelengagementhub.com/applemessagesforbusiness |
   | India | https://dynamics365-omnichannel-ind.omnichannelengagementhub.com/applemessagesforbusiness |
   | Japan | https://dynamics365-omnichannel-jpn.omnichannelengagementhub.com/applemessagesforbusiness |
   | North America | https://dynamics365-omnichannel-nam.omnichannelengagementhub.com/applemessagesforbusiness |
   | South America | https://dynamics365-omnichannel-sam.omnichannelengagementhub.com/applemessagesforbusiness |
   | Switzerland | https://dynamics365-omnichannel-che.omnichannelengagementhub.com/applemessagesforbusiness |
   | United Arab Emirates | https://dynamics365-omnichannel-uae.omnichannelengagementhub.com/applemessagesforbusiness |
   | United Kingdom | https://dynamics365-omnichannel-uk.omnichannelengagementhub.com/applemessagesforbusiness | 


## Configure an Apple Messages for Business channel instance in Omnichannel admin center

To add the Apple Messages for Business channel instance, complete the following steps:

1. In the Omnichannel site map, select **Channels** under **General settings**, and then on the **Accounts and channels** page, select **Add account**.

1. On the **Channel details** page, enter a name and select Apple Messages for Business in **Channels**.

1. On the **Add account** page, specify the Apple Messages for Business account ID. To get the account ID, go to your organization's Apple Business Register, open the Messages for Business account, navigate to the Messaging Service Provider configuration and select **Test your Messaging Service Provider connection**, and copy the account ID by selecting **Copy ID**.
   > [!Note]
   > If your organization uses Customer-managed keys, be aware that Apple Messages for Business acount IDs cannot be encryped. Apple Messages for Business account IDs are part of the URLs used by customer devices to start new conversations and may be visible to users, but this doesn't present a security concern.

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you've created for the Apple Messages for Business channel and on the workstream page, select **Set up Apple Messages for Business**, and do the following steps:<br>

     1. In the **Available Apple Messages for Business accounts** area, select an account from the list.<br>
      
     1. On the **Language** page, select the language to use.<br>
      
     1. On the **Behaviors** page, configure the following options:<br>
        - **Custom automated messages**<br>
        - [**Post-conversation survey**](configure-post-conversation-survey.md)<br>
        - **Authentication settings:** If you enable authentication, your agents will be able to request customer's authenticate their identity. You must associate a channel specific authentication setting. This step may be completed later, after channel setup. There are two flows to choose from: OAuth 2.0 code flow or OAuth 2.0 OpenID connect flow. More information: [Authentication settings for Apple Messages for Business](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business).<br>
     
      1. On the **User features** page, configure the following options:<br>
           - **File attachments:** When set to yes for both customer and agent, customers and agents can send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md).<br>
           - **Apple Pay:** If you enable Apple Pay, your agents will be able to send Apple Pay requests to customers. Each channel instance must have a Payment Profile associated. This step may be completed later, after channel setup. More information: [Payment Profiles]().<br>
        
      1. Review the **Summary** page, and then select **Create**. The channel instance is configured.
        
1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md)

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Optionally, you can add a bot. Skip this step if your conversations are handled by human agents only. More information: [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream)

1. In **Advanced settings**, configure the following options based on your business needs:<br>
      - [Sessions](../app-profile-manager/session-templates.md)<br>
      - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)<br>
      - [Context variables](manage-context-variables.md#add-context-variables)<br>
      - [Smart assist bots](smart-assist-bot.md)<br>
      - [Quick replies](create-quick-replies.md)<br>
      - [Rich messages](create-rich-messages.md)<br>

## Configure authentication settings

Perform the steps in [Create Apple Messages for Business authentication settings](create-chat-auth-settings.md#create-authentication-settings-for-apple-messages-for-business) to configure authentication settings.

## Configure payment profiles for Apple Pay

Perform the steps in [Configure payment profiles](configure-payment-profiles.md) to configure the profile.

## Create rich messages

Perform the steps in [Create rich messages](create-rich-messages.md) to create rich messages 

## Use rich messages in conversation control

Perform the steps in [Rich messages in the conversation control](rich-messages-conversation-control.md) to use the rich messages.

### See also

[Understand and create workstreams](work-streams-introduction.md)  
[Create and manage routing rules](routing-rules.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
