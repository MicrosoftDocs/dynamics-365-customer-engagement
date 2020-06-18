---
title: "Extend Omnichannel for Customer Service | MicrosoftDocs"
description: "Embed Omnichannel functionality into your website or app, or bring functionality from other apps into Omnichannel."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/18/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Extend Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

You can extend Omnichannel for Customer Service to either embed Omnichannel for Customer Service functionality into your own websites or mobile apps or bring functionality from other applications into Omnichannel for Customer Service. There are several different ways to extend Omnichannel, each optimized for different scenarios so its important to start with the scenario you are trying to enable before you choose the method you will use to extend. 

## Embedding Omnichannel functionality in your applications

### Out of the box chat widget 
This is the iframe embedded live chat widget that provides basic customizations in the Omnichannel Administration app and embed in your web portal.

### Customized chat widget
You can customize the look and feel of your chat widget using the react native SDK for Omnichannel. (https://react-native.org/)

## Embedding other tools in Omnichannel for Customer Service

### Enabling telephony 
The Channel Integration Framework v2 (CIFv2) enables you to show notifications for requests from other tools within the Omnichannel for Customer Service app and enable agents to accept and facilitate the conversation from within the Omnichannel app. Agents still manage their authentication and presence in the other application and the routing and assignment of the request to the agent is done in the third party application and only comes to the agent in Omnichannel once it has been assigned to them. This is a UI level integration only and does not integrate with CDS so you cannot take advantage of linking data from the customer conversation with all other records in CDS. Recommended for bringing telephony into Omnichannel. 

For more information, refer to [Dynamics 365 Channel Integration Framework version 2.0](https://docs.microsoft.com/en-us/dynamics365/customer-service/channel-integration-framework/v2/overview-channel-integration-framework). 

### Enabling other channels
You can deeply integrate a messaging channel into Omnichannel such that it behaves as a first party integration and can leverage all native Omnichannel services. These services include routing, assignment, and integration with CDS data for linking customer records, cases, and so on. This functionality leverages the Azure Bot framework upon which all out of the box, third party messaging channels are integrated.

For more information, refer to [Bring your own channel](https://docs.microsoft.com/en-us/dynamics365/omnichannel/developer/how-to/bring-your-own-channel).


| Omnichannel | CIFv2 | BYOC  | In-App SDK |
|---------------------------------------------------------------------|------------|------------|------------|
| Integrate third-party telephony          | Yes           | - | - |
| Build a custom chat widget for mobile or web that integrates with OC         | -           | - | Yes |
| Add any channel to OC that has a native Bot Framework Bot (e.g. Twilio, Kik, Telegram, GroupMe) | - | Yes | - |
| Add any channel to OC that has API support or is offered via an aggregator (e.g. Twilio)  | - | Yes | - |
| Build a build a web canvas for highly customized experiences using a fully programmable API (e.g. click to view ticket, click to schedule an appointment) | - | Yes | - | 

## See also 

[Bring your own channel](https://docs.microsoft.com/en-us/dynamics365/omnichannel/developer/how-to/bring-your-own-channel).
