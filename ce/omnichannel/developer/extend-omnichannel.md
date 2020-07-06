---
title: "Extend Omnichannel for Customer Service | MicrosoftDocs"
description: "Embed Omnichannel for Customer Service functionality into your website or app, or bring functionality from other apps into Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 07/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Extend Omnichannel for Customer Service

<!--You can extend Omnichannel for Customer Service to either embed Omnichannel for Customer Service functionality into your own websites or bring functionality from other applications into Omnichannel for Customer Service. To integrate your in-house telephony channel into Omnichannel for Customer Service, you can use Dynamics 365 Channel Integration Framework version 2.0. To add Direct Line or Telegram channels, add custom chat channels, or build a web canvas for highly customized experiences, you can bring your own custom messaging channel. -->

Microsoft Dynamics 365 supports several scenarios to extend Omnichannel for Customer Service. 

**Telephony:** You can integrate a third-party telephony system. For example, in a contact center, you can bring the softphone provider of your choice directly into the agent experience. This telephony integration ensures that incoming and outgoing voice calls are handled in a single agent experience, and that all necessary data is passed between the telephony system and Microsoft Dynamics 365. 

**Additional Digital Channels:** Beyond the digital channels such as web chat and Facebook Messenger that are provided out of the box with the Digital Messaging Add-on, you may need additional custom channels. These may include channels that your organization has created for use internally.

**Custom Experiences:** For some organizations, highly customized experiences from a user endpoint perspective are desired. For example, an organization that needs to create a highly customized app that embeds the Omnichannel for Customer Service messaging capabilities may need to go beyond the standard canvas approach.

The following table shows the SKUs that correspond with each experience.
<br>

<!--
| Experience | Customer Service Enterprise  | Chat for Dynamics 365 Add-on  | Digital Messaging Add-on  | 
|------------------------------------|--------------------------|--------------------------|--------------------------|
| Telephony (via third-party) | Yes | Yes | Yes |
| Chat for Dynamics 365  | - | Yes | Yes |
| Custom chat and messaging channels via Direct Line | - | - | Yes |
-->

| Experience | Customer Service Enterprise | Chat for Dynamics 365 Add-on  | Digital Messaging Add-on |
|---------------------------------------------------------------------|------------|------------|------------|
| Telephony (via third-party)          | Yes | Yes | Yes |
| Web chat  | - | Yes | Yes |
| Social channels including Facebook Messenger, WeChat, Teams, SMS* and WhatsApp*  | - | - | Yes |
| Custom chat and messaging channels via Direct Line  | - | - | Yes |


> [!NOTE]
> [SMS](../administrator/configure-SMS-channel.md) and [WhatsApp](../administrator/configure-whatsapp-channel.md) require additional third-party subscriptions. Refer to channel documentation for more information.

<!--## Embedding Omnichannel functionality in your applications-->

<!--### Out of the box chat widget
This is the iframe embedded live chat widget that provides basic customizations in the Omnichannel Administration app and embed in your web portal.-->

<!--### Customized chat widget
You can customize the look and feel of your chat widget using the react native SDK for Omnichannel. (https://react-native.org/)-->

## Embedding other tools in Omnichannel for Customer Service

### Telephony 

Dynamics 365 Channel Integration Framework version 2.0 provides APIs to integrate your telephony channel with multisession web experiences (Omnichannel for Dynamics 365 Customer Service). These APIs allow the telephony channel to show notifications for an incoming conversation with relevant information, start new sessions for conversations, and open application tabs as needed.

For more information, refer to [Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework). 

### Other messaging channels

You can integrate your line-of-business (in-house), social, and other messaging channels with Omnichannel for Customer Service. This is primarily done through configuring a custom messaging channel via Direct Line. After integration, you can leverage the work distribution system to automatically assign work items (conversations) to agents on these custom channels.

Direct Line allows custom channels to be brought into Omnichannel for Customer Service by leveraging the Microsoft Bot Framework. To bring in a custom channel, you can set up a Direct Line connection through the Azure Bot Service (which will incur Azure charges), and then bring that Direct Line bot into Omnichannel for Customer Service.

For more information, refer to [Configure a custom messaging channel](../administrator/configure-custom-channel.md).

## See also 

[Configure a custom messaging channel](../administrator/configure-custom-channel.md)<br />
[Bring your own custom messaging channel: Direct Line bot](../developer/how-to/bring-your-own-channel.md)<br />
[Connect a bot to Direct Line](https://docs.microsoft.com/azure/bot-service/bot-service-channel-connect-directline)<br />
[Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework)
