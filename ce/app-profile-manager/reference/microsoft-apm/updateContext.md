---
title: "updateContext method (app profile manager) JavaScript API Reference | MicrosoftDocs"
description: "Learn about the updateContext API of app profile manager in Customer Service workspace."
author: gandhamm
ms.author: mgandham
ms.date: 10/01/2021
ms.topic: reference
---

# updateContext (app profile manager)

Allows you to set the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for invoking macros in the future.

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
