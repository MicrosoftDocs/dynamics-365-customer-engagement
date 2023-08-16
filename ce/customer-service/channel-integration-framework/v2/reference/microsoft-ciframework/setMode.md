---
title: "setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
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

# setMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[setMode](includes/setMode-description.md)]

[!INCLUDE[token-setMode](../../../shared/token-setMode.md)]


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
