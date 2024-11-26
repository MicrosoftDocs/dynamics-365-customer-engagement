---
title: setClickToAct (JavaScript API Reference) for Channel Integration Framework 2.0 
description: Learn about setClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 01/23/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# setClickToAct (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[setClickToAct](../../../../v1/develop/reference/microsoft-ciframework/Includes/setClickToAct-description.md)] You must have the msdyn_writechannelprovider privilege to use this API. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges).

## Syntax

`Microsoft.CIFramework.setClickToAct(value).then(successCallback, errorCallback);`

## Parameters

| Name            | Type     | Required | Description                                       |
|-----------------|----------|----------|---------------------------------------------------|
| value           | Boolean  | Yes      | Sets the value to enable or disable ClickToAct.   |
| successCallback | Function | No       | A function to call when the request is successful. |
| errorCallback   | Function | No       | A function to call when the request fails.         |

## Return value

A Promise object with a null value if the request is successful. The API returns an error if the request fails.

## Examples
```Javascript

// To disable outbound communication.
Microsoft.CIFramework.setClickToAct(false).then(
    function (result) {
        // result will indicate whether the outbound communication is enabled or not.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```

```Javascript
// To enable outbound communication.
Microsoft.CIFramework.setClickToAct(true).then(
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
