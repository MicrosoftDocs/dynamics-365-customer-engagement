---
title: Overview of channels in Omnichannel for Customer Service
description: Learn about the different channels that are available in Omnichannel for Customer Service and the licenses required to use them.
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.topic: conceptual
ms.collection:
ms.date: 10/09/2024
ms.custom: bap-template
---

# Overview of channels

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

As new social networks and communication channels rapidly evolve, so do customer expectations on how to reach their favorite brands. Communication via many channels isn't only comfortable but expected, and businesses that seek to provide personalized services are rapidly working to enable support through the channels their customers want to use. 

Adding channels to your business support offering is a powerful way to provide personalized service to customers on the channels of their choice. It's helpful to recognize a common pattern across all channels that are enabled through the application before diving into the implementation of a single channel.

The implementation pattern for the out-of-the-box channels is as follows:

- Establish your account and respective requirements, such as a page and app, with the channel provider. These requirements ensure that you have an entry point with the channel provider through which customers engage.
- Configure the [workstream](../implement/cs-admin-center.md).
- Configure the channel in Customer Service admin center or Contact Center admin center and attach it to the workstream.
- Populate the exchange of handshake data, such as token and secrets required between the application and the channel provider. The data exchange is done in both places: the Customer Service admin center app and the channel provider experience. 

## License requirements

An active subscription of Digital Messaging Add-in is required for SMS, social channels, Microsoft Teams, and custom messaging. Apart from Dynamics 365 subscriptions, if you choose to use any third-party channels, you need to acquire subscriptions from those providers as well.

You can get Chat with the following add-on licenses:

- [Chat for Dynamics 365](https://dynamics.microsoft.com/customer-service/overview/#pricing)
- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/#pricing)

> [!Note]
> The Digital Messaging Add-in license includes Chat for Dynamics 365 Customer, SMS, Facebook, and bot integration.

You can get the SMS, social channels, and custom messaging channels with the following add-on license:

- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/)

You can get the Microsoft Teams channel with the following add-on license:

- [Teams license](/MicrosoftTeams/office-365-licensing)

The following channels are currently available in the application: 

## Chat

If you want to help your customers using live chat, you can use the **Chat for Dynamics 365 Customer Service** channel.

To learn more, see [Configure a chat channel](../administer/set-up-chat-widget.md).

## Voice

To address customer issues, you can configure and use the voice channel. More information: [Introduction to the voice channel](../administer/voice-channel.md)

## SMS

If you want to help your customers using SMS, you can use the following SMS channels:

- [SMS through Azure Communication Services](../administer/configure-sms-channel-acs.md)
- [SMS through Twilio](../administer/Configure-sms-channel-twilio.md)

## Social channels

If you want to help your customers using social media, you can use the following social channels:

- [Apple Messages for Business](../administer/configure-apple-messages-for-business-channel.md)
- [Facebook](../administer/configure-facebook-channel.md)
- [WhatsApp through Twilio](../administer/configure-whatsapp-channel.md)
- [LINE](../administer/configure-line-channel.md)

## Custom messaging channel

If you want to help your customers using social channels that aren't supported as standard channels, such as Telegram, you can use the custom channels. To learn more, see [Configure custom messaging application](../administer/configure-custom-channel.md).

If you want to help your customers using your line-of-business messaging channels, you can use the [Direct Line](../develop/bring-your-own-channel.md) Bot Framework method.

## Microsoft Teams

If you want to help your customers using a standard collaboration channel, you can use the Microsoft Teams channel.

To learn more, see [Configure Microsoft Teams](../administer/configure-microsoft-teams.md).

## Entity records

If you want to help your customers using standard entity records such as incident, quote, campaign, and so on, you can use the entity records channel.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
