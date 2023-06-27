---
title: Configure an SMS channel using Azure Communication Services | MicrosoftDocs
description: This article includes instructions for configuring an SMS channel using Azure Communication Services.
ms.date: 06/20/2023
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
ms.custom: bap-template
---

# Configure an SMS channel using Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article discusses how you can configure an SMS channel using Azure Communication Services.

## Prerequisites

- Purchase and install the voice channel for Dynamics 365 Customer Service. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md) and [Install voice channel](voice-channel-install.md)
- Connect to Azure Communication Services. More information: [Connect to Azure Communication Services](voice-channel-acs-resource.md)
  
   If you’ve connected your existing Azure resource, ensure that you’ve enabled SMS services. More information: [Enable call recording and SMS services](voice-channel-connect-existing-resource.md#enable-call-recording-and-sms-services)
- Set up a phone number that's enabled for SMS services. Ensure that you select **Send SMS** or **Send and receive SMS** options when you choose your phone number features in Customer Service admin center or Omnichannel admin center. More information: [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)
   
    If you're using an existing phone number that's not enabled for SMS, then you can upgrade your plan. More information: [Edit phone numbers](voice-channel-manage-phone-numbers.md#edit-phone-numbers)

## Configure a workstream for the SMS channel

1. Go to the **Workstreams** page, and open the workstream that you created.
1. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options.
   1. On the **SMS setup** page, select a number from the list.
   2. On the **Language** page, select the language that you want to set as the default.
   3. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. More information: [Configure operating hours](create-operating-hours.md)
     - [Configure custom automated messages](configure-automated-message.md).
     - [Configure post-conversation survey](configure-post-conversation-survey.md).
          > [!NOTE]
          > File attachments aren't supported in the SMS channel using Azure Communication Services. <br>
   4. Verify the settings on the **Summary** page, and then select **Finish**. The SMS channel is now configured.
1. [Configure routing rules](configure-work-classification.md).
1. [Configure work distribution](create-workstreams.md#configure-work-distribution).
1. [Add a bot](create-workstreams.md#add-a-bot-to-a-workstream).
1. In **Advanced settings**, configure the following options based on your business needs.
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

## Next steps

[Create message templates](create-message-templates.md)  


### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Overview of SMS channels](sms-channel-overview.md)  
[Understand and create workstreams](create-workstreams.md)  
[Configure SMS channel for Twilio](configure-sms-channel-twilio.md)  
[Configure SMS channel for TeleSign](configure-sms-channel.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
