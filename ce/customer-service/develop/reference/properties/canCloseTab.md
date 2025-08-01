---
title: canClose property of a tab (app profile manager) JavaScript API Reference
description: Learn about the canClose tab property of app profile manager in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 06/17/2025
ms.topic: reference
---

# canClose (app profile manager tab)

A Boolean value indicating whether a tab can be closed.

> [!NOTE]
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
