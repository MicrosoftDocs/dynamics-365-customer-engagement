---
title: "getEnvironment (JavaScript API Reference) for Microsoft Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the getEnvironment method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getEnvironment (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getEnvironment](includes/getEnvironment-description.md)]

[!INCLUDE[token-getEnvironment](../../../shared/token-getEnvironment.md)]

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
