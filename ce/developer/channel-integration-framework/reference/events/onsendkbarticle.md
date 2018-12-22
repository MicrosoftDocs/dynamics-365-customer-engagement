---
title: "onsendkbarticle (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 12/10/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: D167093B-9F05-4184-8342-2F5FB0415ECC
author: kabala123
ms.author: kabala
manager: shujoshi
---

# onsendkbarticle event (CIF JavaScript API reference)

The `onsendkbarticle` event is invoked when the user selects the **Send** button in the Knowledge Base control. The eventData are the URL and the title of KB article that you need to pass.

## eventData

The `eventData` event takes following eventData:

| eventData | Example |
|-----------|---------|
| ```{'title": <KB article title>, "link": <url>} ``` | ```{"title": "KB Article about Microsoft Developer Guide", "link": "https://docs.microsoft.com/dynamics365/customer-engagement/developer/developer-guide"}``` |

## Related topics

- [addHandler](../microsoft-ciframework/addHandler.md)

- [removeHandler](../microsoft-ciframework/removeHandler.md)