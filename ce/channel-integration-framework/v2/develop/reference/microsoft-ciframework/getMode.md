---
title: getMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0
description: Includes description, syntax, and parameter information for the getMode method in JavaScript API Reference for Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# getMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getMode](../../../../v1/develop/reference/microsoft-ciframework/Includes/getMode-description.md)]

[!INCLUDE[token-getMode](../../../../shared/token-getMode.md)]


## Example

```JavaScript
Microsoft.CIFramework.getMode().then(
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
