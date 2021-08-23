---
title: "canClose property (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the canClose property of the session for multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# canClose

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
