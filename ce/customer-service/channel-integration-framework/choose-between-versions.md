---
title: "How to choose between Dynamics 365 Channel Integration Framework version 1.0 and version 2.0 | Microsoft Docs"
description: "Learn how to choose between Dynamics 365 Channel Integration Framework version 1.0 and version 2.0."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Choose between Channel Integration Framework version 1.0 and version 2.0

This topic explains the key feature differences between Dynamics 365 Channel Integration Framework version 1.0 and version 2.0 and to choose a version that suits your business requirements.

## Channel Integration Framework version 1.0

You can use Dynamics 365 Channel Integration Framework version 1.0 to integrate a channel provider of your choice if your organization is using any of the single-session Dynamics 365 model-driven apps, such as: 

- Dynamics 365 Customer Service
- Dynamics 365 Sales
- Dynamics 365 Project Service
- Dynamics 365 Field Service

You can integrate channels, such as telephony, messaging (SMS), chat and social channels with any of the single-session Dynamics 365 model-driven app to have an immersive experience.

More information: [Channel Integration Framework version 1.0](overview-channel-integration-framework.md)

## Channel Integration Framework version 2.0

You can use Dynamics 365 Channel Integration Framework version 2.0 to integrate a channel provider of your choice if your organization is using the multi-session app, Omnichannel for Customer Service. You can integrate the telephony channel to have an immersive experience.

More information: [Channel Integration Framework version 2.0](v2/overview-channel-integration-framework.md)

## Version 1.0 and 2.0

The matrix explains the various aspects of version 1.0 and 2.0.

|| Version 1.0 | Version 2.0 |
|--------------------------------|---------------------------|-------------------------------|
|Session| Single-session  | Multi-session|
|Channel | Telephony, messaging (SMS), chat and social channels | Telephony channels|
|Model-driven app | Dynamics 365 Customer Service <br> Dynamics 365 Sales <br> Dynamics 365 Project Service <br> Dynamics 365 Field Service | Omnichannel for Customer Service |
|Communication panel | Right side | Left side |
|Features| Support for one channel provider <br> Communication Panel Management APIs <br> CRUD Operations APIs <br> Miscellaneous Methods | Templates <br> Channel Analytics <br> Support for multiple telephony channel providers <br> Notification Management APIs <br> Application Tab Management APIs <br> Session Management APIs <br> Channel Analytics APIs <br> Miscellaneous Methods |

> [!div class="mx-imgBorder"]
> ![Differences in version 1.0 and 2.0](media/choose-between-version.png "Differences in version 1.0 and 2.0")

## See also

[Channel Integration Framework version 1.0](overview-channel-integration-framework.md)

[Channel Integration Framework version 2.0](v2/overview-channel-integration-framework.md)