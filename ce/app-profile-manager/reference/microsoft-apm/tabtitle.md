---
title: "title property of the tab (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the tab title property of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: title (app profile manager tab) 

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The text label of a tab.

## Example

```JavaScript
const tab= Microsoft.Apm.getFocusedSession().getFocusedTab();
tab.title = "New Tab Title";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
