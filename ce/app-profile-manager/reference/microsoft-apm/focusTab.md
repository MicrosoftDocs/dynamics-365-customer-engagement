---
title: "focusTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the focusTab API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
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

The following examples use the `focusTab` method to set the focus on a specified tab.

### Set a tab in focus using Microsoft.Apm.focusTab(tabId)

 ```JavaScript
Microsoft.Apm.focusTab("tab-id-5);
```

### Set a tab in focus using Microsoft.Apm.getFocusedSession().getTab().focus()

```JavaScript
Microsoft.Apm.getFocusedSession().getTab("tab-id-5").focus();
```



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
