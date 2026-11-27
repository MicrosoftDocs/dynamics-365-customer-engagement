---
title: Overview of SMS channels
description: Set up SMS messaging channels for your service representatives in Dynamics 365 Contact Center using Azure Communication Services or Twilio. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: overview 
ms.date: 11/26/2026
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Overview of SMS channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use the SMS channel to connect customers with customer service representatives (service representatives or representatives) through text messages. Representatives can view incoming SMS requests on their dashboard and respond. While service representatives can't send messages, the application supports outbound messaging through Power Automate flows. Learn more in [Configure outbound messaging](../administer/outbound-messaging.md).

The SMS channel supports the following scenarios:

- Service representatives can receive SMS conversations from customers and then exchange messages.
- Administrators can configure Power Automate flows to send outbound messages, such as campaigns, to customers.

Service representatives can't start an SMS conversation with a customer in the app.

You can use the same Azure Communication Services toll-free phone number for SMS and for inbound and outbound calls in the voice channel.

Learn more about numbers and eligibility in [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

For the best SMS delivery experience, submitting a toll-free verification application for your toll-free numbers is recommended. Learn more in [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification).

## Supported SMS channels

You can configure the following SMS channels:

- SMS channel using Azure Communication Services.
- SMS channel for Twilio.
- SMS channel for Infobip.

> [!NOTE]
> SMS isn't supported with Azure direct routing. Learn more in [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing).

## Next steps

[Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)  
[Configure SMS channel for Infobip](/dynamics365/contact-center/administer/configure-sms-channel-infobip)  

## Related information

[Channels](../use/channels.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

