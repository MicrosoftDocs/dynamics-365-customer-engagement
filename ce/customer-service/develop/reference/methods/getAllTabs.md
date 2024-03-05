---
title: "getAllTabs method JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getAllTabs API in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# getAllTabs

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
