---
title: "title property of the tab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the title property of the tab for multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# title    

The text label of a given tab.

## Example

```JavaScript
const tab= Microsoft.Apm.getFocusedSession().getFocusedTab();
tab.title = "New Tab Title";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
