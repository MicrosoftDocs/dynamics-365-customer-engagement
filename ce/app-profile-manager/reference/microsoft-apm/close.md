---
title: "close method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager close API in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: close (app profile manager)

Closes a session.

> [!Note]
> The Home session cannot be closed.

## Syntax

`Microsoft.Apm.getFocusedSession().close();`
`Microsoft.Apm.getSession(sessionId).close();`


## Return value

None

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
if (session.canClose) {
	session.close();
}

```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
