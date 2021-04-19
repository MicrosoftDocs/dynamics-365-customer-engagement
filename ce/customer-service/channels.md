---
title: "Overview of channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about channels in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Overview of channels

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

As new social networks and communication channels rapidly evolve, so do customer expectations on how to reach their favorite brands. Communicating via many channels has become not only comfortable but expected and businesses seeking to provide personalized service are rapidly working to enable support through the channels their customers want to use. 

Adding support channels to your businesses support offering is a powerful way to provide personalized service to customers on the channels of their choice. It is helpful to recognize a common pattern across all channels that are enabled through Omnichannel for Customer Service before diving into the implementation of a single channel. The implementation pattern for out of the box channels is as follows:

- Establish your account and respective requirements (such as a page, and app) with the Channel provider. This ensures you have an entry point with the channel provider through which customers will engage.
- Configure the work stream in Omnichannel Administration.
- Configure the Channel in Administration and attach it to the workstream.
- Populate the exchange of handshake data (token and secrets) required between Omnichannel and the channel provider.  This is usually done in both place, the Omnichannel Administration app and the channel provider experience. 

The following channels are currently available in Omnichannel for Customer Service: 

## Chat

If you want to help your customers using live chat, you can use the **Chat for Dynamics 365 Customer Service** channel.

To learn more, see [Configure a chat channel](set-up-chat-widget.md).

## SMS

If you want to help your customers using SMS, you can use the SMS channel.

There are two options:

- [SMS through TeleSign](configure-sms-channel.md)
- [SMS through Twilio](configure-sms-channel-twilio.md)

## Social channels

If you want to help your customers using social channels, you can use the social channels.

- [Facebook](configure-facebook-channel.md)
- [WhatsApp through Twilio](configure-whatsapp-channel.md)
- [Twitter](configure-twitter-channel.md)
- [WeChat](configure-wechat-channel.md)
- [LINE](configure-line-channel.md)

## Custom messaging channel

If you want to help your customers using social channels that are not supported as standard channels, such as Telegram, you can use the custom channels. To learn more, see [Configure custom messaging application](configure-custom-channel.md).

If you want to help your customers using your Line of Business (in-house) messaging channels, you can use the [Direct Line](configure-custom-channel.md#bring-channels-using-direct-line) Bot Framework method.

## Microsoft Teams

If you want to help your customers using a standard collaboration channel, you can use the Microsoft Teams channel.

To learn more, see [Configure Microsoft Teams](configure-microsoft-teams.md).

## Entity records

If you want to help your customers using standard entity records such as incident, quote, campaign and so on, you can use Entity records channel.

To learn more, see [Entity records channel](entity-channel.md).

## License requirements

An active subscription of Dynamics 365 for Customer Service Digital Messaging is required for SMS, social channels, Microsoft Teams, and custom messaging. In addition to Dynamics 365 subscriptions, if you choose to use any third-party channels you will need to acquire subscriptions from those providers as well. 

You can get the Chat for Dynamics 365 Customer Service with either of the add-on license:

- [Chat for Dynamics 365 Customer Service](https://dynamics.microsoft.com/customer-service/overview/#pricing)
- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/#pricing)

> [!Note]
> Digital Messaging add-on license includes Chat for Dynamics 365 Customer, SMS, Facebook, and bot integration.

You can get the SMS, social channels, and custom messaging channels with the following add-on license:

- [Digital Messaging](https://dynamics.microsoft.com/customer-service/overview/)

You can get the Microsoft Teams channel with the following add-on license:

- [Teams license](https://docs.microsoft.com/MicrosoftTeams/office-365-licensing)


[!INCLUDE[footer-include](../includes/footer-banner.md)]