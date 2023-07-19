---
title: "getEntityMetadata (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes description, syntax, and parameter information for the getEntityMetadata method in JavaScript API Reference for Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# getEntityMetadata (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[getEntityMetadata-description](includes/getEntityMetadata-description.md)] 

[!INCLUDE[token-getEntityMetadata](../../../shared/token-getEntityMetadata.md)]

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
