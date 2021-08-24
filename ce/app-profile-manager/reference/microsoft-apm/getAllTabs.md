---
title: "getAllTabs (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the getAllTabs API for the multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# getAllTabs

Returns the unique identifiers of all tabs for a given session.

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

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
