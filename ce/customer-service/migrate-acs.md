---
title: "Migration changes for new Omnichannel messaging platform | MicrosoftDocs"
description: "Understand the changes you'll need to make to your omnichannel implementations to successfully migrate to the new Azure Bot Service channel."
ms.date: 03/31/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Migration changes for new Omnichannel messaging platform

We'll be rolling out a new messaging platform enhancement in phases over the next few months. We're releasing a new Azure Bot Service channel to extend the existing bot integration capabilities for the messaging channels.

You must make the following changes to your omnichannel implementations:

- If you have network policies in your organization, be sure to update your system requirements to include a new set of domains that'll be used by the new Omnichannel channel. More information: [Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)

- If you're using the Omnichannel Chat SDK to customize the live chat widget for mobile apps, download the latest version of the chat SDK package. You'll need Omnichannel Chat SDK 1.0.0 to implement the new Azure Bot Service channel. More information: [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation)

- If you're integrating an Azure bot, then you must connect and register your bot with the new Omnichannel channel. More information: [Integrate Azure bot](configure-bot.md). If you're using a Power Virtual Agents bot or Azure Health Bot, then these changes will be automatically applied, and you don't need to take any action.

- If you're a bot author or developer, then you must download the latest middleware NuGet package. More information: [Enable bot context NuGet package](enable-bot-context.md#install-the-bot-sdk-in-your-project) 

> [!Note]
> These changes won't impact your existing omnichannel experience. We'll work with you to help you navigate and test the changes to ensure a smooth transition.

### See also

[Introduction to Omnichannel for Customer Service](introduction-omnichannel.md)  
[Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[Integrate an Azure bot](configure-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
