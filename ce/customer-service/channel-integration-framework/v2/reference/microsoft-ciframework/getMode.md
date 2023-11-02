---
title: "getMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0| MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getMode method in JavaScript API Reference for Channel Integration Framework 2.0."
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

# getMode (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getMode](includes/getMode-description.md)]

[!INCLUDE[token-getMode](../../../shared/token-getMode.md)]


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
