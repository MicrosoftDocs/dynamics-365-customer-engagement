---
title: "Extend Omnichannel for Customer Service | MicrosoftDocs"
description: "Embed Omnichannel functionality into your website or app, or bring functionality from other apps into Omnichannel."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/24/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Extend Omnichannel for Customer Service

<!--You can extend Omnichannel for Customer Service to either embed Omnichannel for Customer Service functionality into your own websites or bring functionality from other applications into Omnichannel for Customer Service.--> There are several scenarios supported to extend Omnichannel. The following table shows the supported scenarios and the recommended method for implementation.<br><br>

| Omnichannel integration scenario | CIFv2 | BYOC  | 
|---------------------------------------------------------------------|------------|------------|
| Integrate third-party telephony          | Yes           | - |
| Add any channel that has API support or is offered via an aggregator | - | Yes |
| Build a web canvas for highly customized experiences using a fully programmable API (e.g. click to view ticket, click to schedule an appointment) | - | Yes |
| Add any channel that has a native Microsoft Bot Framework bot | - | Yes |

<!--## Embedding Omnichannel functionality in your applications-->

<!--### Out of the box chat widget
This is the iframe embedded live chat widget that provides basic customizations in the Omnichannel Administration app and embed in your web portal.-->

<!--### Customized chat widget
You can customize the look and feel of your chat widget using the react native SDK for Omnichannel. (https://react-native.org/)-->

## Embedding other tools in Omnichannel for Customer Service

### Telephony 
The Channel Integration Framework v2 (CIFv2) enables you to show notifications for requests from other tools within the Omnichannel for Customer Service app and enable agents to accept and facilitate the conversation from within the Omnichannel app. 

The third-party app still manages agent authentication and presence, and the routing and assignment of customer requests. Once the request is assigned to the agent, the notification displays to the agent in Omnichannel. This is a UI level integration only and does not integrate with CDS so you cannot take advantage of linking data from the customer conversation with all other records in CDS. Recommended for bringing telephony into Omnichannel. 

For more information, refer to [Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework). 

### Other messaging channels
You can deeply integrate a messaging channel into Omnichannel such that it behaves as a first party integration and can leverage all native Omnichannel services. These services include routing, assignment, and integration with CDS data for linking customer records, cases, and so on. This functionality leverages the Azure Bot framework upon which all out of the box, third party messaging channels are integrated.

For more information, refer to [Bring your own custom messaging channel: Direct Line bot](https://docs.microsoft.com/dynamics365/omnichannel/developer/how-to/bring-your-own-channel).


## See also 

[Bring your own custom messaging channel: Direct Line bot](https://docs.microsoft.com/dynamics365/omnichannel/developer/how-to/bring-your-own-channel)
[Configure a custom messaging channel](https://docs.microsoft.com/dynamics365/omnichannel/administrator/configure-custom-channel)
