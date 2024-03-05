---
title: "canClose property of a tab JavaScript API Reference | MicrosoftDocs"
description: "Learn about the canClose tab property in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# canClose

A Boolean value indicating whether a tab can be closed.

> [!Note]
> If the canClose property is set to false, then the button to close the tab is hidden. Otherwise, the close button is visible.

## Return value

None.

## Example

```JavaScript
const tab = Microsoft.Apm.getFocusedSession().getFocusedTab();
if (tab.canClose) {
    tab.close();
}
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
