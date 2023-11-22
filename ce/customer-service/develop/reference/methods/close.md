---
title: "close method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the close API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# close (app profile manager)

Closes a session.

> [!Note]
> The Home session cannot be closed.

## Syntax

`Microsoft.Apm.getFocusedSession().close();`
`Microsoft.Apm.getSession(sessionId).close();`


## Return value

None.

## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
if (session.canClose) {
	session.close();
}

```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
