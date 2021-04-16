---
title: "Integrate channel using Channel Integration Framework (CIF) | MicrosoftDocs"
description: "Learn how to integrate channel provider like softphone, message, bots, and so on with Unified Service Desk client application using the Channel Integration Framework."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/10/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.1'
---

# Integrate channel using Channel Integration Framework

Bring your channel providers and integrate them with Unified Service Desk client application using the Channel Integration Framework.

If your organization wants to use the cloud-based channel that you have developed using the [Channel Integration Framework](/dynamics365/customer-engagement/developer/channel-integration-framework/channel-integration-framework), you can integrate the same channel in Unified Service Desk with minimal configuration experience. In turn, this eliminates the need for developing multiple channels. 

The User Interface Integration (UII) framework provides a hosted control - **Channel Integration Framework** for you to host the channel provider within Unified Service Desk client application.

## What is Channel Integration Framework for Unified Service Desk

The Channel Integration Framework hosted control type acts as an interface between the Unified Service client application and channel provider. 

The Channel Integration Framework type of hosted control provides a set of actions and events for you to integrate and experience a seamless interaction between the channel provider and Unified Service Desk client application. These predefined actions and events parses the parameters to the Unified Service Desk client application. To learn more, see [Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md).

Based on your organization requirements, you must create actions and attach them to the predefined events to proceed with the scenarios your business demands.

> [!div class="nextstepaction"]
> [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md)

## See also

- [Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md)
- [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]