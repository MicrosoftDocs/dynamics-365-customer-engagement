---
title: "title property of the session (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the title property of the session for multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# title

The text label of a given session.

> [!Note]
> The title of the Home session cannot be changed.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.title = "Testing";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
