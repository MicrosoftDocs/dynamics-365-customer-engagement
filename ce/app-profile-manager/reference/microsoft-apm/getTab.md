---
title: "getTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getTab API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/01/2021
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

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
