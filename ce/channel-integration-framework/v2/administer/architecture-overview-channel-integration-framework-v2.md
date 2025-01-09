---
title: Architecture overview of Dynamics 365 Channel Integration Framework 2.0 
description: Get an overview of Dynamics 365 Channel Integration Framework 2.0 and its architecture that lets you integrate with non-Microsoft channel providers.
author: gandhamm
ms.topic: overview
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 12/10/2024
ms.custom: bap-template
---

# Architecture overview of Dynamics 365 Channel Integration Framework 2.0

Dynamics 365 Channel Integration Framework version 2.0 provides an extensible framework to integrate non-Microsoft Computer Telephony Integration (CTI) systems to serve your customers with more focus and agility.

 :::image type="content" source="../../media/cif-high-level-architecture-v2.png" alt-text="High-level architecture diagram of Dynamics 365 Channel Integration Framework" :::


**1 - Microsoft Dynamics 365**<br>
Power Platform environment where the Dynamics 365 Channel Integration Framework app is present to create and manage the configurations required for a telephony channel to interact with the Dynamics 365 model-driven app.

**2 - Multisession apps**<br>
The Customer Service workspace and Omnichannel for Customer Service apps expose the Dynamics 365 Channel Integration Framework panel to host the telephony channel.

**3 - Channel Integration Framework Adapter**<br>
The Channel Integration Framework Adapter enables the communication between Dynamics 365 model-driven app and the capabilities of the telephony channel.

**4 - Web-based Communication widget**<br>
The telephony channel is hosted in the widget that Dynamics 365 Channel Integration Framework provides. You can host your choice of telephony channel.

**5 - Telephony Channel Provider**<br>
The telephony channel is the service that you want to integrate and interact with Power Platform environment using the Dynamics 365 Channel Integration Framework. The capabilities of a channel are specific to the channel provider; Dynamics 365 Channel Integration Framework is agnostic on the working of the channel.


## Related information

[System requirements of Dynamics 365 Channel Integration Framework](../../v1/administer/system-requirements-channel-integration-framework.md)  
[Overview of Dynamics 365 Channel Integration Framework](../../v1/administer/overview-channel-integration-framework.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
