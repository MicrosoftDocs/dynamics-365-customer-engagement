---
title: "getTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the getTab API for the multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getTab

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
