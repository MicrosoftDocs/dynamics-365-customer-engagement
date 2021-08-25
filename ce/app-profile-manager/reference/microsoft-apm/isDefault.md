---
title: "isDefault property (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager isDefault session property for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: isDefault (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Boolean value indicating whether a given session is the Home session.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.isDefault);
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
