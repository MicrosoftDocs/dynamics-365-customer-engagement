---
title: "canClose property of a session (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager canClose property of a session in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: canClose (app profile manager session)

Boolean value indicating whether a given session can be closed.

> [!Note]
> If canClose property is set to false, then the button to close a session from the session panel is hidden. Else, the close button is visible when hovering over the session on the session panel.

## Return value

None

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.canClose = false;
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
