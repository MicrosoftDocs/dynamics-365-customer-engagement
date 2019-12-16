---
title: "onpagenavigate (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
---

# onpagenavigate event (CIF JavaScript API reference)

The `onpagenavigate` event is invoked when the main Unified Interface page navigation occurs. The eventData URL is the navigated Unified Interface page URl.

## eventData

The `onpagenavigate` event takes following eventData:

| eventData | Example |
|-----------|---------|
| ```{"value": <url>}``` | ```{"value": "https://mycrmorg.dynamics.com/<Org>/main.aspx?appid=25ac68f2-9ab5-e811-8149-000d3a43f05f&pagetype=entitylist&etn=contact"}``` |

## Related topics

- [addHandler](../microsoft-ciframework/addHandler.md)

- [removeHandler](../microsoft-ciframework/removeHandler.md)

