---
title: "requestFocus (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the requestFocus API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# requestFocus

Shows a notification indicator on a given session if the session is not focused.

## Syntax

` Microsoft.Apm.getSession(sessionId).requestFocus();`

## Example

```JavaScript
Microsoft.Apm.getSession("session-id-4").requestFocus();
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
