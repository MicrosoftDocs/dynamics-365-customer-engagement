---
title: "getFocusedTab method (app profile manager) JavaScript API Reference| MicrosoftDocs"
description: "Learn about the getFocusedTab API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
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

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
