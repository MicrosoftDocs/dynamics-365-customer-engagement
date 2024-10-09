---
title: Extend Omnichannel for Customer Service
description: Integrate third-party telephony systems, additional digital channels, and custom experiences with Dynamics 365 Customer Service to extend Omnichannel for Customer Service.
ms.date: 11/27/2023
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/24/2023
---

# Extend Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]


Dynamics 365 supports several scenarios to extend Omnichannel for Customer Service. You can integrate third-party telephony systems and custom channels.

The following table shows the SKUs that correspond with each experience.

| Experience | Customer Service Enterprise | Chat for Dynamics 365 Add-on  | Digital Messaging Add-on |
|---------------------------------------------------------------------|------------|------------|------------|
| Telephony (via third-party providers)          | Yes | Yes | Yes |
| Web chat  | - | Yes | Yes |
| Social channels, including Facebook Messenger, Teams, SMS, and WhatsApp  | - | - | Yes |
| Custom chat and messaging channels via Direct Line  | - | - | Yes |

> [!NOTE]
> [SMS](../use/sms-channel-overview.md) requires additional third-party subscriptions.

## Embed other tools in Omnichannel for Customer Service

### Telephony

You can integrate a third-party telephony system. For example, in a contact center, you can bring the soft phone provider of your choice directly into the agent experience. This telephony integration ensures that incoming and outgoing voice calls are handled in a single agent experience, and all the necessary data is passed between the telephony system and Dynamics 365.

Dynamics 365 Channel Integration Framework 2.0 provides APIs to integrate your telephony channel with multisession web experiences (Omnichannel for Dynamics 365 Customer Service). These APIs allow the telephony channel to show notifications for an incoming conversation with relevant information, start new sessions for conversations, and open application tabs as needed. More information: [Dynamics 365 Channel Integration Framework 2.0](../../channel-integration-framework/v2/administer/overview-channel-integration-framework.md)

### Other messaging channels

You can integrate your line-of-business (in-house), social, and other messaging channels with Omnichannel for Customer Service. This is primarily done through configuring a custom messaging channel via Direct Line. After integration, you can use unified routing to automatically assign work items (conversations) to agents on these custom channels.

Direct Line allows custom channels to be brought into Omnichannel for Customer Service by using the Microsoft Bot Framework. To bring in a custom channel, you can set up a Direct Line connection through the Azure Bot Service (which will incur Azure charges), and then bring that Direct Line bot into Omnichannel for Customer Service. More information: [Configure a custom messaging channel](../administer/configure-custom-channel.md)

### Related information

[Bring your own custom messaging channel: Direct Line bot](../develop/bring-your-own-channel.md)  
[Connect a bot to Direct Line](/azure/bot-service/bot-service-channel-connect-directline)  
[Dynamics 365 Channel Integration Framework 2.0](../../channel-integration-framework/v2/administer/overview-channel-integration-framework.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
