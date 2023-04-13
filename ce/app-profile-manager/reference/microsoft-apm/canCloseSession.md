---
title: "canClose property of a session (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the canClose session property of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# canClose (app profile manager session)

Boolean value indicating whether a session can be closed.

> [!Note]
> If the canClose property is set to false, then the button to close a session from the session panel is hidden. Otherwise, the close button is visible when hovering over the session on the session panel.

## Return value

None.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.canClose = false;
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
