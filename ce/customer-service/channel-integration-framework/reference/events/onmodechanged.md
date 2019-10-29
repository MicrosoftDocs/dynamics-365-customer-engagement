---
title: "onmodechanged (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/21/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
ms.assetid: CE3EB64F-F73F-421B-BB16-FA269ED43086
author: susikka
ms.author: susikka
manager: shujoshi
---

# onmodechanged event (CIF JavaScript API reference)

The `onmodechanged` event is invoked when the panel mode is manually toggled between **Minimized (0)**, **Docked (1)** and **Hidden (2)**.

## eventData

The `onmodechanged` event takes following eventData:

| eventData | Example |
|-----------|---------|
| ```{"value": <number>}``` | ```{"value": 0"}``` |

## Related topics

- [setMode](../microsoft-ciframework/setMode.md)

- [getMode](../microsoft-ciframework/getMode.md)

- [addHandler](../microsoft-ciframework/addHandler.md)

- [removeHandler](../microsoft-ciframework/removeHandler.md)