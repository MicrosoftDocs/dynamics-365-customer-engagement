---
title: "tabID property JavaScript API Reference | MicrosoftDocs"
description: "Learn about the tabID property in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# tabID

The identifier of a tab.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
const tabId = session.getFocusedTab().tabId;
console.log(tabId);
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
