---
title: "Architecture overview of Dynamics 365 Channel Integration Framework version 2.0 | Microsoft Docs"
description: "Learn the architecture overview of Dynamics 365 Channel Integration Framework version 2.0."
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/31/2019
ms.topic: get-started-article
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Architecture overview of Dynamics 365 Channel Integration Framework 

Dynamics 365 Channel Integration Framework version 2.0 provides an extensible framework to integrate third-party Computer Telephony Integration (CTI) systems to serve your customers with more focus and agility.

> [!div class="mx-imgBorder"]
> ![High-level architecture diagram of Dynamics 365 Channel Integration Framework](../media/cif-high-level-architecture-v2.png "High-level architecture diagram of Dynamics 365 Channel Integration Framework")

**1 - Microsoft Dynamics 365**<br>
Dynamics 365 environment where the Dynamics 365 Channel Integration Framework app is present to create and manage the configurations required for a softphone channel to interact with the Dynamics 365 model-driven app.

**2 - Dynamics 365 model-driven app**<br>
The Dynamics 365 model-driven app exposes the Dynamics 365 Channel integration Framework panel to host the softphone channel.

**3 - Channel Integration Framework Adapter**<br>
The Channel Integration Framework Adapter enables the communication between Dynamics 365 model-driven app and the capabilities of the softphone channel.

**4 - Web-based communication widget**<br>
The softphone channel is hosted in the widget that Dynamics 365 Channel Integration Framework provides. You can host your choice of softphone channel.

**5 - Cloud Channel Provider**<br>
The softphone channel is the service that you want to integrate and interact with Dynamics 365 environment using the Dynamics 365 Channel Integration Framework. The capabilities of a channel are specific to the channel provider, and Dynamics 365 Channel Integration Framework is agnostic on the working of the channel.

> [!div class="nextstepaction"]
> [System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)


## See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)
