---
title: Overview of SMS channels
description: This article gives an overview of the SMS channels and how you can configure them. 
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim 
ms.topic: overview 
ms.date: 02/17/2023
ms.custom: bap-template 
---

# Overview of SMS channels

The SMS channel in Omnichannel for Customer Service allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate agent. Agents can view incoming SMS requests on their dashboard and respond accordingly. While agents can't send messages, Omnichannel for Customer Service supports outbound messaging via Power Automate flows. More information: [Configure outbound messaging](outbound-messaging.md) 

You can use the same phone number for the SMS channel, and for inbound and outbound calling in the voice channel. SMS is currently only available in US, Canada, and Puerto Rico. For detailed information about numbers and eligibility, see [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

For best SMS delivery experience, we recommend that you submit a toll-free verification application for your toll-free numbers. More information: [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification)

## Prerequisite

You must obtain an active subscription of **Dynamics 365 Customer Service Digital Messaging**. For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true)

## Supported SMS channels

In Omnichannel for Customer Service, you can configure the SMS channel as follows:
- Configure SMS channel using Azure Communication Services
- Configure SMS channel for Twilio
- Configure SMS channel for TeleSign

> [!NOTE]
> SMS isn't supported with Azure direct routing. More information: [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

## Next steps

[Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](configure-sms-channel-twilio.md)  
[Configure SMS channel for TeleSign](configure-sms-channel.md)  

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

