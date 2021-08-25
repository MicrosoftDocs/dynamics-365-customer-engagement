---
title: "focusTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager focusTab API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# focusTab (app profile manager)

Sets the focus on a specified tab in the current session.

## Syntax

`Microsoft.Apm.focusTab(tabId);`

## Parameters

| Name      | Type | Required| Description                                    |
|-----------------|----------|--------------|------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab to be focused. |

## Return value

None.

## Examples

The following examples use the `focusTab` method to focus on a given tab.
### Focusing a tab using Microsoft.Apm.focusTab(tabId)
 ```JavaScript
Microsoft.Apm.focusTab("tab-id-5);
```

### Focusing a tab using Microsoft.Apm.getFocusedSession().getTab().close()

```JavaScript
Microsoft.Apm.getFocusedSession().getTab("tab-id-5").focus();
```



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
