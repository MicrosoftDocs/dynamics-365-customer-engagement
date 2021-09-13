---
title: "canCreateTab method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the canCreateTab API of app profile manager in Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: canCreateTab (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Allows you to check whether a new tab can be created in a session.

> [!Note]
> Customer Service workspace lets you open up to 10 tabs simultaneously, in a session. If you open more than 10 tabs, then the following message is displayed: "Maximum tabs reached. Close a tab in this session before opening another."

## Syntax

`Microsoft.Apm.getFocusedSession().canCreateTab();`

## Return value

A Boolean value of true if a new tab can be created; otherwise, false.


## Example

```JavaScript
const session = Microsoft.Apm.getFocusedSession();
console.log(session.canCreateTab());
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
