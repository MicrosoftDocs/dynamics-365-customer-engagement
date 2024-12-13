---
title: updateContext method (app profile manager) JavaScript API Reference 
description: Learn about the updateContext API of app profile manager in Customer Service workspace.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# updateContext (app profile manager)

Allows you to set the automation dictionary and enables providers to add, modify, and remove values of slugs; the updated values are then available for invoking macros in the future.

## Syntax

`Microsoft.Apm.getFocusedSession().updateContext(input);`

## Parameters

| Name             | Type     | Required | Description |
|------------------|----------|----------|---------------------------------------------|
| input            | JSON  | Yes      | JSON input properties of the session context to be updated. |


## Return value

None.

## Example

```JavaScript
Microsoft.Apm.getFocusedSession().updateContext({"customerName":"Contoso"});
Microsoft.Apm.getFocusedSession().getContext().then((context)=> context.get("customerName")).then(
    function success(result) {
        console.log(result);
        // should expected "Contoso"
        // Perform operations upon record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // Handle error conditions
    }
);
```

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
