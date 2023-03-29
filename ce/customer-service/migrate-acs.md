---
title: Migration changes for the omnichannel messaging platform
description: Understand the changes you need to make to your omnichannel implementations to successfully migrate to the omnichannel messaging platform.
ms.date: 03/09/2023
ms.topic: overview
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: bap-template
---

# Migration changes for the omnichannel messaging platform

As part of the migration to the omnichannel messaging platform, we released a new bot service channel and chat SDK version to extend our messaging capabilities. To successfully migrate to the omnichannel messaging platform, you need to make the following changes to your omnichannel implementations:

- If you have network policies in your organization, be sure to update your [Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md) to include the domains that the omnichannel platform uses.

- If you're using the Omnichannel Chat SDK to customize the live chat widget, [download the latest version of the chat SDK package from GitHub](https://github.com/microsoft/omnichannel-chat-sdk#installation). You need Omnichannel Chat SDK 1.1.0 or later to make sure that your widget works on the platform.

- If you're [integrating an Azure bot](configure-bot.md), connect and register your bot with the omnichannel messaging channel.

  If you're using a Power Virtual Agents bot or Azure Health Bot, there's nothing you need to do. The necessary changes are applied automatically.

- If you're a bot author or developer, [download the latest middleware NuGet package](enable-bot-context.md#install-the-bot-sdk-in-your-project).

- If you've enabled downloading file attachments in chats, you must program your Azure bot to [download file attachments properly](download-attachments-bot.md#manage-file-attachments-during-migration) in the omnichannel messaging channel.

> [!NOTE]
> These changes won't impact your existing omnichannel experience. We'll work with you to help you navigate and test the changes to ensure a smooth transition.

### See also

[Introduction to Omnichannel for Customer Service](introduction-omnichannel.md)  
[Omnichannel for Customer Service system requirements](system-requirements-omnichannel.md)  
[Develop a custom live chat widget](develop-live-chat-widget.md)  
[Customize live chat widgets for mobile apps](render-live-chat-widget-mobile.md)  
[Integrate an Azure bot](configure-bot.md)  

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
