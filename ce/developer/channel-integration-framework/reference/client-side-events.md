---
title: "Client-side (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 12/10/2018
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 419901A4-0D14-429A-84D6-C351163B8941
author: susikka
ms.author: susikka
manager: shujoshi
---

# Events (CIF JavaScript API reference)

All client-side code is initiated by events and the events occur in Dynamics 365 Unified Interface. You associate s specific function in a JavaScript library to execute when an event occurs. This specific function is called an *event handler*.

Each event handler specifies a function within a JavaScript library and the parameters that you can pass to the function. The JavaScript API provides methods that you can use to attach event handlers to the events.

## Events

| Events | Description |
|---------|-------------|
| [onclicktoact]() | Invoked when user selects the outbound communication (ClickToAct) field in a form. |
| [onmodechanged]() | Invoked when the panel mode is manually toggled between **Minimized (0)** and **Docked (1)**. |
| [onpagenavigate]() | Invoked when the main Unified Interface page navigation occurs. |
| [onsendkbarticle]() | Invoked when the user selects the **Send** button in the Knowledge Base control. |
| [onsizechanged]() | Invoked when the side panel width is changed. |