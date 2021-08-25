---
title: "getTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager getTab API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: getTab (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Returns the tab object for a given tab identifier.

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
