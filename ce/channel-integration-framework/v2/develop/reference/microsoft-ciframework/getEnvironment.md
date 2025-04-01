---
title: getEnvironment (JavaScript API Reference) for Microsoft Dynamics 365 Channel Integration Framework 2.0 
description: Includes reference information such as description, syntax, and parameters for the getEnvironment method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getEnvironment (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getEnvironment](../../../../v1/develop/reference/microsoft-ciframework/Includes/getEnvironment-description.md)]

[!INCLUDE[token-getEnvironment](../../../../shared/token-getEnvironment.md)]

## Example

```Javascript
Microsoft.CIFramework.getEnvironment().then(
    function (result) {
        // result will have the information about environment.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
