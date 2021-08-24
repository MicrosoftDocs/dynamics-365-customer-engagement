---
title: "close (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the close API to close the session for the multi-session apps such as Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# close

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
