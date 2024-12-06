---
title: Configure an SMS channel using Azure Communication Services
description: This article includes instructions for configuring an SMS channel using Azure Communication Services.
ms.date: 08/29/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Configure an SMS channel using Azure Communication Services

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

This article discusses how you can configure an SMS channel using Azure Communication Services.

## Prerequisites

- Purchase and install the voice channel for Dynamics 365 Customer Service. For more information, refer to [Provision Omnichannel for Customer Service](/dynamics365/contact-center/implement/provision-channels) and [Install voice channel](voice-channel-install.md)

- Connect to Azure Communication Services. For more information, refer to [Connect to Azure Communication Services](voice-channel-acs-resource.md)
  
  If you connected your existing Azure Communication Services resource, ensure that you enabled SMS services. For more information, refer to [Enable call recording and SMS services](voice-channel-configure-services.md).

- Set up a phone number and enable it for SMS services. Ensure that you select **Send SMS** or **Send and receive SMS** options when you choose your phone number feature in Customer Service admin center. For more information, refer to [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)

  If you're using an existing phone number that isn't enabled for SMS, then you can upgrade your plan. For more information, refer to [Edit phone numbers](voice-channel-manage-phone-numbers.md#edit-phone-numbers)

## Configure a workstream for the SMS channel

1. Go to the **Workstreams** page, and open the workstream that you created.
1. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options.
   1. On the **SMS setup** page, select a number from the list.
   1. On the **Language** page, select the language that you want to set as the default.
   1. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. For more information, refer to: [Configure operating hours](create-operating-hours.md)
     - [Configure custom automated messages](configure-automated-message.md).
     - [Configure post-conversation survey](configure-post-conversation-survey.md).
          > [!NOTE]
          > File attachments aren't supported in the SMS channel using Azure Communication Services. <br>
   
   1. Verify the settings on the **Summary** page, and then select **Finish**. The SMS channel is now configured.
1. [Configure routing rules](configure-work-classification.md).
1. [Configure work distribution](create-workstreams.md#configure-work-distribution).
1. [Add a bot](create-workstreams.md#add-a-bot-to-a-workstream).
1. In **Advanced settings**, configure the following options based on your business needs.
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Next steps

[Create message templates](create-message-templates.md)  

### Related information

[Overview of channels](../use/channels.md)  
[Overview of SMS channels](../use/sms-channel-overview.md)  
[Understand and create workstreams](create-workstreams.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)   
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](../use/channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
