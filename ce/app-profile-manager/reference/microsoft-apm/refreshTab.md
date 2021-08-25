---
title: "refreshTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager refreshTab API in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# refreshTab (app profile manager)

Refreshes the app tab in the current session.

## Syntax

`Microsoft.Apm.refreshTab(tabId);`
<!--`Microsoft.Apm.refreshTab(tabId).then(successCallback, errorCallback);`-->

## Parameters

| **Name**        | **Type** | **Required** | **Description**                                      |
|-----------------|----------|--------------|------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab that has to be refreshed. |
<!--| successCallback | Function | No           | A function to call when a record is retrieved.       |
| errorCallback   | Function | No           | A function to call when the operation fails.         |
-->
## Return value

None

## Examples

The following examples use the `refreshTab` method to refresh a given tab.

### Refreshing a tab using `refreshTab` method

```JavaScript
Microsoft.Apm.refreshTab("tab-id-2")
```

### Refreshing a tab using `refresh` method

```JavaScript
Microsoft.Apm.getFocusedSession().getFocusedTab().refresh();
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
