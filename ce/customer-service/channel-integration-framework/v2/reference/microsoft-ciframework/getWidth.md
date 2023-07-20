---
title: "getWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getWidth method in JavaScript API Reference for Channel Integration Framework 2.0."
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

# getWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getWidth](includes/getWidth-description.md)]

[!INCLUDE[token-getWidth](../../../shared/token-getWidth.md)]

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
