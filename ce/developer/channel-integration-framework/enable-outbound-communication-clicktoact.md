---
title: "How to enable outbound communication (ClickToAct) in Channel Integration Framework (CIF) | Microsoft Docs"
description: "Learn enable or configure outbound communication (ClickToAct) in Channel Integration Framework (CIF) for Microsoft Dynamics 365."
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: E0E45AC7-E516-46B5-ADBC-77254CBA8A2F
author: kabala123
ms.author: kabala
manager: shujoshi
---

# How to enable outbound communication (ClickTOAct) in Channel Integration Framework?

To enable outbound communication for your channel, you must perform the following:

- **Setp 1:** In the channel provier configurations, set the **Enable Outboud Communication** field to **Yes**.

- **Step 2:** In the Unified Interface form, add the **Channel communication control** to the **Phone** field for which you want to enable outbound communication (ClickToAct), and publish the customizations.

- **Step 3:** Register the handler in your JavaScript code using `Microsoft.CIFramework.addHandler(“onclicktoact”, <handlerFunction>)` 