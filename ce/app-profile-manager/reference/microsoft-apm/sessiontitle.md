---
title: "title property of the session (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the session title property of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# title (app profile manager session)

The text label of a session.

> [!Note]
> The title of the Home session cannot be changed.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.title = "Testing";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
