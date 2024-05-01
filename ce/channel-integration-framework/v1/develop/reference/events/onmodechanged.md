---
title: "onmodechanged (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 1.0 | MicrosoftDocs"
description: "Learn about the onmodechanged event raised by the Channel Integration Framework library in Dynamics 365 Channel Integration Framework 1.0."
ms.date: 04/23/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# onmodechanged event (JavaScript API reference) for Dynamics 365 Channel Integration Framework 1.0

The `onmodechanged` event is invoked when the panel mode is manually toggled between **Minimized (0)** and **Docked (1)**.

## eventData

The `onmodechanged` event takes the following eventData:

| eventData | Example |
|-----------|---------|
| ```{"value": <number>}``` | ```{"value": 0"}``` |

### See also

[setMode](../microsoft-ciframework/setMode.md)  
[getMode](../microsoft-ciframework/getMode.md)  
[addHandler](../microsoft-ciframework/addHandler.md)  
[removeHandler](../microsoft-ciframework/removeHandler.md)  


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
