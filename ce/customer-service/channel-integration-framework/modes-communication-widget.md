---
title: "Modes and locations for the communication widget | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: 25004203-DE03-4DEC-BE4A-E4E89784A4F3
author: susikka
ms.author: susikka
manager: shujoshi
---

# Modes and locations for the communication widget

Channel Integration Framework version 2.0 supports following modes:

- **Docked**

The docked mode is the default mode of the communication widget, where it is placed between the session panel and the application tab panel.

- **Minimized**

The minimized mode is an overlay mode where the communication widget is reduced to a smaller size to allow agents have more screen space to view the applications. This is generally useful for agents who have started talking to the customer and need only minimal actions (e.g. hold, mute etc.) on the communication widget and thus can use the space to view more info on the application tab panel.

- **Hidden**

The communication panel is not visible, but the communication widget code is running in the background.

Agent can manually switch the mode from docked to minimized and vice versa

Providers can switch the mode using APIs. For more information, see Modes and location APIs.

Providers can also decide the mode of the communication widget when they are starting a session.

## See also

[setMode (JavaScript API reference)](reference/microsoft-ciframework/setMode.md)<br />
[getMode (JavaScript API reference)](reference/microsoft-ciframework/getMode.md)