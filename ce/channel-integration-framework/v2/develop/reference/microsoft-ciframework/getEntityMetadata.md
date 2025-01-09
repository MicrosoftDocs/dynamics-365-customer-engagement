---
title: getEntityMetadata (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 |
description: Includes description, syntax, and parameter information for the getEntityMetadata method in JavaScript API Reference for Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# getEntityMetadata (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getEntityMetadata-description](../../../../v1/develop/reference/microsoft-ciframework/Includes/getEntityMetadata-description.md)] 

[!INCLUDE[token-getEntityMetadata](../../../../shared/token-getEntityMetadata.md)]

## Examples

```Javascript
// Get the metadata of "account" entity    
Microsoft.CIFramework.getEntityMetadata("account").then(
    function (result) {
        // result will have metadata of account, no attribute information will be fetched as the optional list is not passed.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```
```Javascript
// Get the metadata of "account" entity with empty attributes list.  
Microsoft.CIFramework.getEntityMetadata("account", []).then(
    function (result) {
        // result will have metadata of account, no attribute information will be fetched as the attributes list passed is empty.
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```
```Javascript

// Get the metadata of "account" entity with specific attributes "createdon" and "name" info.  
Microsoft.CIFramework.getEntityMetadata("account", ['createdon', 'name']).then(
    function (result) {
        // result will have metadata of account, as well as attribute information for "createdon" and "name".
        console.log(result)
    },
    function (error) {
        // code handling for promise failure
        console.log(error)
    });
```

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
