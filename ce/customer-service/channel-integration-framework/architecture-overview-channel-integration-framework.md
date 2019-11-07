---
title: "Architecture overview of Dynamics 365 Channel Integration Framework helps| Microsoft Docs"
description: "Learn the architecture overview of Dynamics 365 Channel Integration Framework."
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 937bd2df-0b5c-48c8-b415-285820b246c9
author: susikka
ms.author: susikka
manager: shujoshi
---

# Architecture overview of Dynamics 365 Channel Integration Framework 

Dynamics 365 Channel Integration Framework provides an extensible framework to integrate third-party Computer Telephony Integration (CTI) systems to serve your customers with more focus and agility.

> [!div class="mx-imgBorder"]
> ![High-level architecture diagram of Dynamics 365 Channel Integration Framework](media/cif-high-level-architecture.png "High-level architecture diagram of Dynamics 365 Channel Integration Framework")

**1 - Microsoft Dynamics 365**<br>
Dynamics 365 instance where the Dynamics 365 Channel Integration Framework app is present to create and manage the configurations required for a third-party communication widget to interact with the Unified Interface app.

**2 - Unified Interface app**<br>
The Dynamics 365 (Online) Unified Interface app exposes the Dynamics 365 Channel integration Framework panel to host the third-party communication widget (channel provider).

**3 - Channel Integration Framework Adapter**<br>
The Channel Integration Framework Adapter enables the communication between Dynamics 365 and the capabilities of the channel provider.

**4 - Web-based communication widget**<br>
The web-based communication channel (third party) is hosted in the widget that Dynamics 365 Channel Integration Framework provides. This is a multipurpose communication widget wherein you can host a CTI, chat, or email channels of your choice.

**5 - Cloud Channel Provider**<br>
The Cloud Channel Provider is the service that you want to integrate and interact with Dynamics 365 using the Dynamics 365 Channel Integration Framework. The capabilities of a channel are voice, SMS, chat, email, and so on. These capabilities of a channel are specific to the channel provider and Dynamics 365 Channel Integration Framework is agnostic on the working of the channel.

> [!div class="nextstepaction"]
> [System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)


## See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)
