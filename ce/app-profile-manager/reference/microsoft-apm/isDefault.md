---
title: "isDefault property (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the isDefault session property of app profile manager in for Customer Service workspace."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 10/01/2021
ms.topic: reference
---

# isDefault (app profile manager)

Boolean value indicating whether a session is the Home session.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.isDefault);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
