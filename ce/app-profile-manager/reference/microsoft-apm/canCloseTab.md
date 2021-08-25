---
title: "canClose property of a tab (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canClose property of a tab in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# canClose (app profile manager)

A Boolean value indicating whether a given tab can be closed.

> [!Note]
> If canClose property is set to false, then the button to close the tab is hidden. Else, the close button is visible.

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
