---
title: "Modes and locations for the communication widget | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/25/2019
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# Preview: Modes and locations for the communication widget

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

Dynamics 365 Channel Integration Framework version 2.0 supports following modes.

## Docked

The docked mode is the default mode of the communication widget, where it is placed between the session panel and the application tab panel.

## Minimized

The minimized mode is an overlay mode where the communication widget is reduced to a smaller size to give agents more screen space to view the applications. 

This is generally useful for agents who have started talking to the customer and need only minimal actions (for example, hold and mute) on the communication widget and thus can use the space to view more info on the application tab panel.

## Hidden

The communication panel is not visible, but the communication widget code is running in the background.

An agent can manually switch the mode from docked to minimized and vice versa.

Providers can switch the mode using APIs. For more information, see [setMode](reference/microsoft-ciframework/setMode.md) and [getMode](reference/microsoft-ciframework/getMode.md) APIs.

Providers can also decide on the mode of the communication widget when they are starting a session.

## See also

[setMode (JavaScript API reference)](reference/microsoft-ciframework/setMode.md)<br />
[getMode (JavaScript API reference)](reference/microsoft-ciframework/getMode.md)
