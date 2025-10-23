---
title: getClickToAct (JavaScript API Reference) for Microsoft Dynamics 365 Channel Integration Framework 2.0 
description: Includes description, syntax, and parameter information for the getClickToAct method in JavaScript API Reference for Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getClickToAct](../../../../v1/develop/reference/microsoft-ciframework/Includes/getClickToAct-description.md)]

[!INCLUDE[token-getClickToAct](../../../../shared/token-getClickToAct.md)]

## Example

```Javascript
Microsoft.CIFramework.getClickToAct().then(
    function (result) {
        // result will indicate whether the outbound communication is enabled or not.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
