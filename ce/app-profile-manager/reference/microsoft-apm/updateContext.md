---
title: "updateContext method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the app profile manager updateContext API for Customer Service workspace."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/25/2021
ms.topic: reference
---

# Preview: updateContext (app profile manager)

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Allows you to set the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for future macro invocations.

## Syntax

`Microsoft.Apm.getFocusedSession().updateContext(input);`

## Parameters

| Name             | Type     | Required | Description |
|------------------|----------|----------|---------------------------------------------|
| input            | String   | Yes      | JSON input properties of the session context to be updated. |


## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getFocusedSession().updateContext({"customerName":"Contoso"});
```

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
