---
title: "Migration changes for new omnichannel messaging platform | MicrosoftDocs"
description: "Use this article to understand the changes you'll need to make to your omnichannel implementations to successfully migrate to the new omnichannel messaging platform."
ms.date: 05/06/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Migration changes for new omnichannel messaging platform

We have started rolling out a new messaging platform in May 2022. As part of this migration, we've released a new bot service channel and chat SDK version to extend our messaging capabilities.

To successfully migrate to the new messaging platform, you must make the following changes to your omnichannel implementations:

- If you have network policies in your organization, be sure to update your system requirements to include a new set of domains that'll be used by the new platform. More information: [Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)

- If you're using the Omnichannel Chat SDK to customize the live chat widget, download the latest version of the chat SDK package. You'll need Omnichannel Chat SDK 1.1.0 or later versions to ensure that your widget works on the new platform. More information: [Omnichannel Chat SDK Installation page on GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation)

- If you're integrating an Azure bot, then you must connect and register your bot with the new channel. More information: [Integrate Azure bot](configure-bot.md). 

  If you're using a Power Virtual Agents bot or Azure Health Bot, then these changes will be automatically applied, and you don't need to take any action.

- If you're a bot author or developer, then you must download the latest middleware NuGet package. More information: [Enable bot context NuGet package](enable-bot-context.md#install-the-bot-sdk-in-your-project)

- If you've enabled the option to download file attachments in chat conversations, then as a bot author or developer, you must program your Azure bot for processing and downloading the file attachments properly in the new channel. More information: [Manage file attachments during migration](download-attachments-bot.md#manage-file-attachments-during-migration)  

> [!Note]
> These changes won't impact your existing omnichannel experience. We'll work with you to help you navigate and test the changes to ensure a smooth transition.


### See also

[Introduction to Omnichannel for Customer Service](introduction-omnichannel.md)  
[Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)  
[Develop a custom live chat widget](develop-live-chat-widget.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[Integrate an Azure bot](configure-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
