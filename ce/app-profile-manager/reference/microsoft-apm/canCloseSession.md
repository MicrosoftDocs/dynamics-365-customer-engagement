---
title: "canClose property of a session (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the canClose session property of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: canClose (app profile manager session)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

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
