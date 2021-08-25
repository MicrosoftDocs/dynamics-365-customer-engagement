---
title: "getFocusedTab method (app profile manager) JavaScript API Reference| MicrosoftDocs"
description: "Learn about the getFocusedTab API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: getFocusedTab (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

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
