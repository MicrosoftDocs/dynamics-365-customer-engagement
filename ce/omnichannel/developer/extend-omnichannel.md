---
title: "Extend Omnichannel for Customer Service | MicrosoftDocs"
description: "Embed Omnichannel for Customer Service functionality into your website or app, or bring functionality from other apps into Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/26/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Extend Omnichannel for Customer Service

<!--You can extend Omnichannel for Customer Service to either embed Omnichannel for Customer Service functionality into your own websites or bring functionality from other applications into Omnichannel for Customer Service.--> There are several scenarios supported to extend Omnichannel for Customer Service. The following table shows the supported scenarios and the recommended method for implementation.  
<p>

| Omnichannel for Customer Service integration scenario | Channel Integration Framework V2 | Custom Messaging Channel  | 
|---------------------------------------------------------------------|------------|------------|
| Integrate third-party telephony          | Yes           | - |
| Add Direct Line or Telegram channels  | - | Yes |
| Add any custom chat channel that has API support via Direct Line  | - | Yes |
| Build a web canvas for highly customized experiences using a fully programmable API (e.g. click to view ticket, click to schedule an appointment) | - | Yes |

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

You can integrate your line-of-business (in-house), social, and other messaging channels with Omnichannel for Customer Service. The custom messaging channel leverages the Azure Bot Framework to integrate the third-party channel with the Omnichannel for Customer Service app. For your line-of-business (in-house) messaging channels, you can use the Direct Line channel (Azure Bot Framework method). 

After integration, you can leverage the work distribution system to automatically assign work items (conversations) to the agents.

For more information, refer to [Configure a custom messaging channel](../administrator/configure-custom-channel.md).


## See also 

[Configure a custom messaging channel](../administrator/configure-custom-channel.md)<br />
[Bring your own custom messaging channel: Direct Line bot](../developer/how-to/bring-your-own-channel.md)<br />
[Connect a bot to Direct Line](https://docs.microsoft.com/azure/bot-service/bot-service-channel-connect-directline)<br />
[Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework)
