---
title: Overview of SMS channels
description: Set up SMS messaging channels for your service representatives in Dynamics 365 Contact Center using Azure Communication Services or Twilio. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: overview 
ms.date: 08/01/2025
ms.custom: bap-template 
---

# Overview of SMS channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The SMS channel in the application allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate customer service representative (service representative or representative). Service representatives can view incoming SMS requests on their dashboard and respond accordingly. While service representatives can't send messages, the application supports outbound messaging via Power Automate flows. Learn more in [Configure outbound messaging](../administer/outbound-messaging.md).

The following scenarios are supported for SMS:

- Service representatives can receive SMS conversations from customers and then exchange messages.
- Admins can configure Power Automate flows to proactively send outbound messages such as campaigns to customers.

Service representatives can't proactively reach out to customers by starting an SMS conversation in the app used by the representatives.

You can use the same toll-free phone number from Azure Communications Services for the SMS channel, and for inbound and outbound calling in the voice channel.

Learn more about numbers and eligibility in [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

For the best SMS delivery experience, we recommend that you submit a toll-free verification application for your toll-free numbers. Learn more about the verification process in [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification).

## Supported SMS channels

In the application, you can configure the following SMS channels:

- SMS channel using Azure Communication Services
- SMS channel for Twilio

> [!NOTE]
> SMS isn't supported with Azure direct routing. Learn more in [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing).

## Next steps

[Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)    

### Related information

[Channels](../use/channels.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

