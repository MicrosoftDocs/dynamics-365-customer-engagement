---
title: "Architecture overview of Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Get an overview of Dynamics 365 Channel Integration Framework 1.0 and its architecture that lets you integrate with third-party channel providers."
author: gandhamm
ms.topic: overview
ms.author: mgandham
manager: shujoshi
ms.date: 08/02/2022
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
  - "intro-internal"
---

# Architecture overview of Dynamics 365 Channel Integration Framework 1.0 

Dynamics 365 Channel Integration Framework version 1.0 provides an extensible framework to integrate third-party channel providers to serve your customers with more focus and agility.

> [!div class="mx-imgBorder"]
> ![High-level architecture diagram of Dynamics 365 Channel Integration Framework.](media/cif-high-level-architecture.png "High-level architecture diagram of Dynamics 365 Channel Integration Framework")

**1 - Microsoft Dynamics 365**<br>
Power Platform environment where the Dynamics 365 Channel Integration Framework app is present to create and manage the configurations required for a third-party communication widget to interact with the Dynamics 365 model-driven app.

**2 - Dynamics 365 model-driven app**<br>
The single-session Dynamics 365 model-driven app exposes the Dynamics 365 Channel Integration Framework panel to host the third-party communication widget (channel provider).

**3 - Channel Integration Framework Adapter**<br>
The Channel Integration Framework Adapter enables the communication between a single-session Dynamics 365 model-driven app and the capabilities of the channel provider.

**4 - Web-based Communication widget**<br>
The web-based communication channel (third party) is hosted in the widget that Dynamics 365 Channel Integration Framework provides. This is a multipurpose communication widget wherein you can host a CTI, chat, or email channels of your choice.

**5 - Cloud Channel Provider**<br>
The Cloud Channel Provider is the service that you want to integrate and interact with a single session Dynamics 365 model-driven app using the Dynamics 365 Channel Integration Framework. The capabilities of a channel are voice, SMS, chat, email, and so on. These capabilities of a channel are specific to the channel provider; Dynamics 365 Channel Integration Framework is agnostic on the working of the channel.

> [!div class="nextstepaction"]
> [System requirements of Dynamics 365 Channel Integration Framework](system-requirements-channel-integration-framework.md)


## See also

[Overview of Dynamics 365 Channel Integration Framework](overview-channel-integration-framework.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
