---
title: "Extend Omnichannel for Customer Service | MicrosoftDocs"
description: "Embed Omnichannel for Customer Service functionality into your website or app, or bring functionality from other apps into Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 07/07/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# Extend Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

Microsoft Dynamics 365 supports several scenarios to extend Omnichannel for Customer Service.

**Telephony:** You can integrate a third-party telephony system. For example, in a contact center, you can bring the softphone provider of your choice directly into the agent experience. This telephony integration ensures that incoming and outgoing voice calls are handled in a single agent experience, and that all necessary data is passed between the telephony system and Microsoft Dynamics 365.

**Additional Digital Channels:** Beyond the digital channels such as web chat and Facebook Messenger that are provided out of the box with the Digital Messaging Add-on, you might need additional custom channels. These might include channels that your organization has created for use internally.

**Custom Experiences:** For some organizations, highly customized experiences from a user endpoint perspective might be needed. For example, an organization that wants to create a highly customized app that embeds the Omnichannel for Customer Service messaging capabilities might need to go beyond the standard canvas approach.

The following table shows the SKUs that correspond with each experience.

| Experience | Customer Service Enterprise | Chat for Dynamics 365 Add-on  | Digital Messaging Add-on |
|---------------------------------------------------------------------|------------|------------|------------|
| Telephony (via third-party)          | Yes | Yes | Yes |
| Web chat  | - | Yes | Yes |
| Social channels including Facebook Messenger, WeChat, Teams, SMS and WhatsApp  | - | - | Yes |
| Custom chat and messaging channels via Direct Line  | - | - | Yes |


> [!NOTE]
> [SMS](configure-SMS-channel.md) and [WhatsApp](configure-whatsapp-channel.md) require additional third-party subscriptions. Refer to channel documentation for more information.

## Embedding other tools in Omnichannel for Customer Service

### Telephony

Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate your telephony channel with multisession web experiences (Omnichannel for Dynamics 365 Customer Service). These APIs allow the telephony channel to show notifications for an incoming conversation with relevant information, start new sessions for conversations, and open application tabs as needed.

For more information, see [Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework).

### Other messaging channels

You can integrate your line-of-business (in-house), social, and other messaging channels with Omnichannel for Customer Service. This is primarily done through configuring a custom messaging channel via Direct Line. After integration, you can leverage the work distribution system to automatically assign work items (conversations) to agents on these custom channels.

Direct Line allows custom channels to be brought into Omnichannel for Customer Service by leveraging the Microsoft Bot Framework. To bring in a custom channel, you can set up a Direct Line connection through the Azure Bot Service (which will incur Azure charges), and then bring that Direct Line bot into Omnichannel for Customer Service.

For more information, see [Configure a custom messaging channel](configure-custom-channel.md).

### See also

[Bring your own custom messaging channel: Direct Line bot](bring-your-own-channel.md)  
[Connect a bot to Direct Line](https://docs.microsoft.com/azure/bot-service/bot-service-channel-connect-directline)  
[Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]