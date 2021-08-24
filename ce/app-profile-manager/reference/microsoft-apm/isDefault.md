---
title: "isDefault property (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the isDefault property of the session for multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# isDefault

Boolean value indicating whether a given session is the Home session.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.isDefault);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
