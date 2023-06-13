---
title: "Overview of channels in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the different channels that are available in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
ms.topic: overview
ms.date: 05/05/2023
---

# Overview of channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

As new social networks and communication channels rapidly evolve, so do customer expectations on how to reach their favorite brands. Communicating via many channels has become not only comfortable but expected, and businesses seeking to provide personalized services are rapidly working to enable support through the channels their customers want to use. 

Adding support channels to your businesses support offering is a powerful way to provide personalized service to customers on the channels of their choice. It is helpful to recognize a common pattern across all channels that are enabled through Omnichannel for Customer Service before diving into the implementation of a single channel. The implementation pattern for out-of-the-box channels is as follows:

- Establish your account and respective requirements (such as a page, and app) with the Channel provider. This ensures you have an entry point with the channel provider through which customers will engage.
- Configure the workstream in [Customer Service admin center](cs-admin-center.md).
- Configure the Channel in Customer Service admin center and attach it to the workstream.
- Populate the exchange of handshake data (token and secrets) required between Omnichannel and the channel provider. This is usually done in both places, the Customer Service admin center app and the channel provider experience. 

The following channels are currently available in Omnichannel for Customer Service: 

## Chat

If you want to help your customers using live chat, you can use the **Chat for Dynamics 365 Customer Service** channel.

To learn more, see [Configure a chat channel](set-up-chat-widget.md).

## Voice

To address customer issues, you can configure and use the voice channel. More information: [Introduction to the voice channel](voice-channel.md)

## SMS

If you want to help your customers using SMS, you can use the following SMS channels:

- [SMS through Azure Communication Services](configure-sms-channel-acs.md)
- [SMS through TeleSign](configure-sms-channel.md)
- [SMS through Twilio](configure-sms-channel-twilio.md)

## Social channels

If you want to help your customers using social media, you can use the following social channels:

- [Apple Messages for Business](configure-apple-messages-for-business-channel.md)
- [Facebook](configure-facebook-channel.md)
- [Google's Business Messages](configure-google-business-messages-channel.md)
- [WhatsApp through Twilio](configure-whatsapp-channel.md)
- [WeChat](configure-wechat-channel.md)
- [LINE](configure-line-channel.md)

## Custom messaging channel

If you want to help your customers using social channels that are not supported as standard channels, such as Telegram, you can use the custom channels. To learn more, see [Configure custom messaging application](configure-custom-channel.md).

If you want to help your customers using your line-of-business messaging channels, you can use the [Direct Line](bring-your-own-channel.md) Bot Framework method.

## Microsoft Teams

If you want to help your customers using a standard collaboration channel, you can use the Microsoft Teams channel.

To learn more, see [Configure Microsoft Teams](configure-microsoft-teams.md).

## Entity records

If you want to help your customers using standard entity records such as incident, quote, campaign and so on, you can use Entity records channel.

To learn more, see [Entity records channel](entity-channel.md).

## License requirements

An active subscription of Dynamics 365 for Customer Service Digital Messaging is required for SMS, social channels, Microsoft Teams, and custom messaging. In addition to Dynamics 365 subscriptions, if you choose to use any third-party channels you'll need to acquire subscriptions from those providers as well.

You can get Chat for Dynamics 365 Customer Service with either of the following add-on licenses:

- [Chat for Dynamics 365 Customer Service](https://dynamics.microsoft.com/customer-service/overview/#pricing)
- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/#pricing)

> [!Note]
> Digital Messaging add-on license includes Chat for Dynamics 365 Customer, SMS, Facebook, and bot integration.

You can get the SMS, social channels, and custom messaging channels with the following add-on license:

- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/)

You can get the Microsoft Teams channel with the following add-on license:

- [Teams license](/MicrosoftTeams/office-365-licensing)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
