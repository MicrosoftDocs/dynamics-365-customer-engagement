---
title: title property of the session (app profile manager) JavaScript API Reference 
description: Learn about the session title property of app profile manager in Copilot Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 03/18/2025
ms.topic: reference
---

# title (app profile manager session)

The text label of a session.

> [!NOTE]
> The title of the Home session cannot be changed.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.title = "Testing";
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
