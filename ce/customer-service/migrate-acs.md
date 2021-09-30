---
title: "Migration changes for new Omnichannel messaging platform | MicrosoftDocs"
description: "Understand the changes you'll need to make to your omnichannel implementations before January 2022."
ms.date: 09/30/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Migration changes for new Omnichannel messaging platform

The Dynamics 365 Omnichannel team will be rolling out a new messaging platform enhancement in phases over the next few months. A new Azure Bot Service channel will be released that'll help extend the existing bot integration capabilities for the messaging channels. Though the platform changes will be released in November 2021, the updates will get automatically applied between January and March, 2022.

To ensure that you have a smooth transition, here are the set of changes you'll need to make to your omnichannel implementations before January 2022.
> [!Note]
> These changes can be applied anytime and will not impact your existing omnichannel experience. Microsoft will work with you to help you navigate and test the changes so you have a smooth transition by January 2022.

- If you have network policies in your organization, be sure to update your system requirements to include a new set of domains that'll be used by the new omnichannel application. More information: [Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)

- If you're using the Omnichannel Chat SDK to customize the live chat widget for mobile apps, then be sure to download the latest version of the SDK package. More information: [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation).

- If you're integrating an Azure bot, then you must connect and register your bot with the new Omnichannel channel. More information: [Integrate Azure bot](configure-bot.md)
    
    > [!Note]
    > If you're using a Power Virtual Agents bot or Azure Health Bot, then these changes will be automatically applied, and you don't need to take any action.