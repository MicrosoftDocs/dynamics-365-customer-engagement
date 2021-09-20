---
title: "tabID property (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the tabID property of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# tabID (app profile manager)

The identifier of a tab.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
const tabId = session.getFocusedTab().tabId;
console.log(tabId);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
