---
title: "getFocusedTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the getFocusedTab API for the multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getFocusedTab

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
