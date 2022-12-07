---
title: "Configure an SMS channel using Azure Communication Services | MicrosoftDocs"
description: "Use this article to get instructions for configuring an SMS channel in Omnichannel for Customer Service using Azure Communication Services."
ms.date: 10/06/2022
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Configure an SMS channel using Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The SMS channel in Omnichannel for Customer Service allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate customer service agent. Agents can view incoming SMS requests on their dashboard and respond accordingly. You can use the same phone number for the SMS channel, and for inbound and outbound calling in the voice channel.

> [!NOTE]
>
> - SMS is currently available for toll-free numbers in the United States only, and only works for inbound communication. Outbound (agent-initiated) SMS is not currently supported.
> - For best SMS delivery experience, please submit a [verification application](https://aka.ms/TollFreeVerification) for your toll-free numbers. [Learn more.](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification) 
> - SMS is not supported with Azure direct routing. More information: [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

## Prerequisites

- Voice Channel for Dynamics 365 Customer Service must be purchased and installed.
- Connect to Azure Communication Services. More information: [Connect to Azure Communication Services](voice-channel-acs-resource.md)
  
   If you’ve connected your existing Azure resource, ensure that you’ve enabled SMS services. More information: [Enable call recording and SMS services](voice-channel-connect-existing-resource.md#enable-call-recording-and-sms-services)
- Set up a phone number that's enabled for SMS services. Ensure that you select **Send SMS** or **Send and receive SMS** options when you choose your phone number features in Customer Service admin center or Omnichannel admin center. More information: [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)
   
    If you're using an existing phone number that's not enabled for SMS, then you can upgrade your plan. More information: [Edit phone numbers](voice-channel-manage-phone-numbers.md#edit-phone-numbers)

## Configure the workstream for the SMS channel

[Create a workstream for the SMS channel](create-workstreams.md), and then perform the following steps.

1. Go to the **Workstreams** page, and open the workstream that you created.
2. In the **Set up your SMS channel** section, select **Set up SMS**, and then configure the following options.
   1. On the **SMS setup** page, select a number from the list.
   2. On the **Language** page, select the language that you want to set as the default.
   3. On the **Behaviors** page, configure the following options:
     - **Channel operation hours:** Set the toggle to **On**, and then select an operating hour record. More information: [Configure operating hours](create-operating-hours.md)
     - [Configure custom automated messages](configure-automated-message.md).
     - [Configure post-conversation survey](configure-post-conversation-survey.md).
   4. On the **User features** page, turn on the **File attachments** toggle and select the following options for file exchange.
     - **Customers can send file attachments**
     - **Agents can send file attachments**<br>
        For information about file attachments, see [Configure file attachment](configure-file-attachment.md).
   5. Verify the settings on the **Summary** page, and then select **Finish**. The SMS channel is now configured.
3. [Configure routing rules](configure-work-classification.md).
4. [Configure work distribution](create-workstreams.md#configure-work-distribution).
5. [Add a bot](create-workstreams.md#add-a-bot-to-a-workstream).
6. In **Advanced settings**, configure the following options based on your business needs.
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Understand and create workstreams](create-workstreams.md)  
[Create and manage routing rules](routing-rules.md)  
[Configure SMS channel for Twilio](configure-sms-channel-twilio.md)  
[Configure SMS channel for TeleSign](configure-sms-channel.md)  
[Delete a configured channel](delete-channel.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
