---
title: "title property of the session (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager title property of sessions in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# title (app profile manager session)

The text label of a given session.

> [!Note]
> The title of the Home session cannot be changed.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
session.title = "Testing";
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
