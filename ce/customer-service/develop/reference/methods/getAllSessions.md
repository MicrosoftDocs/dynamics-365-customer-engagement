---
title: "getAllSessions method JavaScript API Reference | MicrosoftDocs"
description: "Learn about the getAllSessions API in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# getAllSessions

Returns the unique identifier of all sessions.

## Syntax

`Microsoft.Apm.getAllSessions();`

## Return value

Collection of session identifiers.

## Example

```JavaScript
const sessionIds = Microsoft.Apm.getAllSessions();
sessionIds.forEach(id=> {
        console.log(id);
});
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
