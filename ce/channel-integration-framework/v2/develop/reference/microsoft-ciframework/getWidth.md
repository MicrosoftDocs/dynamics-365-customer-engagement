---
title: getWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0
description: Includes description, syntax, and parameter information for the getWidth method in JavaScript API Reference for Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# getWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getWidth](../../../../v1/develop/reference/microsoft-ciframework/Includes/getWidth-description.md)]

[!INCLUDE[token-getWidth](../../../../shared/token-getWidth.md)]

## Example

```Javascript
Microsoft.CIFramework.getWidth().then(
    function (result) {
        // result will have width of the panel, in pixels.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
