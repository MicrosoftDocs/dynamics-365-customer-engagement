---
title: "setWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0| MicrosoftDocs"
description: "Learn about setWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.custom: 
  - dyn365-a11y
  - dyn365-developer
---

# setWidth (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[setWidth](includes/setWidth-description.md)]

[!INCLUDE[token-setWidth](../../../shared/token-setWidth.md)]

## Example

```Javascript
// Setting Panel Width to 500
Microsoft.CIFramework.setWidth(500).then(
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
