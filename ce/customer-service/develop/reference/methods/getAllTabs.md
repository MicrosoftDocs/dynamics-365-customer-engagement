---
title: getAllTabs method (app profile manager) JavaScript API Reference 
description: Learn about the getAllTabs API of app profile manager in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 06/17/2025
ms.topic: reference
---

# getAllTabs (app profile manager)

Returns the unique identifiers of all tabs for a specified session.

## Syntax

`Microsoft.Apm.getFocusedSession().getAllTabs();`

## Return value

Collection of tab identifiers.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.getAllTabs().forEach(id => {
	const tab = session.getTab(id);
	console.log(tab.title);
});
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
