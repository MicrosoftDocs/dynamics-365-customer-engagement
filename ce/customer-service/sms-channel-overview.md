---
title: Overview of SMS channels template #Required; page title displayed in search results. Don't enclose in quotation marks.
description: This article gives an overview of the SMS channels and how you can configure them. #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: mh-jaya
ms.author: v-jmh
ms.reviewer: nenellim #Required; Microsoft alias of content publishing team member.
ms.topic: overview #Required; don't change.
ms.date: 02/08/2023
ms.custom: bap-template #Required; don't change.
---

# What is the SMS channel?

The SMS channel in Omnichannel for Customer Service allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate agent. Agents can view incoming SMS requests on their dashboard and respond accordingly. While agents can't send messages, Omnichannel for Customer Service supports outbound messaging via Power Automate flows. More information: [Configure outbound messaging](outbound-messaging.md) 

You can use the same phone number for the SMS channel, and for inbound and outbound calling in the voice channel. For best SMS delivery experience, we recommend that you submit a toll-free verification application for your toll-free numbers. More information: [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification)

> [!NOTE]
> SMS isn't supported with Azure direct routing. More information: [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

## Supported SMS channels

Omnichannel for Customer Service lets you configure SMS channels as follows:
- Configure SMS channel using Azure Communication Services
- Configure SMS channel for Twilio
- Configure SMS channel for TeleSign



## Next steps

[Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](configure-sms-channel-twilio.md)  
[Configure SMS channel for TeleSign](configure-sms-channel.md)  

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

