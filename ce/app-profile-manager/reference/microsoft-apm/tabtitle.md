---
title: "title property of the tab (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the tab title property of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/01/2021
ms.topic: reference
---

# title (app profile manager tab) 

The text label of a tab.

## Example

```JavaScript
const tab= Microsoft.Apm.getFocusedSession().getFocusedTab();
tab.title = "New Tab Title";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
