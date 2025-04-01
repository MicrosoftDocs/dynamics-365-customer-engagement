---
title: getFocusedTab method (app profile manager) JavaScript API Reference
description: Learn about the getFocusedTab API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getFocusedTab (app profile manager)

Returns the tab object of the tab that is in focus.

## Syntax

`Microsoft.Apm.getFocusedSession().getFocusedTab();`

## Return value

The tab object.

## Example

```JavaScript
const tab = Microsoft.Apm.getFocusedSession().getFocusedTab();
tab.refresh();
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
