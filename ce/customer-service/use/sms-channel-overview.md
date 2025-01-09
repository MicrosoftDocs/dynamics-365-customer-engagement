---
title: Overview of SMS channels
description: Learn more about SMS channels and how to configure them so that service representatives can better assist their customers. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: overview 
ms.date: 10/09/2024
ms.custom: bap-template 
---

# Overview of SMS channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The SMS channel in the application allows your organization to connect to customers via text messages. Your customers can send text messages and connect with an appropriate service representative. Service represenatives can view incoming SMS requests on their dashboard and respond accordingly. While service representatives can't send messages, the application supports outbound messaging via Power Automate flows. More information: [Configure outbound messaging](../administer/outbound-messaging.md)

The following scenarios are supported for SMS:

- Service representatives can receive SMS conversations from customers and then exchange messages.
- Admins can configure Power Automate flows to proactively send outbound messages, such as campaigns, to customers

Service representatives can't proactively reach out to customers by starting an SMS conversation in the service representative UI.

You can use the same phone number for the SMS channel, and for inbound and outbound calling in the voice channel. SMS is currently only available in US, Canada, and Puerto Rico. For detailed information about numbers and eligibility, see [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability).

For best SMS delivery experience, we recommend that you submit a toll-free verification application for your toll-free numbers. More information: [How do I submit a toll-free verification?](/azure/communication-services/concepts/sms/sms-faq#toll-free-verification)

## Prerequisite

You must obtain an active subscription of **Dynamics 365 Customer Service Digital Messaging**. For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true)

## Supported SMS channels

In the application, you can configure the SMS channel as follows:
- Configure SMS channel using Azure Communication Services
- Configure SMS channel for Twilio

> [!NOTE]
> SMS isn't supported with Azure direct routing. More information: [Azure direct routing](/azure/communication-services/concepts/telephony-sms/telephony-concept#azure-direct-routing)

## Next steps

[Configure an SMS channel using Azure Communication Services](../administer/configure-sms-channel-acs.md)  
[Configure SMS channel for Twilio](../administer/Configure-sms-channel-twilio.md)    

### Related information

[Channels](channels.md)  
[SMS FAQ](../administer/faqs.md#sms)  
[Support for live chat and asynchronous channels](../administer/card-support-in-channels.md)  

