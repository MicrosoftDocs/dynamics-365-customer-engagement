---
title: "canCreateTab (JavaScript API Reference) for multi-session apps | MicrosoftDocs"
description: "Learn about the canCreateTab API for the multi-session apps such as Omnichannel for Customer Service and Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# canCreateTab

Allows you to check whether a new tab can be created in a given session.

> [!Note]
> Customer Service workspace lets you open up to 10 tabs simultaneously, in a given session. If you open more than 10 tabs, then the message&mdash;"Maximum tabs reached. Close a tab in this session before opening another."&mdash;is displayed.

## Syntax

`Microsoft.Apm.getFocusedSession().canCreateTab();`


## Return value

A Boolean value of true if a new tab can be created; otherwise false.


## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.canCreateTab());
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
