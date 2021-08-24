---
title: "canCloseTab property (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the canCloseTab property of the tab for multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# canCloseTab

A Boolean value indicating whether a given tab can be closed.

> [!Note]
> If canCloseTab property is set to false, then the button to close the tab is hidden. Else, the close button is visible.

## Return value

None

## Example

```JavaScript
const tab = Microsoft.Apm.getFocusedSession().getFocusedTab();
if (tab.canClose) {
    tab.close();
}
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
