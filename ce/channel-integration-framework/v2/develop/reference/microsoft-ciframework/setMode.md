---
title: setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Learn about setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 05/05/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

 > [!NOTE]  
 > Use this API only when the focused session belongs to the provider.

[!INCLUDE[setMode](../../../../v1/develop/reference/microsoft-ciframework/Includes/setMode-description.md)]

[!INCLUDE[token-setMode](../../../../shared/token-setMode.md)]


## Example

```Javascript
// Setting Panel to minimize mode.
Microsoft.CIFramework.setMode(0).then(
    function (result) {
        // result will have current state of the panel.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
