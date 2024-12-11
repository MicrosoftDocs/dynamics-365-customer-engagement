---
title: refreshTab method (app profile manager) JavaScript API Reference 
description: Learn about the refreshTab API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# refreshTab (app profile manager)

Refreshes the app tab in the current session.

## Syntax

`Microsoft.Apm.refreshTab(tabId);`


## Parameters

| **Name**        | **Type** | **Required** | **Description**                                      |
|-----------------|----------|--------------|------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab that has to be refreshed. |

## Return value

None.

## Examples

The following examples use the `refreshTab` method to refresh a specified tab.

### Refresh a tab using `refreshTab` method

```JavaScript
Microsoft.Apm.refreshTab("tab-id-2")
```

### Refresh a tab using `refresh` method

```JavaScript
Microsoft.Apm.getFocusedSession().getFocusedTab().refresh();
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
