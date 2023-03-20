---
title: "Choose between Dynamics 365 Channel Integration Framework 1.0 and 2.0 | MicrosoftDocs"
description: "Know the feature differences between Dynamics 365 Channel Integration Framework versions 1.0 and 2.0., so you can choose the one that best suits your business needs."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 01/21/2022
ms.topic: article
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---


# Choose between Dynamics 365 Channel Integration Framework 1.0 and 2.0

This topic explains the key feature differences between Dynamics 365 Channel Integration Framework 1.0 and 2.0, and helps you choose the version that suits your business requirements.

## Dynamics 365 Channel Integration Framework 1.0

You can use Dynamics 365 Channel Integration Framework 1.0 to integrate a channel provider of your choice if your organization is using any of the single-session Dynamics 365 model-driven apps, such as:

- Dynamics 365 Customer Service
- Dynamics 365 Sales
- Dynamics 365 Project Service
- Dynamics 365 Field Service

You can integrate channels such as telephony, messaging (SMS) or chat channels with any of the single-session Dynamics 365 model-driven apps to have an immersive experience.

More information: [Dynamics 365 Channel Integration Framework 1.0](overview-channel-integration-framework.md)

> [!NOTE]
> Dynamics 365 Channel Integration Framework 1.0 is available for Government Community Cloud (GCC).

## Dynamics 365 Channel Integration Framework 2.0

You can use Dynamics 365 Channel Integration Framework 2.0 to integrate telephony channel providers of your choice if your organization is using the multi-session apps, such as Omnichannel for Customer Service and Customer Service workspace.

Using Dynamics 365 Channel Integration Framework 2.0 with multisession apps, such as Omnichannel for Customer Service and Customer Service workspace, enables you to use cross-channel analytics.

More information: [Channel Analytics](v2/channel-analytics.md)  
More information: [Dynamics 365 Channel Integration Framework 2.0](v2/overview-channel-integration-framework.md)

To learn more about multisession app, see [Omnichannel for Customer Service](../introduction-omnichannel.md).

## Versions 1.0 and 2.0

The following matrix explains the various aspects of versions 1.0 and 2.0.

|Feature| Version 1.0 | Version 2.0 |
|--------------------------------|---------------------------|-------------------------------|
|Session| Single-session  | Multisession|
|Model-driven app | <li>Dynamics 365 Customer Service <br> <li>Dynamics 365 Sales <br> <li>Dynamics 365 Project Service <br> <li>Dynamics 365 Field Service | <li> Omnichannel for Customer Service<br /><li> Customer Service workspace |
|Deployment/provisioning|Using Dynamics 365 Channel Integration Framework 1.0 model-driven app|Deployed with Customer Service workspace and Omnichannel for Customer Service|
|Communication panel | Right side | Left side |
|Communication panel modes | <li>Minimized <br> <li>Expanded | <li>Docked <br> <li>Minimized <br> <li>Hidden |
|Features| <li> Support for one channel provider at any time <br> <li> Communication panel management |<li> Support for multiple telephony channel providers <br> <li> Communication panel management <br> <li> Channel analytics <br> <li> Notification management templates<br> <li> Application tab management templates<br> <li> Session management templates |

For information about how to integrate custom messaging channel providers with Omnichannel for Customer Service, see [Bring your own channel](../bring-your-own-channel.md).

> [!div class="mx-imgBorder"]
> ![Differences between versions 1.0 and 2.0.](media/choose-between-version.png "Differences between versions 1.0 and 2.0")

### See also

[Dynamics 365 Channel Integration Framework 1.0](overview-channel-integration-framework.md)  
[Dynamics 365 Channel Integration Framework 2.0](v2/overview-channel-integration-framework.md)  
[Integrate Dynamics 365 Channel Integration Framework 2.0 with Omnichannel for Customer Service](v2/integration-multi-session-experiences.md)  
[Multisession agent experiences](/business-applications-release-notes/april19/service/omnichannel-for-customer-service/multi-session-agent-experiences-web-usd)  
[Bring your own channel](../bring-your-own-channel.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
