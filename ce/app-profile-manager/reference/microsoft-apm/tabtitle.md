---
title: "title property of the tab (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager title property of the tab in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# title (app profile manager) 

The text label of a given tab.

## Example

```JavaScript
const tab= Microsoft.Apm.getFocusedSession().getFocusedTab();
tab.title = "New Tab Title";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
