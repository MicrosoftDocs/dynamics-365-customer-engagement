---
title: Overview of SMS channels
description: Learn more about SMS channels and how to configure them so that service representatives can better assist their customers. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: overview 
ms.date: 02/21/2025
ms.custom: bap-template 
---

# Overview of SMS channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The SMS channel in the application allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate customer service representative (service representative or representative). Service representatives can view incoming SMS requests on their dashboard and respond accordingly. While service representatives can't send messages, the application supports outbound messaging via Power Automate flows. More information: [Configure outbound messaging](../administer/outbound-messaging.md)

The following scenarios are supported for SMS:

- Service representatives can receive SMS conversations from customers and then exchange messages.
- Admins can configure Power Automate flows to proactively send outbound messages, such as campaigns, to customers

Service representatives can't proactively reach out to customers by starting an SMS conversation in the service representative UI.

You can use the same toll-free phone number from Azure Communications Services for the SMS channel, and for inbound and outbound calling in the voice channel. The toll-free SMS is currently available in United States, Canada, and Puerto Rico only. The Azure Communication Services-based short codes for the SMS channel are available in United States, Canada, and United Kingdom. For detailed information about numbers and eligibility, see [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

For best SMS delivery experience, we recommend that you submit a toll-free verification application for your toll-free numbers. More information: [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification)

## Prerequisite

You must obtain an active subscription of **Dynamics 365 Customer Service Digital Messaging**. Learn about licenses and pricing in [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). Learn about how to [buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true).

## Supported SMS channels

In the application, you can configure the following SMS channels:
- SMS channel using Azure Communication Services
- SMS channel for Twilio

> [!NOTE]
> SMS isn't supported with Azure direct routing. More information: [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

## Next steps

[Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](Configure-sms-channel-twilio.md)    

### Related information

[Channels](../use/channels.md)  
[SMS FAQ](faqs.md#sms)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

