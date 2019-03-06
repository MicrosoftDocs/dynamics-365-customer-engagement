---
title: "Integrate channel provider using Channel Integration Framework (CIF) | MicrosoftDocs"
description: "Learn how to integrate channel provider like softphone, message, bots, and so on with Unified Service Desk client application using the Microsoft Dynamics 365 Channel Integration Framework."
ms.date: 03/05/2019
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-USD, dyn365-admin
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: 0C0F9EAE-9E16-48E3-B5B9-810CEA071705
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange : '>= dynamics-usd-41'
---

# Integrate channel provider using Channel Integration Framework

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Bring your channel providers and integrate them with Unified Service Desk client application using the Microsoft Dynamics 365 Channel Integration Framework.

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