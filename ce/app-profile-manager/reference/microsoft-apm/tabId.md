---
title: "tabID property (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the tabID property of the session for multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# tabID

The identifier of a given tab.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
const tabId = session.getFocusedTab().tabId;
console.log(tabId);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
