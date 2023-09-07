---
title: "getClickToAct (JavaScript API Reference) for Microsoft Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getClickToAct method in JavaScript API Reference for Channel Integration Framework 2.0."
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

# getClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getClickToAct](includes/getClickToAct-description.md)]

[!INCLUDE[token-getClickToAct](../../../shared/token-getClickToAct.md)]

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
