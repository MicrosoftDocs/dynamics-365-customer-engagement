---
title: "title property of the session JavaScript API Reference | MicrosoftDocs"
description: "Learn about the session title property in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# title

The text label of a session.

> [!Note]
> The title of the Home session cannot be changed.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.title = "Testing";
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
