---
title: "onsendkbarticle (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
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
