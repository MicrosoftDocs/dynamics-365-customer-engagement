---
title: getTab method (app profile manager) JavaScript API Reference
description: Learn about the getTab API of app profile manager in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 06/17/2025
ms.topic: reference
---

# getTab (app profile manager)

Returns the tab object for a tab identifier.

## Syntax

`Microsoft.Apm.getFocusedSession().getTab();`

## Return value

Collection of tab identifiers.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.getTab("tab-id-1").refresh();
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
