---
title: focusTab method (app profile manager) JavaScript API Reference
description: Learn about the focusTab API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
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



[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
