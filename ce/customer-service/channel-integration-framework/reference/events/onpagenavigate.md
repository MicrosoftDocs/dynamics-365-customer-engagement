---
title: "onpagenavigate (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
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
ms.assetid: 106AB52E-F2B9-4C17-8FBC-54D71BF80D7D
author: susikka
ms.author: susikka
manager: shujoshi
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

