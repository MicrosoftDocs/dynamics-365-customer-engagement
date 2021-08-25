---
title: "closeTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canCreateSession API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# closeTab (app profile manager)

Closes the specified app tab in the current session.

> [!Note]
> The anchor tab of a session (the first tab) cannot be closed.
## Syntax

`Microsoft.Apm.closeTab(tabId);`
<!--`Microsoft.Apm.closeTab(tabId).then(successCallback, errorCallback);`-->

## Parameters

| Name        | Type | Required | Description                               |
|-----------------|----------|--------------|------------------------------------------------------|
| tabId           | String   | Yes          | Unique identifier of the tab to be closed. |
<!--| successCallback | Function | No           | A function to call when a record is retrieved.       |
| errorCallback   | Function | No           | A function to call when the operation fails.         |-->

## Return value

None

## Examples

### Closing a tab using Microsoft.Apm.closeTab

```JavaScript
const tab = Microsoft.Apm.getFocusedSession().getFocusedTab();
if (tab.canClose) {
    Microsoft.Apm.closeTab(tab.tabId);
}
```
### Closing a tab using Microsoft.Apm.getFocusedSession().getFocusedTab().close()

```JavaScript
const tab = Microsoft.Apm.getFocusedSession().getFocusedTab();
if (tab.canClose) {
    tab.close();
}
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
