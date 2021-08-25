---
title: "canClose property of a tab (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canClose tab property for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: canClose (app profile manager tab)

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

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
